using System;
using System.Collections.Generic;
using System.Linq;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Util;

namespace ITE.Forms.OldVersion
{
    /// <summary>
    /// REJEITADO
    /// </summary>
    public class ParcelaDaoManager
    {
        public ParcelaDaoManager()
        {
        }

        public List<LancamentoFinanceiro> GetParcelasBy(CliFor cliFor)
        {
            var ctx = new BalcaoContext();
            //carrega todas as parcelas do cliente
            var parcelas = ctx.LancamentosFinanceiros.Where(p => p.IdCliFor == cliFor.IdCliFor).ToList();
            return parcelas;
        }

        /// <summary>
        /// Filtras as parcelas por status
        /// </summary>
        /// <param name="parcelas"></param>Lista de parcelas
        /// <param name="status"></param>Status das parcelas
        /// <returns></returns>
        public List<LancamentoFinanceiro> FindParcelasBy(TypeStatusLancamentoFinanceiro status)
        {
            var ctx = new BalcaoContext();

            //filtrando as parcelas
            IEnumerable<LancamentoFinanceiro> parcelasFilter = filtrarParcelas(ctx.LancamentosFinanceiros, status);

            //recebeu o filtro
            return parcelasFilter != null ? parcelasFilter.ToList() : null;
        }

        /// <summary>
        /// Filtras as parcelas pelo cliente e status
        /// </summary>
        public List<LancamentoFinanceiro> FindParcelasBy(CliFor cliFor, TypeStatusLancamentoFinanceiro status)
        {
            var ctx = new BalcaoContext();

            //filtrando parcelas por cliente
            var parcelas = ctx.LancamentosFinanceiros.Where(p => p.IdCliFor == cliFor.IdCliFor);

            //filtrando as parcelas
            IEnumerable<LancamentoFinanceiro> parcelasFilter = filtrarParcelas(parcelas, status);

            //recebeu o filtro
            return parcelasFilter != null ? parcelasFilter.ToList() : null;
        }

        //chamado internamente
        private IEnumerable<LancamentoFinanceiro> filtrarParcelas(IEnumerable<LancamentoFinanceiro> parcelas, TypeStatusLancamentoFinanceiro status)
        {
            //em aberto
            //quitadas
            if (status == TypeStatusLancamentoFinanceiro.Aberto || status == TypeStatusLancamentoFinanceiro.Pago)
            {
                return parcelas.Where(p => p.StatusLancamento == status);
            }
            //vencidas
            else if (status == TypeStatusLancamentoFinanceiro.Vencido)
            {
                return parcelas.Where(p => p.DataVencimento <= DateTime.Now || p.StatusLancamento == TypeStatusLancamentoFinanceiro.Vencido);
            }
            //todos os status
            else
            {
                return parcelas;
            }
        }

        /// <summary>
        /// Retorna o numero de parcelas quitadas
        /// </summary>
        /// <param name="parcelas"></param>
        /// <returns></returns>

        public int QuitarParcelas(List<LancamentoFinanceiro> parcelas)
        {
            var ctx = new BalcaoContext();

            var count = 0;
            //quitando parcelas
            foreach (var parcela in parcelas)
            {
                //atualize a data
                //efetiva a transação no banco
                if (parcela != null)
                {
                    //recuperar a parcela original do banco
                    var parcelaBanco = ctx.LancamentoFinanceiroDao.Find(parcela.IdLancamento);

                    parcelaBanco.DataPagamento = parcela.DataPagamento.Value;
                    
                    //atualiza a parcela
                    parcelaBanco.StatusLancamento = TypeStatusLancamentoFinanceiro.Pago;

                    //atualiza a parcela do grid
                    parcela.StatusLancamento = parcelaBanco.StatusLancamento;

                    //atualize a parcela do banco
                    ctx.LancamentoFinanceiroDao.Update(parcelaBanco);
                }

                //registra ocorrencia de parcela quitada
                count++;
            }

            //atualiza a venda 
            var venda = ctx.VendaDao.Find(parcelas.FirstOrDefault().IdVenda);
            
            //parcelas reais da venda
            var parcelasVenda = venda.Parcelas;
            try
            {
                var pNext = parcelas.Where(p => p.StatusLancamento == TypeStatusLancamentoFinanceiro.Aberto)
                                            .OrderBy(d => d.DataVencimento).First();

                venda.DataVencimento = pNext.DataVencimento;
                venda.StatusVenda = TypeStatusVenda.Aberto;
            }
            catch
            {
                //se caiu aqui nao encontrou parcela
                venda.StatusVenda = TypeStatusVenda.Paga;
            }
            //efetiva atualizacao da venda
            ctx.VendaDao.Update(venda);

            return count;
        }

        public void LancaRestanteDebito(decimal valorRestante, int idCliFor)
        {
            var ctx = new BalcaoContext();
            var historico = String.Format("Restante débito: {0}", valorRestante);

            //cria a nova parcela
            ctx.LancamentoFinanceiroDao.Save(new LancamentoFinanceiro(null,
                valorRestante,
                DataUtil.GetNextDate(DateTime.Now),
                0,
                TypeStatusLancamentoFinanceiro.Aberto,
                historico, idCliFor));
        }

        /*private void quitarParcelaTotalParcial(Parcela parcela, DateTime dtPagamento)
        {
            var ctx = new BalcaoContext();

            if (parcela != null)
            {
                //recuperar a parcela original do banco
                var parcelaBanco = ctx.ParcelaDao.Find(parcela.IdParcela);

                //Parcela totalmente quitada
                if (parcela.ValorRecebido == parcela.ValorOriginal)
                {
                    parcelaBanco.ValorRecebido = parcela.ValorRecebido;
                    parcelaBanco.DataPagamento = dtPagamento;
                    parcelaBanco.Status = StatusParcela.Quitada;
                }
                //quitar parcela parcialmente
                else
                {
                    //parcialmente quitada
                    parcelaBanco.Status = StatusParcela.Quitada;
                    parcelaBanco.ValorRecebido = parcela.ValorRecebido;
                    parcelaBanco.DataPagamento = dtPagamento;
                    var vlrRestante = parcela.ValorOriginal - parcela.ValorRecebido.Value;

                    var historico = String.Format("Pagamento restante da parcela: {0} \nVenda: {1}",
                        parcelaBanco.IdParcela, parcelaBanco.IdVendaParcela);

                    //cria a nova parcela
                    ctx.ParcelaDao.Save(new Parcela(parcelaBanco.IdVendaParcela,
                        vlrRestante,
                        DataUtil.GetNextDate(parcela.DataPagamento.Value),
                        0,
                        StatusParcela.Aberto,
                        historico,
                        parcelaBanco.Venda.IdCliForVenda));
                }
                //atualize a parcela do banco
                ctx.ParcelaDao.Update(parcelaBanco);
            }
        }*/



    }
}
