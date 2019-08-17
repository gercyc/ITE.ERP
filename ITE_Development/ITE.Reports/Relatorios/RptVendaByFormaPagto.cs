using System;
using System.Linq;
using ITE.Entidades.DaoManager;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Util;
using ITSolution.Reports.Forms.View;

namespace ITE.Reports.Relatorios
{
    public partial class RptVendasFormaPagto : DevExpress.XtraReports.UI.XtraReport
    {
        private XFrmReportView _xFrmReportView;

        public RptVendasFormaPagto(DateTime dtInicial)
        {
            init(dtInicial, dtInicial);

            var vendas = new VendaFilterManager().FindVendasDoDia(dtInicial);

            setReport(vendas);
        }


        public RptVendasFormaPagto(DateTime dtInicial, TypeStatusVenda status)
        {
            init(dtInicial, dtInicial);

            var vendas = new VendaFilterManager().FindVendasDoDia(dtInicial, status);

            setReport(vendas);
        }

        public RptVendasFormaPagto(DateTime dtInicial, DateTime dtFinal)
        {
            init(dtInicial, dtFinal);

            var vendas = new VendaFilterManager().FindVendasByPeriodo(dtInicial, dtFinal);

            setReport(vendas);
        }
   
        public RptVendasFormaPagto(DateTime dtInicial, DateTime dtFinal, FormaPagamento formaPagamento)
        {
            init(dtInicial, dtFinal);
            var vendas = new VendaFilterManager().FindVendasByPeriodo(dtInicial, dtFinal);
            setReport(vendas);
        }

        //Para a proposta
        public RptVendasFormaPagto(DateTime dtInicial, DateTime dtFinal, TypeStatusVenda status)
        {
            init(dtInicial, dtFinal);
            var vendas = new VendaFilterManager().FindVendasByPeriodo(dtInicial, dtFinal, status, TypeAgrupamentoVendas.Cliente);
            setReport(vendas);
        }

        //Para a proposta
        public RptVendasFormaPagto(CliFor cliFor, DateTime dtInicial, DateTime dtFinal, TypeStatusVenda status)
        {
            init(dtInicial, dtFinal);
            var vendas = new VendaFilterManager().FindVendasByPeriodo(cliFor, dtInicial, dtFinal, status, TypeAgrupamentoVendas.Cliente);
            setReport(vendas);
        }

        private void init(DateTime dt1, DateTime dt2)
        {
            InitializeComponent();
            IndexarDadosMatriz();
            xrDtInicio.Text = DataUtil.ToDate(dt1);
            xrDtFinal.Text = DataUtil.ToDate(dt2);
        }

        private void setReport(IQueryable<Venda> iqueryable)
        {
            //Define o datasource atraves da proposta
            this.DataSource = iqueryable;
            //cria o documento em background
            this.CreateDocument(true);
            //form para visualizar o relatório
            this._xFrmReportView = new XFrmReportView(this);
        }
        /// <summary>
        ///Gerar relatório da proposta
        /// </summary>
        public void Run()
        {
            this._xFrmReportView.Run();
        }
        private void IndexarDadosMatriz()
        {
            using (var ctx = new BalcaoContext())
            {
                var matriz = ctx.EmpresaMatrizDao.FindAll().FirstOrDefault();

                if (matriz != null)
                {
                    lbMatriz.Text = matriz.RazaoSocial;
                    lbEndereco.Text = matriz.NomeEndereco + ", " + matriz.NumeroEndereco;
                    lbBairroCidade.Text = matriz.Bairro + " - " + matriz.Cidade;
                    lbEmailMatriz.Text = matriz.Email;
                }
            }
        }
    }
}
