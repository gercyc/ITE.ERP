using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using ITE.Entidades.POCO.Sales;

namespace ITE.Entidades.DaoManager.FinanceiroDaoManager
{
    public class ExtratoDaoManager
    {

        public bool GenerateExtrato(Venda current, ContaBancaria conta)
        {
            DateTime dataBaixa = current.DataVenda;
            decimal valorBaixa = current.TotalVenda;

            using (var ctx = new BalcaoContext())
            {
                string historicoExtrato = "RECEBIMENTO LANÇTO.Nº " + current.IdVenda;
                var parcelaAVista = current.Parcelas.First();


                ExtratoBancario extrato = new ExtratoBancario(TypeExtratoBancario.DepositoNaBaixa, dataBaixa, valorBaixa,
                    conta.IdContaBancaria, parcelaAVista.IdLancamento, historicoExtrato, current.IdCentroCusto, current.IdFilial);

                var tra = ctx.ExtratoBancarioDao.Save(extrato);

                return tra;
            }
        }

        /// <summary>
        /// Verifica se o lancamento relacionado ao extrato foi pago (Parcial ou Total).
        /// Se foi pago retorna true senão false.
        /// </summary>
        /// <param name="extrato"></param>
        /// <returns>Lancamento foi pago?</returns>
        public bool VerificaLancamentoPago(ExtratoBancario extrato)
        {
            using (var ctx = new BalcaoContext())
            {
                //verificar somente se o extrato for originario de um lancamento.
                if (extrato.IdLancamento != null)
                {
                    var lancamentoExtrato = ctx.LancamentoFinanceiroDao.Find(extrato.IdLancamento);

                    return (lancamentoExtrato.StatusLancamento == TypeStatusLancamentoFinanceiro.Pago);
                }
                return false;
            }
        }

        public bool ExcluirExtratos(List<ExtratoBancario> extratos)
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    foreach (var extrato in extratos)
                    {
                        var current = ctx.ExtratoBancarioDao.Find(extrato.IdExtrato);
                        ctx.ExtratoBancarioDao.Delete(current);
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    LoggerUtilIts.ShowExceptionMessage(ex);
                    return false;
                }
            }
        }

        public bool CancelarCompensacao(List<ExtratoBancario> extratos)
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    foreach (var extrato in extratos.Where(e => e.Compensado == true))
                    {
                        var current = ctx.ExtratoBancarioDao.Find(extrato.IdExtrato);

                        current.Compensado = false;
                        current.DataCompensacao = null;

                        ctx.ExtratoBancarioDao.Update(current);
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    LoggerUtilIts.ShowExceptionMessage(ex);
                    return false;
                }
            }
        }
    }
}
