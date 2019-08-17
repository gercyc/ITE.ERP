using System;
using System.Globalization;
using System.Linq;
using System.Text;
using ITE.Entidades.DaoManager.VendasDaoManager;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITSolution.Reports.Forms.View;

namespace ITE.Reports.Relatorios
{
    public partial class RptNotaVendaA4 : DevExpress.XtraReports.UI.XtraReport
    {
        private XFrmReportView _xFrmReportView;

        public RptNotaVendaA4(Venda venda)
        {
            InitializeComponent();
            this.lbDia.Text = DateTime.Now.Day.ToString();
            this.lbMes.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month);
            this.lbAno.Text = DateTime.Now.Year.ToString();

            if (string.IsNullOrEmpty(venda.Observacao))
            {
                xrLabelObs.SizeF = new System.Drawing.SizeF(0, 0);
                xrLabelObs.Visible = false;
            }
            IndexarDadosMatriz();

            // this.DataSource = null;
            this.DataSource = new VendaDaoManager().GetDataSource(venda);

            var lanctos = new BalcaoContext().LancamentoFinanceiroDao
                .Where(l => l.IdVenda != null && l.IdVenda == venda.IdVenda).ToList();

            var sb1 = new StringBuilder();
            var sb2 = new StringBuilder();

            int metade = lanctos.Count / 2;

            for (int i = 0; i < lanctos.Count; i++)
            {
                var l = lanctos[i];
                var data = l.DataVencimento.ToShortDateString();

                if (i < metade - 1)
                    //maximo metade na mesma linha
                    sb1.Append(data).Append(" | ");
                else
                    //  maximo 5 na mesma linha
                    sb2.Append(data).Append(" | ");
            }
            

            //cria o documento em background
            this.CreateDocument(true);

            this.XFrmReportView = new XFrmReportView(this);

      

        }

        public XFrmReportView XFrmReportView
        {
            get
            {
                return _xFrmReportView;
            }

            set
            {
                _xFrmReportView = value;
            }
        }

        /// <summary>
        ///Invoka o relatório da proposta
        /// </summary>
        public void Run()
        {
            this.XFrmReportView.ShowDialog();
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
                    xrLabelCidade.Text = matriz.Cidade;
                    xrLabelTelEmpresa.Text = matriz.Telefone;
                }
            }
        }

    }
}
