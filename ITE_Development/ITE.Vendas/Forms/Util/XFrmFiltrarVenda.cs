using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITE.Entidades.DaoManager;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO;
using ITE.Entidades.Repositorio;
using ITE.Reports.Relatorios;
using ITE.Vendas.Forms.ListView;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Common.BaseClasses.Reports;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITSolution.Reports.DaoManager;

namespace ITE.Vendas.Forms.Util
{

    public partial class XFrmFiltrarVenda : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly VendaFilterManager _vendaFilter;
        private List<ReportImage> _reports;
        public XFrmFiltrarVenda()
        {
            InitializeComponent();
            dtInicio.Value = DataUtil.GetDataInicialDoMesAtual();
            dtFinal.Value = DataUtil.GetDataFinalDoMesAtual();
            //do mes atual
            cbFiltro.SelectedIndex = 2;
            //e agora deixe o filtro aberto
            cbFiltro.SelectedIndex = 0;

            this._vendaFilter = new VendaFilterManager();
        }

        private TypeStatusVenda findStatusVenda()
        {
            var index = radioGroupStatus.SelectedIndex;

            if (index == 0) //Aberto
                return TypeStatusVenda.Aberto;

            if (index == 1) //Vencidas
                return TypeStatusVenda.Vencida;

            else if (index == 2) //Quitadas
                return TypeStatusVenda.Paga;

            else if (index == 3)//Cancelada
                return TypeStatusVenda.Cancelada;

            else  //Todas
                return TypeStatusVenda.Todas;
        }

        private PreFiltro findPreFiltro()
        {
           return (PreFiltro)cbFiltro.SelectedIndex;

            //switch (index)
            //{

            //    //Mês Atual
            //    case PreFiltro.MesAtual:
            //        return PreFiltro.MesAtual;

            //    //Mês Anterior
            //    case PreFiltro.MesAnterior:
            //        return PreFiltro.MesAnterior;

            //    //Por Dia
            //    case PreFiltro.PorDia:
            //        return PreFiltro.PorDia;

            //    //Por Ano
            //    case PreFiltro.PorAno:
            //        return PreFiltro.PorAno;

            //    default:
            //        //Por período
            //        return PreFiltro.Periodo;

            //}
        }

        private TypeAgrupamentoVendas findAgrupamento()
        {
           return (TypeAgrupamentoVendas)cbAgrupar.SelectedIndex;

            //switch (index)
            //{

            //    //cliente
            //    case TypeAgrupamentoVendas.Cliente:
            //        return TypeAgrupamentoVendas.Cliente;

            //    //Data da venda
            //    case TypeAgrupamentoVendas.DataVenda:
            //        return TypeAgrupamentoVendas.DataVenda;

            //    //Data de vencimento
            //    case TypeAgrupamentoVendas.Vencimento:
            //        return TypeAgrupamentoVendas.Vencimento;

            //    default:
            //        //Por período
            //        return TypeAgrupamentoVendas.Cliente;

            //}
        }


        private void ActionFilter(TypeReportView typeReport)
        {

            var status = findStatusVenda();
            var preFiltro = findPreFiltro();
            var agrupar = findAgrupamento();
            var cliente = gridViewCliente.GetFocusedRow<CliFor>();


            if (barToggleSwitchCliente.Checked && cliente == null)
            {
                XMessageIts.Mensagem("Informe o cliente antes de consultar ou desmarque a opção: \"Filtra Por Cliente\"");

                //filtre pelo cliente
                return;
            }
            else if (barToggleSwitchCliente.Checked==false)
            {
                cliente = null;

            }

            if (cliente != null)
            {

                //gera relatorio
                if (typeReport == TypeReportView.Report)
                {
                    new RptVendasPorCliente(cliente, dtInicio.Value, dtFinal.Value, status, agrupar).Run();
                }
                //exiba no grid
                else
                {
                    var result = _vendaFilter
                        .FindVendasByPeriodo(cliente, dtInicio.Value, dtFinal.Value, 
                        status, agrupar);

                    var vendas = result != null ? result.ToList() : null;
                    new XFrmProducaoVendas(vendas).Show();
                }
            }
            //filtra pelo status
            //os filtro predefinidos se encarregam de indexar as datas
            else
            {

                if (typeReport == TypeReportView.Report)
                {

                    //filtra pelo status
                    //o filtro por periodo é habilitado e preenchido automaticamente
                    //pelas opções do usuário
                    new RptSinteticoVenda(dtInicio.Value, dtFinal.Value, status, agrupar).Run();
                }

                else
                {
                    //exiba no grid
                    var result = _vendaFilter
                        .FindVendasByPeriodo(dtInicio.Value, dtFinal.Value, status, agrupar);

                    var vendas = result != null ? result.ToList() : null;
                    new XFrmProducaoVendas(vendas).Show();
                }
            }


        }

        private void setDate(DateTime dtInicio, DateTime dtFim)
        {
            this.dtInicio.Value = dtInicio;
            this.dtFinal.Value = dtFim;
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = (PreFiltro)cbFiltro.SelectedIndex;
            DateTime dt1 = dtInicio.Value;
            DateTime dt2 = dtFinal.Value;
            this.groupConsultaPeriodo.Enabled = false;
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

        private async Task carregarInformacoes()
        {
            var ctx = new BalcaoContext();
            ctx.LazyLoading(false);//desativa toda a lixaiada do cliente
            var source = await ctx.CliForDao.FindAllAsync();
            searchLkpCliente.Properties.DataSource = source;

            this._reports = new ReportDaoManager().GetReportGrpVendas();
            if (this._reports != null)
                //todos os relatorios do grupo vendas
                repCbReports.Items.AddRange(this._reports);

        }

        private void btnGerarRelatorio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ActionFilter(TypeReportView.Report);
        }

        private void barBtnVisualizarVendas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ActionFilter(TypeReportView.Grid);
        }

        private void barCheckCliente_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barToggleSwitchCliente.Checked)
            {
                grpCtrlClientes.Enabled = true;
                //se o grid ta vazio eu carrego
                if(gridViewCliente.DataSource == null)
                    XFrmWait.StartTask(carregarInformacoes(), "Carregando clientes");
            }
            else
            {
                searchLkpCliente.EditValue = null;
                grpCtrlClientes.Enabled = false;
            }
        }

  
    }
}