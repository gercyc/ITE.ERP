using System;
using System.Globalization;
using System.Linq;
using System.Text;
using ITE.Entidades.DaoManager.VendasDaoManager;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITE.Entidades.UnitControl;
using ITSolution.Reports.Forms.View;

namespace ITE.Reports.Relatorios
{
    public partial class RptNotaVenda : DevExpress.XtraReports.UI.XtraReport
    {
        private readonly XFrmReportView _xFrmReportView;

        public RptNotaVenda(Venda venda)
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

            indexarDados(venda);

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

        private void indexarDados(Venda venda)
        {
            using (var ctx = new BalcaoContext())
            {
                // this.DataSource = null;
                this.DataSource = new VendaDaoManager().GetDataSource(venda);

                var matriz = ctx.EmpresaMatrizDao.Find(UnitWork.Filial.IdMatriz);

                var cliente = ctx.CliForDao.Find(venda.IdCliForVenda);

                ReportInfoUtil.FillFieldsMatriz(matriz, xrLblMatriz, xrLblEnderecoEmpresa,
                    xrLblTelefoneEmpresa, xrPictureLogo);

                ReportInfoUtil.FillFieldsTelefoneCliente(cliente, xrLblTelefoneCliente);


                var lanctos = ctx.LancamentoFinanceiroDao
                    .Where(l => l.IdVenda != null && l.IdVenda == venda.IdVenda).ToList();

                var sb1 = new StringBuilder("| ");
                var sb2 = new StringBuilder("| ");
                int count = lanctos.Count;
                int metade = (count / 2);

                //cabe tudo na mesma linha
                if ((metade * 2) <= 6 && count <= 6)
                    metade = lanctos.Count;

                else
                    metade = 6;

                for (int i = 0; i < lanctos.Count; i++)
                {
                    var l = lanctos[i];
                    var data = l.DataVencimento.ToShortDateString();

                    if (i < metade)
                        //maximo metade na mesma linha
                        sb1.Append(data).Append(" | ");
                    else
                        sb2.Append(data).Append(" | ");
                }
                this.xrlDataVencimentos1.Text = sb1.ToString();

                //tem metade 
                if (metade != lanctos.Count)
                    this.xrLblDataVencimentos2.Text = sb2.ToString();

            }

        }
    }
}
