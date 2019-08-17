using System;
using System.Globalization;
using System.Linq;
using ITE.Entidades.DaoManager.VendasDaoManager;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITSolution.Reports.Forms.View;

namespace ITE.Reports.Relatorios
{
    public partial class RptNotaVendaBobina : DevExpress.XtraReports.UI.XtraReport
    {
        private XFrmReportView _xFrmReportView;

        public RptNotaVendaBobina(Venda venda)
        {
            InitializeComponent();
            this.lbDia.Text = DateTime.Now.Day.ToString();
            this.lbMes.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month);
            this.lbAno.Text = DateTime.Now.Year.ToString();
            IndexarDadosMatriz();
           
            //this.DataSource = null;
            this.DataSource = new VendaDaoManager().GetDataSource(venda);

            //cria o documento em background
            this.CreateDocument(true);

            this._xFrmReportView = new XFrmReportView(this);


        }

        /// <summary>
        ///Invoka o relatório da proposta
        /// </summary>
        public void Run()
        {
            this._xFrmReportView.ShowDialog();
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
                    //lbEmailMatriz.Text = matriz.EmailMatriz;
                }
            }
        }

    }
}
