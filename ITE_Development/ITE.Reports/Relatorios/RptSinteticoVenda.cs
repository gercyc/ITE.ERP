using System;
using System.Linq;
using ITE.Entidades.DaoManager;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITE.Entidades.UnitControl;
using ITSolution.Reports.Forms.View;

namespace ITE.Reports.Relatorios
{
    public partial class RptSinteticoVenda : DevExpress.XtraReports.UI.XtraReport
    {
        private XFrmReportView _xFrmReportView;

        public RptSinteticoVenda(DateTime dtInicial, DateTime dtFinal,
           TypeStatusVenda statusVenda, TypeAgrupamentoVendas agrupar)
        {
            var vendas = new VendaFilterManager().FindVendasByPeriodo(dtInicial, dtFinal, statusVenda, agrupar);
            init(vendas, dtInicial, dtFinal);
            //this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            //new DevExpress.XtraReports.UI.GroupField("CliFor.NomeCliente", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        }

        public RptSinteticoVenda(CliFor cliFor, DateTime dtInicial, DateTime dtFinal,
            TypeStatusVenda statusVenda, TypeAgrupamentoVendas agrupar)
        {

            var vendas = new VendaFilterManager().FindVendasByPeriodo(cliFor, dtInicial, dtFinal, statusVenda, agrupar);

            init(vendas, dtInicial, dtFinal);
        }

        private void init(IQueryable<Venda> iq, DateTime dt1, DateTime dt2)
        {
            InitializeComponent();
            indexarDadosMatriz();
            xrDtInicio.Text = dt1.ToShortDateString();
            xrDtFinal.Text = dt2.ToShortDateString();

            //Define o datasource atraves da proposta
            this.DataSource = iq;

            //cria o documento em background
            this.CreateDocument(true);

            this._xFrmReportView = new XFrmReportView(this);
        }

        /// <summary>
        ///Gerar relatório da proposta
        /// </summary>
        public void Run()
        {
            this._xFrmReportView.Run();
        }

        private void indexarDadosMatriz()
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    var matriz = ctx.EmpresaMatrizDao.Find(UnitWork.Filial.IdMatriz);
                    xrLblMatriz.Text = matriz.RazaoSocial;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Matriz nao encontrada " + ex.Message);
                }
            }
        }


    }
}
