using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.Enumeradores.BorderoEnum;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Bordero;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Entidades.DaoManager.BorderoManager
{


    /// <summary>
    /// Implemente aqui toda a interacao do objeto com o NomeBanco de dados
    /// </summary>
    public class ChequeDaoManager
    {
        public async void UpdateSituacaoCheques()
        {

            using(var ctx = new BalcaoContext()){
            var cheques = await ctx.ChequeDao.WhereAsync(ch => ch.Situacao != TypeSituacaoCheque.Compensado && ch.Situacao != TypeSituacaoCheque.Cancelado);
                if (cheques != null)
                {
                    foreach (var item in cheques.ToList())
                    {
                        if (item.DataVencimento > DateTime.Now)
                            item.Situacao = TypeSituacaoCheque.Aberto;

                        else if (item.DataVencimento <= DateTime.Now)
                            item.Situacao = TypeSituacaoCheque.Vencido;

                        ctx.ChequeDao.Update(item);
                    }
                }
            }
        }

        public List<Cheque> FindChequesByPeriodo(TypeSituacaoCheque situcao,
            DateTime dtInicio, DateTime dtFinal)
        {
            using (var ctx = new BalcaoContext())
            {
                var cheques = ctx.ChequeDao.Where(ch => ch.DataLancamento >= dtInicio
                                                        && ch.DataVencimento <= dtFinal
                                                        && ch.Situacao == situcao).OrderBy(ch => ch.DataVencimento);

                return cheques.ToList();
            }

        }
        /// <summary>
        /// Traz todos os cheques 
        /// </summary>
        /// <param name="dtInicio"></param>
        /// <param name="dtFinal"></param>
        /// <returns></returns>
        public List<Cheque> FindChequesByPeriodo(DateTime dtInicio, DateTime dtFinal)
        {
            using (var ctx = new BalcaoContext())
            {
                var cheques = ctx.ChequeDao.Where(ch =>
                    ch.DataLancamento >= dtInicio
                    && ch.DataVencimento <= dtFinal).OrderBy(ch => ch.DataVencimento).OrderBy(ch => ch.DataVencimento);
                return cheques.ToList();
            }

        }

        public List<Cheque> FindChequeByPeriodo(CliFor cliente, DateTime dtInicio,
            DateTime dtFinal)
        {
            using (var ctx = new BalcaoContext())
            {
                var cheques = ctx.ChequeDao.Where(ch => ch.IdCliente == cliente.IdCliFor
                                                        && ch.DataLancamento >= dtInicio
                                                        && ch.DataVencimento <= dtFinal)
                    .OrderBy(ch => ch.DataVencimento)
                    .OrderBy(ch => ch.DataVencimento);

                return cheques.ToList();
            }

        }

        public List<Cheque> FindChequesBySituacao(TypeSituacaoCheque situacaoCheque)
        {
            using (var ctx = new BalcaoContext())
            {
                var cheques =
                    ctx.ChequeDao.Where(ch => ch.Situacao == situacaoCheque).OrderBy(ch => ch.DataVencimento).ToList();

                return cheques.ToList();
            }
        }

        public List<Cheque> FindChequesBySituacao(TypeSituacaoCheque situacaoCheque, CliFor cliente)
        {
            using (var ctx = new BalcaoContext())
            {
                var cheques = ctx.ChequeDao.Where(ch => ch.Situacao == situacaoCheque
                                                        && cliente.IdCliFor == ch.IdCliente)
                    .OrderBy(ch => ch.DataVencimento)
                    .ToList();

                return cheques.ToList();
            }
        }

        public List<Cheque> FindChequesVencidoNoDia()
        {
            DateTime dataAtual = DataUtil.GetCurrentDate().Date;
            using (var ctx = new BalcaoContext())
            {

                var cheques = ctx.ChequeDao.Where(ch =>
                    ch.DataVencimento == dataAtual &&
                    ch.Situacao != TypeSituacaoCheque.Cancelado &&
                    ch.Situacao != TypeSituacaoCheque.Compensado).OrderBy(ch => ch.DataVencimento).ToList();
                return cheques;
            }
        }

        public List<Cheque> FindChequesVencidos()
        {
            DateTime dataAtual = DateTime.Now.Date;
            using (var ctx = new BalcaoContext())
            {

                var cheques = ctx.ChequeDao.Where(ch =>
                    ch.DataVencimento <= dataAtual &&
                    ch.Situacao != TypeSituacaoCheque.Cancelado &&
                    ch.Situacao != TypeSituacaoCheque.Compensado).OrderBy(ch => ch.DataVencimento).ToList();
                return cheques;
            }
        }

        public async Task<List<Cheque>> FindChequeVencidosByCliente(CliFor cliente)
        {
            using (var ctx = new BalcaoContext())
            {

                try
                {
                    //DateTime dataAtual = DateTime.Now; //nao consulta
                    DateTime dataAtual = DateTime.Now.Date;
                    var cheques = await ctx.ChequeDao.WhereAsync(ch =>

                        ch.IdCliente == cliente.IdCliFor &&
                        ch.DataVencimento <= dataAtual &&
                        ch.Situacao != TypeSituacaoCheque.Cancelado &&
                        ch.Situacao != TypeSituacaoCheque.Compensado);

                    return cheques;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.InnerException);

                    return null;
                }
            }

        }

        public async Task<List<Cheque>> FindChequeCreditoVencidosByCliente(CliFor cliente)
        {
            using (var ctx = new BalcaoContext())
            {

                try
                {
                    //DateTime dataAtual = DateTime.Now; //nao consulta
                    DateTime dataAtual = DateTime.Now.Date;
                    var cheques = await ctx.ChequeDao.WhereAsync(ch =>

                        ch.IdCliente == cliente.IdCliFor &&
                        ch.DataVencimento <= dataAtual &&
                        ch.TipoLancamento == TypeLancamentoFinanceiro.Receber &&
                        ch.Situacao != TypeSituacaoCheque.Cancelado &&
                        ch.Situacao != TypeSituacaoCheque.Compensado);

                    return cheques;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.InnerException);

                    return null;
                }
            }

        }

        /// <summary>
        ///Compensa os cheques
        /// </summary>
        public bool CompensarCheques(List<Cheque> cheques)
        {
            using (var ctx = new BalcaoContext())
            {
                //validando o contexto
                foreach (var ch in cheques)
                {
                    //passando a chAtual para o contexto
                    var chAtual = ctx.ChequeDao.Find(ch.IdCheque);

                    //se nao foi setada uma data para compensacao
                    if (ch.DataCompensacao == null)
                        //use a data atual
                        ch.DataCompensacao = DateTime.Now;

                    //atualize a data
                    chAtual.DataCompensacao = ch.DataCompensacao;
                    //atualize a situação do cheque
                    chAtual.Situacao = TypeSituacaoCheque.Compensado;
                    //chAtual.Venda.DataVencimento = venda.DataVencimento;

                    //efetiva a transação no banco
                    if (!ctx.ChequeDao.Update(chAtual))
                    {
                        XMessageIts.Advertencia("Não foi possivél compensar o cheque : " + chAtual.NumeroCheque);
                        return false;
                    }

                }
                XMessageIts.Mensagem("Cheques compensado");
                return true;
            }
        }
    }

}
