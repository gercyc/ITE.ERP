using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Util;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITSolution.Framework.Beans.Forms;
using System.Text;
using ITE.Entidades.POCO.Sales;

namespace ITE.Entidades.DaoManager
{
    public class CaixaDaoManager
    {
        /// <summary>
        /// Adiciona um movimento no caixa
        /// </summary>

        public bool AddMovimentoCaixa(MovimentoCaixa movimento)
        {
            using (var ctx = new BalcaoContext())
            {
                return ctx.MovimentoCaixaDao.Save(movimento);
            }
        }

        public Task<List<MovimentoCaixa>> GetMovimentosByPeriodo(DateTime dtInicio, DateTime dtFinal, Usuario user)
        {
            var ctx = new BalcaoContext();
            ctx.LazyLoading(false);

            if (user == null)
            {
                //assim tenho q fazer join

                //var movimentos = from ms in ctx.MovimentoCaixas
                //                 where DbFunctions.TruncateTime(ms.DataMovimento) >= dtInicio
                //                    && DbFunctions.TruncateTime(ms.DataMovimento) <= dtFinal
                //                    select ms;
                //return movimentos.ToListAsync();

                return ctx.MovimentoCaixas
                    .Include(m => m.Usuario)
                    .Include(m => m.Venda)
                    .Include(m => m.Venda.FormaPagamentoVenda)
                    .Where(m => DbFunctions.TruncateTime(m.DataMovimento) >= dtInicio
                          && DbFunctions.TruncateTime(m.DataMovimento) <= dtFinal
                          && m.Venda.FormaPagamentoVenda.TipoFormaPagamento == TypeFormaPagamento.Dinheiro)
                    .ToListAsync();
            }
            else
            {

                return ctx.MovimentoCaixas
                   .Include(m => m.Venda)
                   .Include(m => m.Venda.FormaPagamentoVenda)
                   .Include(m => m.Usuario)
                   .Where(m => m.IdUsuario == user.IdUsuario
                            && DbFunctions.TruncateTime(m.DataMovimento) >= dtInicio
                            && DbFunctions.TruncateTime(m.DataMovimento) <= dtFinal)
                   .ToListAsync();
            }
        }

        public void AddMovimentoLancamento(LancamentoFinanceiro l)
        {

            using (var ctx = new BalcaoContext())
            {
                var movimento = new MovimentoCaixa
                {
                    ValorMovimento = l.ValorLancamento,
                    DataMovimento = DateTime.Now,
                    HistoricoMov = "Lançamento Nº: " + l.IdLancamento,
                    TipoMov = l.TipoLancamento == TypeLancamentoFinanceiro.Pagar
                            ? TypeMovimentacaoMonetaria.Debito
                            : TypeMovimentacaoMonetaria.Credito,
                    IdVenda = l.IdVenda,
                    IdUsuario = l.RecCreatedBy
                };

                ctx.MovimentoCaixaDao.Save(movimento);
            }
        }

        public void AddMovimentoLancamentos(List<LancamentoFinanceiro> lancamentos)
        {
            var msg = new StringBuilder();
            foreach (var l in lancamentos)
            {
                //gera movimento apenas dos lançamento da venda que está sendo paga
                if (l.IdVenda != null)
                    AddMovimentoLancamento(l);
                else
                    //forma de pilha
                    //primeira a entra eh o ultima a sair (visualmente)
                    msg.Append("Nº Lançamento: ").Append(l.IdLancamento).Append("\n").Append(msg);

            }
            if (!string.IsNullOrEmpty(msg.ToString()))
            {
                string msgTitle = "Lançamentos Avulsos\n";
                string msgSeparador = "===============================================================\n";
                msg.Append(msgTitle).Append(msgSeparador).Append(msg);
                XFrmOptionPane.ShowTextArea("Aviso - Os lançamentos abaixo não geraram movimento de caixa!!!",
                    msg.ToString());
            }
        }


        /// <summary>
        /// Adiciona um movimento de entrada a cada 
        /// Toda venda realizada ou cancelada invoca esse metodo
        /// </summary>
        /// <param name="venda"></param>
        public void AddMovimentoVenda(Venda venda, TypeMovimentacaoMonetaria tipoMov)
        {
            string hist = tipoMov.ToString() + " Venda Nº: " + venda.IdVenda;
            MovimentoCaixa mov = new MovimentoCaixa(venda, tipoMov, hist);

            this.AddMovimentoCaixa(mov);
        }

        /// <summary>
        /// A soma de todos os movimentos
        /// </summary>
        /// <returns></returns>
        public decimal GetSaldoTotal()
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    //busca a sessao aberta do dia
                    ctx.LazyLoading(false);

                    var credito = GetTotalMovimento(TypeMovimentacaoMonetaria.Credito);

                    var debitos = GetTotalMovimento(TypeMovimentacaoMonetaria.Credito);

                    return credito - debitos;
                }
            }
            catch
            {
                return 0;
            }
        }

        public decimal GetTotalMovimento(TypeMovimentacaoMonetaria mov)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    //busca a sessao aberta do dia
                    ctx.LazyLoading(false);
                    var total = ctx.MovimentoCaixas
                        .Where(m => m.TipoMov == mov)
                        .Sum(m => m.ValorMovimento);

                    return total;
                }
            }
            catch
            {
                return 0;
            }
        }

        public decimal GetSaldoDinheiro()
        {
            using (var ctx = new BalcaoContext())
            {
                decimal creditos = 0M;
                decimal debitos = 0M;
                try
                {

                    //busca a sessao aberta do dia
                    ctx.LazyLoading(false);

                    creditos = ctx.MovimentoCaixas
                                   .Include(m => m.Venda)
                                   .Include(m => m.Venda.FormaPagamentoVenda)
                                   .Where(m => m.TipoMov == TypeMovimentacaoMonetaria.Credito
                                               //das vendas a vista
                                               && m.Venda.FormaPagamentoVenda.TipoFormaPagamento ==
                                               TypeFormaPagamento.Dinheiro
                                               //ou as entradas q fizeram no caixa
                                               || m.TipoMov == TypeMovimentacaoMonetaria.Credito && m.IdVenda == null)
                                   //.DefaultIfEmpty() somente se Sum nao receber um "Func"
                                   .Sum(m => (decimal?)m.ValorMovimento) ?? 0;


                    debitos = ctx.MovimentoCaixas
                                  .Where(m => m.TipoMov == TypeMovimentacaoMonetaria.Debito
                                              || m.TipoMov == TypeMovimentacaoMonetaria.Estorno)
                                  .Sum(m => (decimal?)m.ValorMovimento) ?? 0;
                }
                catch (Exception ex)
                {
                    LoggerUtilIts.ShowExceptionMessage(ex);
                }
                return (creditos - debitos);
            }
        }

    }
}
