using System;
using System.Threading.Tasks;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO;
using ITE.Entidades.Repositorio;
using ITE.Entidades.UnitControl;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITSolution.Reports.DaoManager;
using ITSolution.Reports.Util;

namespace ITE.Financeiro.Forms.Filters
{

    public partial class XFrmFiltrarLancamentos : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public XFrmFiltrarLancamentos()
        {
            InitializeComponent();
            dtEditInicio.Value = DataUtil.GetDataInicialDoMesAtual();
            dtEditFinal.Value = DataUtil.GetDataFinalDoMesAtual();
            cbFiltro_SelectedIndexChanged(null, null);
            lookUpFilial1.FindSetFilial(UnitWork.Filial);
        }

        #region Metodos
        private async Task loadClients()
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);//desativa toda a lixaiada do cliente
                var source = await ctx.CliForDao.FindAllAsync();
                searchLkpCliente.Properties.DataSource = source;

            }

        }

        private ReportParameter indexarParam(CliFor cliente)
        {
            //gera os parametros pro relatório relatorios 
            var status = (TypeStatusLancamentoFinanceiro)radioStatus.SelectedIndex;
            var tipo = (TypeLancamentoFinanceiro)radioTipoLancamento.SelectedIndex;
            var cc = lookUpCentroCusto1.CentroCusto != null ?
                lookUpCentroCusto1.CentroCusto.IdCentroCusto : 0;
            //var preFiltro = (PreFiltro)cbFiltro.SelectedIndex;
            //var agrupar = (TypeAgrupamentoVendas)cbAgrupar.SelectedIndex;

            //encapsula e obtem os paramentros
            return new ReportParameter(dtEditInicio.Value, dtEditFinal.Value,
                                    cliente, status, tipo, cc, lookUpFilial1.Matriz.CodigoMatriz);
        }
        private void setDate(DateTime dtInicio, DateTime dtFim)
        {
            this.dtEditInicio.Value = dtInicio;
            this.dtEditFinal.Value = dtFim;
        }

        private void actionFilter(TypeReportView typeReport)
        {
            var cliente = gridViewCliente.GetFocusedRow<CliFor>();
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            if (barToggleSwitchCliente.Checked && cliente == null)
            {
                XMessageIts.Mensagem("Informe o cliente antes de consultar ou desmarque a opção: \"Filtra Por Cliente\"");
            }
            else
            {
                if (barToggleSwitchCliente.Checked == false)
                    cliente = null;


                if (lookUpFilial1.Matriz == null || lookUpFilial1.Matriz.IdMatriz == 0)
                {
                    XMessageIts.Mensagem("Selecione a filial para continuar !");
                }
                else
                {
                    //gera os parametros pro relatório relatorios 
                    //encapsula e obtem os paramentros
                    var param = indexarParam(cliente);

                    string reportName = "ReportLancamentosFinanceiros";

                    if (cbAgrupar.SelectedIndex == 1)
                        reportName = "ReportLancamentosFinanceirosAgrupado";

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
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        #endregion 

        #region Eventos

        private void btnGerarRelatorio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            actionFilter(TypeReportView.Report);
        }


        private void barCheckCliente_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barToggleSwitchCliente.Checked)
            {
                grpCtrlClientes.Enabled = true;
                cbAgrupar.SelectedIndex = 0;
            }
            else
            {
                searchLkpCliente.EditValue = null;
                grpCtrlClientes.Enabled = false;
                cbAgrupar.SelectedIndex = -1;
            }
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreFiltro index = (PreFiltro)cbFiltro.SelectedIndex;
            DateTime dt1 = dtEditInicio.Value;
            DateTime dt2 = dtEditFinal.Value;
            //Por Período
            //Próximo Mês
            //Mês Atual
            //Mês Anterior
            //Por Dia
            //Por Ano
            switch (index)
            {
                //Por período
                case PreFiltro.Periodo:
                    this.groupConsultaPeriodo.Enabled = true;
                    break;

                //Proximo Mês
                case PreFiltro.ProximoMes:
                    int mes = DateTime.Now.Month + 1;
                    dt1 = DataUtil.GetDataInicialDoMes(mes);
                    dt2 = DataUtil.GetDataFinalDoMes(mes);
                    break;

                //Mês Atual
                case PreFiltro.MesAtual:
                    mes = DateTime.Now.Month;
                    dt1 = DataUtil.GetDataInicialDoMes(mes);
                    dt2 = DataUtil.GetDataFinalDoMes(mes);

                    break;

                //Mês Anterior

                case PreFiltro.MesAnterior:
                    mes = DateTime.Now.Month - 1;
                    dt1 = DataUtil.GetDataInicialDoMes(mes);
                    dt2 = DataUtil.GetDataFinalDoMes(mes);
                    break;


                //Por Dia
                case PreFiltro.PorDia:
                    dt1 = DateTime.Now;
                    dt2 = DateTime.Now;
                    break;

                //Por Ano
                case PreFiltro.PorAno:
                    //Todas as vendas em aberto do ano recorrente
                    dt1 = DataUtil.GetDataInicialDoMes(1);
                    dt2 = DataUtil.GetDataFinalDoMes(12);
                    break;

                default:
                    break;
            }
            setDate(dt1, dt2);


        }

        private void XFrmFiltrarLancamentos_Shown(object sender, EventArgs e)
        {
            XFrmWait.StartTask(loadClients());

        }

        #endregion

        #region Parametros Relatorio

        internal class ReportParameter
        {
            internal DateTime DataInicio { get; set; }
            internal DateTime DataFim { get; set; }

            //  0 Todos os cliente
            internal int IdCliente { get; set; }
            // Contas a Pagar = 0,
            // Contas a  Receber = 1,
            // Pagar e Receber = 2 
            internal int Tipo { get; set; }

            internal int IdCentroCusto { get; set; }

            // Aberto = 0,  
            // Pago = 1, 
            // Vencido = 2,  
            // Cancelado = 3,  
            // Todos = 4,
            internal int Status { get; set; }

            internal string CodigoMatriz { get; set; }

            public ReportParameter(DateTime dtInicio, DateTime dtFim, CliFor cliente,
TypeStatusLancamentoFinanceiro status, TypeLancamentoFinanceiro tipo, int idCentroCusto, string codigoMatriz)
            {
                this.IdCliente = cliente != null ? cliente.IdCliFor : 0;
                this.DataInicio = dtInicio;
                this.DataFim = dtFim;
                this.Status = (Int16)status;
                this.Tipo = (Int16)tipo;
                this.CodigoMatriz = codigoMatriz;
                this.IdCentroCusto = idCentroCusto;
            }

            internal void SetParams(XtraReport report)
            {
                try
                {

                    ParameterCollection newParams= new ParameterCollection();
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

                        if (param.Name.Equals("P_DTINICIO"))
                            param.Value = this.DataInicio.Date;

                        else if (param.Name.Equals("P_DTFIM"))
                            param.Value = this.DataFim.Date;

                        else if (param.Name.Equals("P_IDCLIENTE"))
                            param.Value = this.IdCliente;

                        else if (param.Name.Equals("P_STATUS"))
                            param.Value = this.Status;

                        else if (param.Name.Equals("P_TIPO_LANCAMENTO"))
                            param.Value = this.Tipo;

                        else if (param.Name.Equals("P_IDCENTRO_CUSTO"))
                                param.Value = this.IdCentroCusto;

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
    }
}
