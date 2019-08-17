using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ITE.Entidades.DaoManager.FinanceiroDaoManager;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.Repositorio;
using ITE.Financeiro.Forms.View;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Reports.DaoManager;
using ITSolution.Reports.Util;
using ITSolution.Framework.Util;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors;
using System.Linq;

namespace ITE.Financeiro.Forms.ListView
{
    public partial class XFrmViewExtratoBancario : XtraForm
    {
        public XFrmViewExtratoBancario()
        {
            InitializeComponent();

        }
        private async Task carregarExtratos()
        {
            var ctx = new BalcaoContext();
            var lista = await ctx.ExtratoBancarioDao.FindAllAsync();
            var contas = await ctx.ContaBancariaDao.FindAllAsync();
            dtInicialEdit.DateTime = DataUtil.GetDataInicialDoMesAtual();
            dtFinalEdit.DateTime = DataUtil.GetDataFinalDoMesAtual();

            if (cbConta.Properties.Items.Count == 0)
            {
                cbConta.Properties.Items.AddRange(contas);
                cbConta.SelectedIndex = 0;
            }
            gridControlExtrato.DataSource = lista;
        }

        public void RefreshItemClick()
        {
            XFrmWait.StartTask(carregarExtratos(), "Carregando extratos...");
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshItemClick();
        }

        private void XFrmViewExtratoBancario_Shown(object sender, EventArgs e)
        {
            RefreshItemClick();
        }

        private void btnEditExtrato_ItemClick(object sender, ItemClickEventArgs e)
        {
            ExtratoBancario extrato = gridViewExtrato.GetFocusedRow() as ExtratoBancario;
            if (extrato != null)
            {
                new XFrmAddLancamentoExtrato(extrato, FormTypeAction.Alterar).ShowDialog();
            }
        }

        private void btnPrintReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            var reportName = "ExtratoBancario";
            if (reportName != null)
                ReportUtil.PrintReportByName(reportName);
            else
            {
                XMessageIts.Mensagem("Selecione o relatório a ser gerado !");
            }
        }

        private void btnAddExtrato_ItemClick(object sender, ItemClickEventArgs e)
        {
            new XFrmAddLancamentoExtrato().ShowDialog();
        }

        private void btnCompensarExtratos_ItemClick(object sender, ItemClickEventArgs e)
        {
            List<ExtratoBancario> extratos = new List<ExtratoBancario>();
            extratos = gridViewExtrato.GetSelectedItens<ExtratoBancario>();

            if (extratos.Exists(ext => ext.Compensado == true))
            {
                XMessageIts.Advertencia("Existem extratos já compensados selecionados, por favor volte a tela do grid e desmarque esses lançamentos!");

            }
            else
            {
                var wizard = new XFrmCompensarExtrato(extratos).ShowDialog();
            }
        }

        private void gridViewExtrato_DoubleClick(object sender, EventArgs e)
        {
            btnEditExtrato_ItemClick(null, null);
        }

        private void btnExcluirExtrato_ItemClick(object sender, ItemClickEventArgs e)
        {
            List<ExtratoBancario> extratos = new List<ExtratoBancario>();
            extratos = gridViewExtrato.GetSelectedItens<ExtratoBancario>();

            var manager = new ExtratoDaoManager();

            var msg = "Certeza que deseja excluir os extratos selecionados?";
            var confirm = XMessageIts.Confirmacao(msg);
            if (confirm == DialogResult.Yes)
            {
                //se existir lancamento nos extratos, verifique se foram pagos
                if (extratos.Exists(ee => ee.IdLancamento != null && !ee.DataEstorno.HasValue))
                {
                    //prossiga somente se nao existirem lancamentos pagos na seleção.
                    if (!extratos.Exists(ex => ex.LancamentoFinanceiro.StatusLancamento == Entidades.Enumeradores.TypeStatusLancamentoFinanceiro.Pago))
                    {
                        var result = manager.ExcluirExtratos(extratos);

                        if (result)
                        {
                            XMessageIts.Mensagem("Extratos removidos com sucesso!");
                        }
                    }
                    else
                    {
                        XMessageIts.Advertencia("Existem extratos marcados que seus lançamentos estão pagos ou que estão compensados, por favor volte e desmarque, então siga novamente com a exclusão!");
                    }
                }

                //se existir extratos compensados..
                else if (extratos.Exists(ext => ext.Compensado == true))
                {
                    XMessageIts.Advertencia("Existem extratos marcados que que estão compensados, por favor volte e desmarque, então siga novamente com a exclusão!");
                }
                //prossiga somente se nao existir extratos compensados.
                else if (!extratos.Exists(ext => ext.Compensado == true))
                {
                    var result = manager.ExcluirExtratos(extratos);

                    if (result)
                    {
                        XMessageIts.Mensagem("Extratos removidos com sucesso!");
                    }
                }
            }
        }

        private void btnCancelarComp_ItemClick(object sender, ItemClickEventArgs e)
        {
            List<ExtratoBancario> extratos = new List<ExtratoBancario>();
            extratos = gridViewExtrato.GetSelectedItens<ExtratoBancario>();
            var manager = new ExtratoDaoManager();
            var msg = "Certeza que deseja cancelar a compensação os extratos selecionados?";
            var confirm = XMessageIts.Confirmacao(msg);
            if (confirm == DialogResult.Yes)
            {
                var result = manager.CancelarCompensacao(extratos);
                if (result)
                {
                    XMessageIts.Mensagem("Compensação cancelada com sucesso!");
                }
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            using (var ctx = new BalcaoContext())
            {
                var inicio = dtInicialEdit.DateTime;
                var final = dtFinalEdit.DateTime;
                var conta = cbConta.SelectedItem as ContaBancaria;

                if (inicio == null && final == null && conta == null)
                {
                    XMessageIts.Advertencia("Informe todos os campos para filtro!");
                }
                else
                {
                    var extratos = ctx.ExtratoBancarioDao.Where(ex => ex.DataExtrato.Date >= inicio && ex.DataExtrato.Date <= final && ex.IdContaBancaria == conta.IdContaBancaria);
                    gridControlExtrato.DataSource = extratos;
                }
            }
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            var inicio = dtInicialEdit.DateTime;
            var final = dtFinalEdit.DateTime;
            var conta = cbConta.SelectedItem as ContaBancaria;

            if (inicio == null && final == null && conta == null)
            {
                XMessageIts.Advertencia("Informe todos os campos para filtro!");
            }
            else
            {
                string reportName = "ExtratoBancario";
                var param = new ReportParameter(inicio, final, conta.CodigoContaBancaria);

                //cria o relatorio e avise que nao precisa setar parametros padrão
                XtraReport report = ReportUtil.CreateReportByName(reportName, false);

                if (report != null)
                {
                    //seta os paramentros
                    param.SetParams(report);

                    //gera relatorio 
                    ReportUtil.ShowPreviewReport(report);
                }
            }

        }

        #region Parametros Relatorio

        internal class ReportParameter
        {
            internal DateTime DataInicio { get; set; }
            internal DateTime DataFim { get; set; }
            internal string CodConta { get; set; }

            public ReportParameter(DateTime dtInicio, DateTime dtFim, string codConta)
            {
                this.CodConta = codConta;
                this.DataInicio = dtInicio;
                this.DataFim = dtFim;
            }

            internal void SetParams(XtraReport report)
            {
                try
                {

                    ParameterCollection newParams = new ParameterCollection();
                    foreach (Parameter p in report.Parameters)
                    {
                        Parameter param = new Parameter();
                        param.Name = p.Name;
                        // Specify other parameter properties.
                        param.Type = p.Type;
                        //description
                        param.Description = p.Description;

                        //nao consegui usar manipulavel aqui entao vai ficar assim
                        //deixe os paramentros visiveis
                        param.Visible = true;

                        if (param.Name.Equals("pDataInicial"))
                            param.Value = this.DataInicio.Date;

                        else if (param.Name.Equals("pDataFinal"))
                            param.Value = this.DataFim.Date;

                        else if (param.Name.Equals("pConta"))
                            param.Value = this.CodConta;

                        newParams.Add(param);
                    }

                    report.RequestParameters = false;
                    report.Parameters.Clear();
                    //add os novos parametros
                    foreach (var p in newParams)
                    {
                        report.Parameters.Add(p);
                        p.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    XMessageIts.Mensagem("Um ou mais parâmentros do relátorio não foram setados.");
                    LoggerUtilIts.GenerateLogs(ex);
                }

            }

        }
        #endregion

        private void btnCalcLiquido_ItemClick(object sender, ItemClickEventArgs e)
        {
            List<ExtratoBancario> extratos = new List<ExtratoBancario>();
            extratos = gridViewExtrato.GetSelectedItens<ExtratoBancario>();
            lbLiquido.Caption = extratos.Sum(ex => ex.ValorExtrato).ToString("N2");
        }
    }
}