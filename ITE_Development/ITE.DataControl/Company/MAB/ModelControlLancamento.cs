using ITE.Entidades.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid.Views.Grid;
using ITSolution.Framework.Util;
using ITE.Entidades.Enumeradores;
using System.Data;
using ITE.Entidades.Repositorio;
using ITE.Entidades.POCO.Financeiro;
using ITSolution.Framework.Enumeradores;

namespace ITE.DataControl.Company.MAB
{
    public class ModelControlLancamento : LancamentoFinanceiro
    {
        public const string DATA = "Data";
        public const string HISTORICO = "Histórico";
        public const string OBSERVACAO = "Observação";
        public const string CREDITO = "Crédito";
        public const string DEBITO = "Débito";
        public const string SALDO = "Saldo";

        public TypeMoeda Moeda { get; set; }
        private GridView gridView1;

        public HashSet<LancamentoFinanceiro> Result { get; private set; }
        public HashSet<LancamentoFinanceiro> Errors { get; private set; }

        public ModelControlLancamento()
        {

        }

        public ModelControlLancamento(GridView gridView1)
        {
            this.gridView1 = gridView1;
            this.Result = new HashSet<LancamentoFinanceiro>();
            this.Errors = new HashSet<LancamentoFinanceiro>();

        }

        public bool CreateLancamentos()
        {
            var x = gridView1.RowCount;
            var ctx = new BalcaoContext();
            var dao = ctx.LancamentoFinanceiroDao;


            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                //data lançamento e pagamento
                var data = row[ModelControlLancamento.DATA].ToString();
                //nome do cliente
                var nomeCliente = row[ModelControlLancamento.HISTORICO].ToString().Trim();
                //observação - filtra pelo sql para obter algumas data
                var obs = row[ModelControlLancamento.OBSERVACAO].ToString();
                //valor do lancamento
                var credito = row[ModelControlLancamento.CREDITO].ToString();
                //valor do lancamento
                var debito = row[ModelControlLancamento.DEBITO].ToString();


                //var saldo = row[ModelLancamento.SALDO];

                LancamentoFinanceiro l = new LancamentoFinanceiro();

                l.RecCreatedBy = 2;
                //Filial
                l.IdFilial = 1;
                //Centro de custo mapear manualmente apos a inserção infelizmente
                l.IdCentroCusto = 1;
                l.StatusLancamento = TypeStatusLancamentoFinanceiro.Aberto;

                if (!string.IsNullOrEmpty(obs))
                    l.Observacao = obs;

                Console.WriteLine(nomeCliente);

                if (!string.IsNullOrEmpty(nomeCliente))
                {
                    try
                    {
                        string str = nomeCliente;
                        var split = nomeCliente.Split(' ');
                        if (split.Length > 1)
                            if (split.Length >= 2)
                                str = split[0] + " " + split[1];
                            else
                                str = split[0];

                        //acha o cliente usando LIKE
                        var cliFor = ctx.CliForDao
                        .Where(c => c.RazaoSocial.Contains(str)).First();
                        //pass o cliente pro lancamento
                        l.IdCliFor = cliFor.IdCliFor;


                        if (cliFor.RazaoSocial.Contains("BC STONES")
                            || cliFor.RazaoSocial.Contains("BARCAMP")
                            || cliFor.RazaoSocial.Contains("LIBERIO")
                            || cliFor.RazaoSocial.Contains("FABRICIO")
                            || cliFor.RazaoSocial.Contains("ALYSSON")
                            || cliFor.RazaoSocial.Contains("SERGIO")
                            || cliFor.RazaoSocial.Contains("INDUSTRIA")
                            || cliFor.RazaoSocial.Contains("RICARDO"))
                            l.IdCentroCusto = 1;

                        else if (cliFor.RazaoSocial.Contains("MINERACAO ALTO DAS PERDIZES LTDA - ME"))
                            l.IdCentroCusto = 2;

                        else if (cliFor.RazaoSocial.Contains("POSTO"))
                            l.IdCentroCusto = 4;

                        else if (cliFor.RazaoSocial.Contains("SUPER"))
                            l.IdCentroCusto = 5;

                        else if (obs.Contains("PAGAMENTO FUNCIONARIOS"))
                            l.IdCentroCusto = 6;


                        else if (cliFor.RazaoSocial.Contains("VIVO")
                            || cliFor.RazaoSocial.Contains("CTBC")
                            || cliFor.RazaoSocial.Contains("ALGAR")
                            || cliFor.RazaoSocial.Contains("TERRA")
                            || cliFor.RazaoSocial.Contains("TELEFONE")
                            || cliFor.RazaoSocial.Contains("TELEFONICA")
                            || cliFor.RazaoSocial.Contains("TELEFONIA"))
                            l.IdCentroCusto = 5;

                        else if (cliFor.RazaoSocial.Contains("CARINHA TRANSPORTES"))
                            l.IdCentroCusto = 9;

                        else
                            l.IdCentroCusto = 3;

                    }
                    catch
                    {
                        var cliFor = new CliFor();
                        cliFor.CpfCnpj = "00000000000000";
                        cliFor.Classificacao = TypeClassificaoCliente.Fornecedor;
                        cliFor.RazaoSocial = nomeCliente;

                        ctx.CliForDao.Save(cliFor);

                        l.IdCliFor = cliFor.IdCliFor;
                    }
                }



                if (!string.IsNullOrWhiteSpace(data))
                {
                    l.DataLancamento = DataUtil.ToDate(data.ToString());
                    l.DataVencimento = DataUtil.ToDate(data.ToString());
                }

                //observação nao ta vazio e nao tem texto nao tem texto 
                if (!string.IsNullOrEmpty(obs) && !obs.IsContainsLetters())
                {
                    //o texto da observação as vezes eh a data de pagamento
                    l.DataPagamento = DataUtil.ToDate(obs);
                }

                //se o credito eh vazio entao eh debito
                if (string.IsNullOrWhiteSpace(credito) || credito == "0")
                {
                    l.ValorLancamento = ParseUtil.ToDecimal(debito);
                    l.TipoLancamento = TypeLancamentoFinanceiro.Pagar;
                }
                //se nao eh credito
                else
                {
                    l.ValorLancamento = ParseUtil.ToDecimal(credito);
                    l.TipoLancamento = TypeLancamentoFinanceiro.Receber;
                }

                try
                {


                    //l.IdCentroCusto = ctx.CentroCustoDao.First().IdCentroCusto;
                    //efetiva o lancamento no banco
                    dao.Save(l);
                    this.Result.Add(l);
                }
                catch (Exception ex)
                {
                    this.Errors.Add(l);
                    LoggerUtilIts.ShowExceptionLogs(ex);
                }


            }
            return true;
        }
    }
}
