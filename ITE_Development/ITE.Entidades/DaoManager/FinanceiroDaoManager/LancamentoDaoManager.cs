using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITE.Entidades.Financeiro.POCO;

namespace ITE.Entidades.DaoManager.FinanceiroDaoManager
{
    /// <summary>
    /// Classe para os métodos de validação de negócio aqui.
    /// </summary>
    public class LancamentoDaoManager
    {
        /// <summary>
        /// Realiza a baixa dos lançamentos informados
        /// </summary>
        /// <param name="lancamentos"></param>
        /// <param name="conta"></param>
        /// <param name="dataBaixa"></param>
        /// <param name="frmPagto"></param>
        /// <returns></returns>
        public bool BaixarLancamentos(List<LancamentoFinanceiro> lancamentos,
            ContaBancaria conta, Nullable<DateTime> dataBaixa, FormaPagamento frmPagto)
        {
            //liberado manualmente
            var ctx = new BalcaoContext();

            bool transation = false;


            //Esse foreach eh muito sensivel
            //Entao deve se evitar mexer no objeto da estrutura dele
            foreach (var l in lancamentos)
            {
                //traz o lancamento pro contexto atual
                var current = ctx.LancamentoFinanceiroDao.Find(l.IdLancamento);

                //se a data da baixa enviada for nula, utilizar a data de vencimento (pra facilitar a geracao dos cenarios)
                if (dataBaixa == null)
                    dataBaixa = l.DataVencimento;
                else if (dataBaixa != l.DataVencimento)
                    dataBaixa = l.DataVencimento;
                else
                { }

                //valor da baixa
                var valorBaixa = l.TotalLancamento;

                //se o valor recebido informado for menor que o valor do lancamento
                //crie outro lançamento
                if (l.ValorLancamento < current.ValorLancamento)
                {
                    LancamentoFinanceiro pRestante = current.Clone();

                    //somente o valor sendo pago
                    pRestante.ValorLancamento = current.ValorLancamento - l.ValorLancamento;

                    //prolongue o prazo a partir da data do pagamento
                    var vencimento = dataBaixa.Value.AddDays(30);
                    //use a data do lançamento
                    pRestante.DiasPrazo = DataUtil.CalcularDias(l.DataLancamento, vencimento);

                    //sem juros
                    pRestante.ValorJuros = 0;

                    //incrementa o numero para nova parcela
                    pRestante.SequencialParcela = current.SequencialParcela + 1;


                    if (current.IdVenda != null)
                    {
                        var v = ctx.VendaDao.Find(current.IdVenda);

                        if (v.Parcelas.Count > 0)
                        {
                            var lastOrDefault = v.Parcelas.First();
                            current.Observacao = "REF. VENDA Nº.: " + v.IdVenda + " | PARCELA ALTERADA Nº: "
                                                 + lastOrDefault.SequencialParcela;

                            pRestante.Observacao = "REF. VENDA Nº.: " + v.IdVenda + " | PARCELA ADICIONAL Nº: "
                                                   + lastOrDefault.SequencialParcela + 1;
                        }
                    }
                    else
                    {
                        current.Observacao += " | PARCELA ALTERADA";
                        pRestante.Observacao += " | PARCELA ADICIONAL Nº:" + current.SequencialParcela + 1;
                    }


                    //salve a nova parcela

                    ctx.LancamentoFinanceiroDao.Save(pRestante);

                    //atualize o valor do lançamento sendo pago
                    current.ValorLancamento = l.ValorLancamento;
                    current.ValorJuros = l.ValorJuros;

                }

                //inicia o update do objeto do banco => lancto 
                current.IdFormaPagamento = frmPagto.IdFormaPagamento;
                current.DataPagamento = dataBaixa;
                current.ValorJuros = l.ValorJuros;

                //marque como Pago/Recebido
                current.StatusLancamento = TypeStatusLancamentoFinanceiro.Pago;

                //crie uma baixa para o lancamento
                Baixa baixa = new Baixa(valorBaixa, current.IdLancamento, dataBaixa.Value);
                current.Baixas.Add(baixa);

                //gera os extratos por referencia
                generateExtrato(current, dataBaixa.Value, valorBaixa, conta);

                //efetiva transacao no banco
                if (!ctx.LancamentoFinanceiroDao.Update(current))
                {
                    XMessageIts.Advertencia("Baixa " + current.IdLancamento + " cancelada.");
                }
                else
                {
                    //ok
                    transation = true;

                    //atualiza no grid
                    l.Update(current);

                    //garante a alteração
                    ctx.LancamentoFinanceiroDao.Dispose();

                    if (l.IdVenda != null)
                    {

                        //acessando o contexto com a alteração efetivada 
                        ctx = new BalcaoContext();

                        Venda venda = ctx.Vendas.First(v => v.IdVenda == current.IdVenda.Value);

                        //todas as parcelas foram pagas
                        if (!venda.Parcelas.ToList().Exists(p => p.DataPagamento == null))
                        {
                            venda.StatusVenda = TypeStatusVenda.Paga;
                        }
                        else
                        {
                            venda.StatusVenda = TypeStatusVenda.Parcial;
                        }

                        ctx.VendaDao.Update(venda);
                    }

                }
            }
            return transation;
        }

        public bool SaveLancamento(LancamentoFinanceiro lancamento)
        {
            using (var ctx = new BalcaoContext())
            {

                //zerando referencias
                lancamento.CentroCusto = null;
                lancamento.CliFor = null;
                lancamento.Filial = null;

                return ctx.LancamentoFinanceiroDao.Save(lancamento);

            }
        }

        public bool UpdateLancamento(LancamentoFinanceiro novo)
        {
            using (var ctx = new BalcaoContext())
            {

                var current = ctx.LancamentoFinanceiroDao.Find(novo.IdLancamento);

                new AnexoDaoManager().UpdateAnexos(ctx, current, novo);

                //atualiza o lancamento 
                current.Update(novo);

                return ctx.LancamentoFinanceiroDao.Update(current);
            }
        }

        public bool Reparcelar(LancamentoFinanceiro lan, LancamentoFinanceiro novo)
        {
            using (var ctx = new BalcaoContext())
            {

                try
                {

                    if (lan.IdVenda != null)
                    {
                        var v = ctx.VendaDao.Find(lan.IdVenda);
                        v.StatusVenda = TypeStatusVenda.Aberto;
                        ctx.VendaDao.Update(v);
                    }

                    if (lan.StatusLancamento == TypeStatusLancamentoFinanceiro.Pago)
                    {
                        var baixa = ctx.BaixaDao.Where(b => b.IdLancamento == lan.IdLancamento)
                                                .FirstOrDefault();

                        if (baixa != null)
                        {
                            //jogue a parcela paga fora
                            ctx.BaixaDao.Delete(baixa);
                        }
                    }

                    var vlrCurrent = lan.ValorLancamento - novo.ValorLancamento;
                    lan.ValorLancamento = vlrCurrent;
                    lan.StatusLancamento = TypeStatusLancamentoFinanceiro.Aberto;
                    lan.DataPagamento = null;
                    //atualiza o lançamento
                    UpdateLancamento(lan);

                    return SaveLancamento(novo);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return false;

                }

            }

        }

        public void CancelarLancamento(LancamentoFinanceiro lancamento)
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);

                var current = ctx.LancamentoFinanceiroDao.Find(lancamento.IdLancamento);
                current.StatusLancamento = TypeStatusLancamentoFinanceiro.Cancelado;

                if (!current.DataCancelamento.HasValue)
                    current.DataCancelamento = DateTime.Now;

                //me ajuda quando eu faço coisa errada
                if (lancamento.MotivoCancelamento.ToUpper().Equals("DELETE ON CASCADE"))
                {
                    string procedure = "[" + ctx.DatabaseName + "].[dbo].[P_DELETAR_LANCAMENTO]";
                    try
                    {
                        ctx.ConnectionSql.ExecuteProcedure(procedure, new SqlParameter("p_idLancamento", lancamento.IdLancamento));
                        XMessageIts.Mensagem("Lançamento " + lancamento.IdLancamento + " totalmente excluído com sucesso", "Atenção !!!");
                    }
                    catch (SqlException)
                    {
                    }

                }
                else
                {

                    if (ctx.LancamentoFinanceiroDao.Update(current))
                        lancamento.Update(current);

                    try
                    {
                        var v = ctx.VendaDao.Find(current.IdVenda);
                        v.ValidarStatus();
                        ctx.VendaDao.Update(v);
                    }
                    catch
                    {
                    }
                }
            }

        }

        public bool SalvarAnexos(LancamentoFinanceiro novo)
        {
            using (var ctx = new BalcaoContext())
            {
                var current = ctx.LancamentoFinanceiroDao.Find(novo.IdLancamento);

                new AnexoDaoManager().UpdateAnexos(ctx, current, novo);

                return ctx.LancamentoFinanceiroDao.Update(current);
            }
        }

        public bool CancelarBaixa(List<LancamentoFinanceiro> lancamentos, DateTime dataCancelamento)
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {

                    int idVenda = -1;
                    //Esse foreach eh muito sensivel
                    //Entao deve se evitar mexer no objeto da estrutura dele
                    foreach (var l in lancamentos)
                    {
                        //traz o lancamento pro contexto atual
                        var current = ctx.LancamentoFinanceiroDao.Find(l.IdLancamento);

                        //estorne os extratos.. e tire a compensacao dos ja existentes..
                        foreach (var extLancamento in l.Extratos)
                        {
                            //cancelando a compensacao 
                            var extratoLancamento = ctx.ExtratoBancarioDao.Find(extLancamento.IdExtrato);
                            extratoLancamento.Compensado = false;
                            extratoLancamento.DataCompensacao = null;
                            extratoLancamento.DataEstorno = DateTime.Now;
                            ctx.ExtratoBancarioDao.Update(extratoLancamento);
                            //fim cancelamento..

                            //estornando..
                            estornarExtrato(extLancamento, dataCancelamento, ctx);
                        }

                        //excluir as baixas.. ja que foi cancelada :?
                        foreach (var baixaLancamento in l.Baixas)
                        {
                            var baixaFind = ctx.BaixaDao.Find(baixaLancamento.IdBaixa);
                            ctx.BaixaDao.Delete(baixaFind);
                        }

                        //alterando as propriedades dos lancamentos que tiveram baixa cancelada.
                        current.DataPagamento = null;
                        current.StatusLancamento = TypeStatusLancamentoFinanceiro.Aberto;

                        //atualiza no banco
                        ctx.LancamentoFinanceiroDao.Update(current);

                        //atualiza o objeto do grid
                        l.Update(current);

                        //nao preciso ficar passando aqui atoa
                        if (l.IdVenda != null && idVenda != l.IdVenda.Value)
                        {
                            try
                            {
                                var v = ctx.VendaDao.Find(l.IdVenda);
                                v.StatusVenda = TypeStatusVenda.Aberto;
                                ctx.VendaDao.Update(v);
                            }
                            catch
                            {
                            }
                            try
                            {
                                var r = ctx.MovimentoCaixaDao.Where(m => m.IdVenda == l.IdVenda).First();
                                ctx.MovimentoCaixaDao.Delete(r);
                                idVenda = l.IdVenda.Value;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Movimento nao encontrado =>" + ex.Message);
                            }
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    XMessageIts.ExceptionMessageDetails(ex, "Ocorreu uma falha ao cancelar a baixa dos lançamentos selecionados, \n por favor contate o administrador.", "Falha crítica!");
                    return false;
                }
            }

        }

        /// <summary>
        /// Recupera o lancamento usando modo EAGER
        /// </summary>
        /// <param name="lan"></param>
        /// <returns></returns>
        public static LancamentoFinanceiro Find(LancamentoFinanceiro lan)
        {
            try
            {

                using (var ctx = new BalcaoContext())
                {
                    ctx.LazyLoading(false);
                    //carregando cliente/anexos do lancamento
                    //carregando o lancamento sempre que visualizar
                    //sai mesmo custoso que carregando todos os anexos diretamente no grid
                    //considerando que havera milhoes de lancamentos
                    //evita uma sobrecarga porem eh mais trabalhoso
                    //mas compensa significativamente em performance
                    LancamentoFinanceiro current = ctx.LancamentosFinanceiros
                                            .Where(l => l.IdLancamento == lan.IdLancamento)
                                            .Include(l => l.CliFor)
                                            .Include(l => l.FormaPagamento)
                                            .Include(l => l.CentroCusto)
                                            .Include(l => l.Filial)
                                            .Include(l => l.Baixas).First();

                    return current;

                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        /// <summary>
        /// Recupera o lancamento usando modo EAGER
        /// </summary>
        /// <param name="lan"></param>
        /// <returns></returns>
        public static LancamentoFinanceiro FindCpl(LancamentoFinanceiro lan)
        {
            try
            {

                using (var ctx = new BalcaoContext())
                {
                    ctx.LazyLoading(false);

                    //carregando cliente/anexos do lancamento
                    //carregando o lancamento sempre que visualizar
                    //sai mesmo custoso que carregando todos os anexos diretamente no grid
                    //considerando que havera milhoes de lancamentos
                    //evita uma sobrecarga porem eh mais trabalhoso
                    //mas compensa significativamente em performance
                    LancamentoFinanceiro current = ctx.LancamentosFinanceiros
                        .Where(l => l.IdLancamento == lan.IdLancamento)
                        .Include(l => l.CliFor)
                        .Include(l => l.FormaPagamento)
                        .Include(l => l.CentroCusto)
                        .Include(l => l.Baixas)
                        .Include(l => l.Extratos)
                        .Include(l => l.Anexos)
                        .Include(l => l.Filial).First();

                    return current;

                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        //chamado internamento pela Baixa 
        private void generateExtrato(LancamentoFinanceiro current, DateTime dataBaixa, decimal valorBaixa, ContaBancaria conta)
        {

            //criando os extratos...
            if (current.TipoLancamento == TypeLancamentoFinanceiro.Pagar) //se for a pagar, extrato eh Saque
            {
                string historicoExtrato = current.Observacao;

                //"Pagamento Lançto. Nº: " + current.IdLancamento + " DE " + current.CliFor.RazaoSocial;

                //if (current.StatusLancamento == TypeStatusLancamentoFinanceiro.Parcial)
                //    historicoExtrato = "Pagamento Parcial Lançto. Nº: " + current.IdLancamento
                //        + " DE " + current.CliFor.RazaoSocial;
                //else
                //    historicoExtrato = "Pagamento Lançto. Nº: "
                //        + current.IdLancamento + " DE " + current.CliFor.RazaoSocial; 

                //crie um extrato para cada lancamento
                ExtratoBancario extrato =
                    new ExtratoBancario(TypeExtratoBancario.SaqueNaBaixa, dataBaixa, valorBaixa,
                    conta.IdContaBancaria, current.IdLancamento, historicoExtrato, current.IdCentroCusto, current.IdFilial);

                current.Extratos.Add(extrato);
            }
            else //senao Deposito
            {
                string historicoExtrato = current.Observacao;

                //"Recebimento Lançto. Nº: " + current.IdLancamento + " DE " + current.CliFor.RazaoSocial;

                //if (current.StatusLancamento == TypeStatusLancamentoFinanceiro.Parcial)
                //    historicoExtrato = "Recebimento Parcial Lançto. Nº: " + current.IdLancamento + " DE " + current.CliFor.RazaoSocial;
                //else
                //    historicoExtrato = "Recebimento Lançto. Nº: " + current.IdLancamento + " DE " + current.CliFor.RazaoSocial;

                ExtratoBancario extrato = new ExtratoBancario(TypeExtratoBancario.DepositoNaBaixa, dataBaixa, valorBaixa,
                    conta.IdContaBancaria, current.IdLancamento, historicoExtrato, current.IdCentroCusto, current.IdFilial);
                current.Extratos.Add(extrato);
            }
        }

        //chamado internamento pela Baixa 
        private void estornarExtrato(ExtratoBancario extratoEstorno, DateTime dataEstorno, BalcaoContext context)
        {
            //criando os extratos...
            if (extratoEstorno.ValorExtrato < 0) //se for a pagar, o estorno será um deposito
            {
                string historicoExtrato = "Estorno do extrato ID: " + extratoEstorno.IdExtrato;

                //crie um extrato estornando o recebido via parametro
                ExtratoBancario extrato =
                    new ExtratoBancario(TypeExtratoBancario.Estorno, extratoEstorno.DataExtrato, (extratoEstorno.ValorExtrato * -1),
                    extratoEstorno.IdContaBancaria, extratoEstorno.IdLancamento.Value, historicoExtrato, extratoEstorno.IdCentroCusto, extratoEstorno.IdFilial.Value, dataEstorno);

                context.ExtratoBancarioDao.Save(extrato);
            }
            else //senao é um deposito, então "saque" esse valor.
            {
                string historicoExtrato = "Estorno do extrato ID: " + extratoEstorno.IdExtrato;

                //crie um extrato estornando o recebido via parametro
                ExtratoBancario extrato =
                    new ExtratoBancario(TypeExtratoBancario.Estorno, extratoEstorno.DataExtrato, (extratoEstorno.ValorExtrato * -1),
                    extratoEstorno.IdContaBancaria, extratoEstorno.IdLancamento.Value, historicoExtrato, extratoEstorno.IdCentroCusto, extratoEstorno.IdFilial.Value, dataEstorno);

                context.ExtratoBancarioDao.Save(extrato);
            }
        }

        public async Task<List<LancamentoFinanceiro>> FindLancamentos(TypeLancamentoFinanceiro tipo,
            TypeStatusLancamentoFinanceiro status)
        {

            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);

                //Observação: enum todos são somente uma referencia para montar o select

                //todos os tipos e todos os status
                if (tipo == TypeLancamentoFinanceiro.Todos && status == TypeStatusLancamentoFinanceiro.Todos)
                {

                    //carregando lancamentos usando eager
                    var lancamentos = await ctx.LancamentosFinanceiros
                                                .Include(l => l.CliFor)
                                                .Include(l => l.Venda)
                                                .Include(l => l.FormaPagamento)
                                                .Include(l => l.Venda.FormaPagamentoVenda)
                                                .Include(l => l.CentroCusto)
                                                .Include(l => l.Filial)
                                                .Include(l => l.Extratos)
                                                .Include(l => l.Baixas)
                                                .ToListAsync();
                    return lancamentos;
                }


                //NOVO
                else if (tipo != TypeLancamentoFinanceiro.Todos && status == TypeStatusLancamentoFinanceiro.Pendente)
                {
                    var lancamentos = await ctx.LancamentosFinanceiros
                                    .Include(l => l.CliFor)
                                    .Include(l => l.Venda)
                                    .Include(l => l.FormaPagamento)
                                    .Include(l => l.Venda.FormaPagamentoVenda)
                                    .Include(l => l.CentroCusto)
                                    .Include(l => l.Filial)
                                    .Include(l => l.Extratos)
                                    .Where(l => l.DataPagamento == null
                                    && l.TipoLancamento == tipo
                                    && l.StatusLancamento != TypeStatusLancamentoFinanceiro.Cancelado)
                                    .ToListAsync();
                    return lancamentos;

                }
                //NOVO
                else if (tipo == TypeLancamentoFinanceiro.Todos && status == TypeStatusLancamentoFinanceiro.Pendente)
                {
                    var lancamentos = await ctx.LancamentosFinanceiros
                                    .Include(l => l.CliFor)
                                    .Include(l => l.Venda)
                                    .Include(l => l.FormaPagamento)
                                    .Include(l => l.Venda.FormaPagamentoVenda)
                                    .Include(l => l.CentroCusto)
                                    .Include(l => l.Filial)
                                    .Include(l => l.Extratos)
                                    .Where(l => l.DataPagamento == null
                                    && l.StatusLancamento != TypeStatusLancamentoFinanceiro.Cancelado)
                                    .ToListAsync();
                    return lancamentos;
                }

                //filtrando pelo tipo e status
                else if (tipo != TypeLancamentoFinanceiro.Todos && status != TypeStatusLancamentoFinanceiro.Todos)
                {
                    var lancamentos = await ctx.LancamentosFinanceiros
                                            .Include(l => l.CliFor)
                                            .Include(l => l.Venda)
                                            .Include(l => l.FormaPagamento)
                                            .Include(l => l.Venda.FormaPagamentoVenda)
                                            .Include(l => l.CentroCusto)
                                            .Include(l => l.Filial)
                                            .Include(l => l.Extratos)
                                            .Where(l => l.StatusLancamento == status
                                                        && l.TipoLancamento == tipo)
                                            .ToListAsync();
                    return lancamentos;

                }

                //todos lançamentos filtrado pelo status
                else if (tipo == TypeLancamentoFinanceiro.Todos && status != TypeStatusLancamentoFinanceiro.Todos)
                {
                    var lancamentos = await ctx.LancamentosFinanceiros
                                                             .Include(l => l.CliFor)
                                                             .Include(l => l.Venda)
                                                             .Include(l => l.FormaPagamento)
                                                             .Include(l => l.Venda.FormaPagamentoVenda)
                                                             .Include(l => l.CentroCusto)
                                                             .Include(l => l.Filial)
                                                             .Include(l => l.Extratos)
                                                             .Where(l => l.StatusLancamento == status)
                                                             .ToListAsync();
                    return lancamentos;

                }

                //todos lançamentos filtrado do tipo
                else
                {
                    var lancamentos = await ctx.LancamentosFinanceiros
                                            .Include(l => l.CliFor)
                                            .Include(l => l.Venda)
                                            .Include(l => l.FormaPagamento)
                                            .Include(l => l.Venda.FormaPagamentoVenda)
                                            .Include(l => l.CentroCusto)
                                            .Include(l => l.Filial)
                                            .Include(l => l.Extratos)
                                            .Where(l => l.TipoLancamento == tipo)
                                            .ToListAsync();
                    return lancamentos;

                }
            }
        }

        public async Task<List<LancamentoFinanceiro>> FindLancamentosLikeCliente(string search, TypeLancamentoFinanceiro tipo,
            TypeStatusLancamentoFinanceiro status)
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);

                //Observação: enum todos eh somente uma referencia para montar o select
                //todos os tipos e todos os status
                if (tipo == TypeLancamentoFinanceiro.Todos && status == TypeStatusLancamentoFinanceiro.Todos)
                {
                    return await ctx.LancamentosFinanceiros
                                           .Include(l => l.CliFor)
                                           .Include(l => l.Venda)
                                           .Include(l => l.FormaPagamento)
                                           .Include(l => l.Venda.FormaPagamentoVenda)
                                           .Include(l => l.CentroCusto)
                                           .Include(l => l.Filial)
                                           .Where(l => l.CliFor.RazaoSocial.Contains(search))
                                           .ToListAsync();
                }

                //NOVO
                else if (tipo != TypeLancamentoFinanceiro.Todos && status == TypeStatusLancamentoFinanceiro.Pendente)
                {
                    var lancamentos = await ctx.LancamentosFinanceiros
                                                             .Include(l => l.CliFor)
                                                             .Include(l => l.Venda)
                                                             .Include(l => l.FormaPagamento)
                                                             .Include(l => l.Venda.FormaPagamentoVenda)
                                                             .Include(l => l.CentroCusto)
                                                             .Include(l => l.Filial)
                                                             .Where(l => l.CliFor.RazaoSocial.Contains(search)
                                                                    && l.DataPagamento == null
                                                                    && l.StatusLancamento != TypeStatusLancamentoFinanceiro.Cancelado
                                                                    && l.TipoLancamento == tipo)
                                                             .ToListAsync();
                    return lancamentos;

                }
                //NOVO
                else if (tipo == TypeLancamentoFinanceiro.Todos && status == TypeStatusLancamentoFinanceiro.Pendente)
                {
                    var lancamentos = await ctx.LancamentosFinanceiros
                                                             .Include(l => l.CliFor)
                                                             .Include(l => l.Venda)
                                                             .Include(l => l.FormaPagamento)
                                                             .Include(l => l.Venda.FormaPagamentoVenda)
                                                             .Include(l => l.CentroCusto)
                                                             .Include(l => l.Filial)
                                                             .Where(l => l.CliFor.RazaoSocial.Contains(search)
                                                                    && l.DataPagamento == null && l.StatusLancamento != TypeStatusLancamentoFinanceiro.Cancelado)
                                                             .ToListAsync();
                    return lancamentos;

                }

                //filtrando pelo tipo e status
                else if (tipo != TypeLancamentoFinanceiro.Todos && status != TypeStatusLancamentoFinanceiro.Todos)
                {
                    var lancamentos = await ctx.LancamentosFinanceiros
                                            .Include(l => l.CliFor)
                                            .Include(l => l.Venda)
                                            .Include(l => l.FormaPagamento)
                                            .Include(l => l.Venda.FormaPagamentoVenda)
                                            .Include(l => l.CentroCusto)
                                            .Include(l => l.Filial)
                                            .Where(l => l.StatusLancamento == status
                                                        && l.TipoLancamento == tipo
                                                        && l.CliFor.RazaoSocial.Contains(search))
                                            .ToListAsync();
                    return lancamentos;

                }


                //filtrando pelo tipo e status
                else if (tipo != TypeLancamentoFinanceiro.Todos && status != TypeStatusLancamentoFinanceiro.Todos)
                {
                    var lancamentos = await ctx.LancamentosFinanceiros
                                            .Include(l => l.CliFor)
                                            .Include(l => l.Venda)
                                            .Include(l => l.FormaPagamento)
                                            .Include(l => l.Venda.FormaPagamentoVenda)
                                            .Include(l => l.CentroCusto)
                                            .Include(l => l.Filial)
                                            .Where(l => l.StatusLancamento == status
                                                        && l.TipoLancamento == tipo
                                                        && l.CliFor.RazaoSocial.Contains(search))
                                            .ToListAsync();
                    return lancamentos;

                }


                //todos lançamentos filtrado pelo status
                else if (tipo == TypeLancamentoFinanceiro.Todos && status != TypeStatusLancamentoFinanceiro.Todos)
                {
                    var lancamentos = await ctx.LancamentosFinanceiros
                                                             .Include(l => l.CliFor)
                                                             .Include(l => l.Venda)
                                                             .Include(l => l.FormaPagamento)
                                                             .Include(l => l.Venda.FormaPagamentoVenda)
                                                             .Include(l => l.CentroCusto)
                                                             .Include(l => l.Filial)
                                                             .Where(l => l.StatusLancamento == status
                                                                     && l.CliFor.RazaoSocial.Contains(search))
                                                             .ToListAsync();
                    return lancamentos;

                }
                //todos lançamentos filtrado do tipo
                else
                {
                    var lancamentos = await ctx.LancamentosFinanceiros
                                            .Include(l => l.CliFor)
                                            .Include(l => l.Venda)
                                            .Include(l => l.FormaPagamento)
                                            .Include(l => l.Venda.FormaPagamentoVenda)
                                            .Include(l => l.CentroCusto)
                                            .Include(l => l.Filial)
                                            .Where(l => l.TipoLancamento == tipo
                                                    && l.CliFor.RazaoSocial.Contains(search))
                                            .ToListAsync();
                    return lancamentos;

                }


            }
        }

        /// <summary>
        /// Obtém os anos das datas dos Lancamentos
        /// </summary>
        /// <returns></returns>
        public string[] GetPeriodoLancamentos()
        {
            using (var ctx = new BalcaoContext())
            {
                DataTable dt = ctx.ConnectionSql.ExecuteQueryDataTable("SELECT DISTINCT  DATEPART(YEAR, DataLancamento) AS 'DataLancamento' FROM LancamentoFinanceiro");
                //array dos periodos
                object[] values = DataGridViewUtil.GetColumnValues(dt);

                //converte a array de objeto em string
                string[] periodos = Array.ConvertAll(values, x => x.ToString());

                return periodos;
            }

        }

        /// <summary>
        /// Verifica o uso da conta de custo
        /// </summary>
        /// <param name="centroCusto"></param>
        /// <returns></returns>
        public bool CheckUsoCentroCusto(CentroCusto centroCusto)
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    var query = ctx.LancamentoFinanceiroDao.First(c => c.IdCentroCusto == centroCusto.IdCentroCusto);
                    return query != null;

                }
                catch (Exception ex)
                {
                    LoggerUtilIts.ShowExceptionMessage(ex);
                    return false;
                }


            }
        }

        public List<LancamentoFinanceiro> GetTotalLancamentoFinanceiros(TypeLancamentoFinanceiro tipo)
        {

            using (var ctx = new BalcaoContext())
            {
                var lancamentos = ctx.LancamentosFinanceiros
                    .Where(l => l.TipoLancamento == tipo);
                return lancamentos.ToList();
            }
        }

        public decimal GetTotalLancamentos(DateTime dtInicial, DateTime dtFinal, TypeLancamentoFinanceiro tipo)
        {
            using (var ctx = new BalcaoContext())
            {
                var lancamentos = ctx.LancamentosFinanceiros.Where(ch =>
                    ch.DataLancamento >= dtInicial.Date &&
                    ch.DataLancamento <= dtFinal.Date &&
                    ch.TipoLancamento == tipo);

                return lancamentos.ToList().Sum(l => l.ValorLancamento);
            }

        }

        public async Task<List<LancamentoFinanceiro>> FiltrarLancamentos(string search, DateTime dtInicio, DateTime dtFim)
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);


                if (string.IsNullOrEmpty(search))
                    return await ctx.LancamentosFinanceiros
                        .Include(l => l.CliFor)
                        .Include(l => l.Venda)
                        .Include(l => l.FormaPagamento)
                        .Include(l => l.Venda.FormaPagamentoVenda)
                        .Include(l => l.CentroCusto)
                        .Include(l => l.Filial)
                        .Where(l => l.DataLancamento >= dtInicio.Date && l.DataLancamento <= dtFim.Date)
                        .ToListAsync();

                return await ctx.LancamentosFinanceiros
                        .Include(l => l.CliFor)
                        .Include(l => l.Venda)
                        .Include(l => l.FormaPagamento)
                        .Include(l => l.Venda.FormaPagamentoVenda)
                        .Include(l => l.CentroCusto)
                        .Include(l => l.Filial)
                        .Where(l => l.CliFor.RazaoSocial.Contains(search)
                                    && l.DataLancamento >= dtInicio
                                    && l.DataLancamento <= dtFim)
                        .ToListAsync();
            }

        }
    }
}
/* using System;
using System.Linq;
using System.Data;

//https://msdn.microsoft.com/pt-br/library/JJ128159.aspx

/*
/// <summary>
/// Verifica o uso da conta de custo
/// </summary>
/// <param name="centroCusto"></param>
/// <returns></returns>
public bool CheckUsoContaCusto(ContaCusto centroCusto)
{
    var ctx = FluxoCaixaContext.Instance;

    var query = ctx.Lancamentos.FirstOrDefault(c => c.IdContaCusto == centroCusto.IdContaCusto);

    return query != null;
}



/// <summary>
/// Obtém os anos das datas dos Lancamentos
/// </summary>
/// <returns></returns>
public string[] GetPeriodoLancamentos()
{

    ConnectionFactorySQL con = new ConnectionFactorySQL();

    var p = from l in FluxoCaixaContext.Instance.Lancamentos
            select l.DataLancamento.Year;


    DataTable dt = con.ExecuteQuery("select distinct DATEPART(YEAR,DataLancamento) FROM tbLancamento");
    int rowCount = dt.Rows.Count;
    int columnCount = dt.Columns.Count;
    //vetor de bindingSource com
    string[] periodos = new string[rowCount];
    for (int i = 0; i < dt.Rows.Count; i++)
    {
        for (int j = 0; j < dt.Columns.Count; j++)
        {
            object o = dt.Rows[i][j];
            if (o != null && !String.IsNullOrWhiteSpace(o.ToString()))
            {
                string x = o.ToString().Trim();
                periodos[i] = x;
            }
        }
    }
    return periodos;
}
*/

