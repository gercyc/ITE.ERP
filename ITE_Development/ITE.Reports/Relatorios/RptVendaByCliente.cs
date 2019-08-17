using System;
using System.Collections.Generic;
using System.Linq;
using ITE.Entidades.DaoManager;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITE.Entidades.UnitControl;
using ITSolution.Framework.Util;
using ITSolution.Reports.Forms.View;

namespace ITE.Reports.Relatorios
{
    public partial class RptVendasPorCliente : DevExpress.XtraReports.UI.XtraReport
    {
        private XFrmReportView _xFrmReportView;

        public RptVendasPorCliente(CliFor cliFor, DateTime dtInicial, DateTime dtFinal,
     TypeStatusVenda statusVenda, TypeAgrupamentoVendas agrupar)
        {
            var vendas = new VendaFilterManager()
                .FindVendasByPeriodo(cliFor, dtInicial, dtFinal, statusVenda, agrupar);

            init(cliFor, dtInicial, dtFinal, vendas);
        }


        private void init(CliFor cliFor, DateTime dt1, DateTime dt2, IQueryable<Venda> iqueryable)
        {
            //Task 6 - inclusão do nome do dia da semana e do mes
            //System.Globalization.DateTimeFormatInfo.CurrentInfo.GetDayName(DateTime.Now.DayOfWeek) <- pega dia da semana
            InitializeComponent();

            indexarDadosMatriz();

            xrDtInicio.Text = DataUtil.ToDate(dt1);
            xrDtFinal.Text = DataUtil.ToDate(dt2);
            //passa as vendas pro cliente
            cliFor.Vendas = iqueryable != null ? iqueryable.ToList() : null;

            List<CliFor> lst = new List<CliFor>();
            lst.Add(cliFor);

            //Define o datasource atraves da proposta
            this.DataSource = lst;

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
                ctx.LazyLoading(false);
                var matriz = ctx.EmpresaMatrizDao.Find(UnitWork.Filial.IdMatriz);
                ReportInfoUtil.FillFieldsMatriz(matriz, xrLblMatriz, xrLblEnderecoEmpresa, xrLblTelefoneEmpresa, xrPictureLogo);
              
            }
        }
    }
}
