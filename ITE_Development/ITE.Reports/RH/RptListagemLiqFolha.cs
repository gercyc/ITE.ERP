using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ITE.Entidades.DaoManager.RHDaoManager;
using ITE.Entidades.POCO.RH.Folha;
using ITSolution.Reports.Forms.View;

namespace ITE.Reports.RH
{
    public partial class RptListagemLiqFolha : DevExpress.XtraReports.UI.XtraReport
    {
        private XFrmReportView _xFrmReportView;
        public RptListagemLiqFolha(CompetenciaFolha competencia)
        {
            InitializeComponent();
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
