using System;
using System.Globalization;
using System.Linq;
using System.Text;
using ITE.Entidades.DaoManager.VendasDaoManager;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITSolution.Reports.Forms.View;

namespace ITE.Reports.Relatorios.TI
{
    public partial class RptNotaManutencao : DevExpress.XtraReports.UI.XtraReport
    {
        private XFrmReportView _xFrmReportView;

        public RptNotaManutencao(Venda venda)
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


            IndexarDados(venda);

            // this.DataSource = null;
            this.DataSource = new VendaDaoManager().GetDataSource(venda);

            var lanctos = new BalcaoContext().LancamentoFinanceiroDao
                .Where(l => l.IdVenda != null && l.IdVenda == venda.IdVenda).ToList();

            var sb1 = new StringBuilder("| ");
            var sb2 = new StringBuilder("| ");

            int metade = (lanctos.Count / 2);

            //cabe tudo na mesma linha
            if((metade*2) <= 6)
                metade = lanctos.Count;
            
            for (int i = 0; i < lanctos.Count; i++)
            {
                var l = lanctos[i];
                var data = l.DataVencimento.ToShortDateString();

                if (i < metade )
                    //maximo metade na mesma linha
                    sb1.Append(data).Append(" | ");
                else
                    sb2.Append(data).Append(" | ");
            }
            this.xrlDataVencimentos1.Text = sb1.ToString();

            //tem metade 
            if (metade != lanctos.Count)
                this.xrlDataVencimentos2.Text = sb2.ToString();

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

        private void IndexarDados(Venda venda)
        {
            var ctx = new BalcaoContext();
            var matriz = ctx.EmpresaMatrizDao.FindAll().FirstOrDefault();

            if (matriz != null)
            {
                lbMatriz.Text = matriz.RazaoSocial;
                lbEndereco.Text = matriz.NomeEndereco + ", " + matriz.NumeroEndereco;
                lbBairroCidade.Text = matriz.Bairro + " - " + matriz.Cidade;

                xrLabelCidade.Text = matriz.Cidade;

                if (string.IsNullOrEmpty(matriz.Telefone))
                    xrLabelTelEmpresa.Text = matriz.Fax;
                else
                    xrLabelTelEmpresa.Text = matriz.Telefone;


                try
                {

                    var r = ctx.CliFors.Where(c => c.IdCliFor == venda.IdCliForVenda).First();

                    if (string.IsNullOrEmpty(r.Telefone))
                        xrLabelTelCliFor.Text = r.Celular;

                    else if (string.IsNullOrEmpty(r.Celular))
                        xrLabelTelCliFor.Text = r.TelefoneComercial;

                    else
                        xrLabelTelCliFor.Text = r.Telefone;
                }
                catch
                {

                }



                /*if (matriz.Telefone.Length <= 10)
                    xrLabelTelEmpresa.Text = String.Format("{0:(##) ####-####}", tel); 
                else
                   xrLabelTelEmpresa.Text = String.Format("{0:(##) #####-####}", tel); ;*/

            }
        }

    }
}
