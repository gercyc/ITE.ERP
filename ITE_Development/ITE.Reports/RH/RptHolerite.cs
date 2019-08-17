using ITE.Entidades.DaoManager.RHDaoManager;
using ITE.Entidades.POCO.RH.Folha;
using ITSolution.Reports.Forms.View;

namespace ITE.Reports.Relatorios.RH
{
    public partial class RptHolerite : DevExpress.XtraReports.UI.XtraReport
    {
        private XFrmReportView _xFrmReportView;
        public RptHolerite(CompetenciaFolha competencia)
        {
            InitializeComponent();
            //this.lbDia.Text = DateTime.Now.Day.ToString();
            //this.lbMes.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month);
            //this.lbAno.Text = DateTime.Now.Year.ToString();
            // this.DataSource = null;
            this.DataSource = new FolhaDaoManager().GetDataSource(competencia.IdCompetencia);

            //cria o documento em background
            this.CreateDocument(true);

            this._xFrmReportView = new XFrmReportView(this);

        }
        public void Run()
        {
            this._xFrmReportView.Show();
        }

    }
}
