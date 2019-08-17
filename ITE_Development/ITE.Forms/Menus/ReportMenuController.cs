using ITSolution.Scheduler.Forms;
using ITE.Entidades.POCO;
using ITSolution.Framework.GuiUtil;
using ITSolution.Reports.Forms.ListView;
using ITSolution.Framework.Common.BaseClasses.Reports.Enumeradores;

namespace ITE.Forms.Menus
{
    public class ReportMenuController
    {
        private XFrmReportList _xFrmReportList;
        private XFrmDashboardListView _xFrmDashboardList;
        private XFrmSpoolReport _xFrmSpoolReport;
        private XFrmTaskCentral _xFrmTaskCentral;
        //Recurso Compartilhado
        private XFrmMenu _menu;

        public ReportMenuController(XFrmMenu menu)
        {
            this._menu = menu;
        }

        internal void CreateReport(Usuario currentUser)
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmReportList))
            {
                this._xFrmReportList = new XFrmReportList((TypeGroupUser)currentUser.IdGrupoUsuario);
            }
            FormsUtil.Show(_xFrmReportList, _menu);
        }

        internal void CreateDashboard(Usuario currentUser)
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmDashboardList))
            {
                this._xFrmDashboardList = new XFrmDashboardListView((TypeGroupUser)currentUser.IdGrupoUsuario);
            }
            FormsUtil.Show(this._xFrmDashboardList, _menu);
        }

        internal void ReportSpool()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmSpoolReport))
            {
                this._xFrmSpoolReport = new XFrmSpoolReport();
            }
            FormsUtil.Show(_xFrmSpoolReport, _menu);
        }

        internal void CentralProcesses()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmTaskCentral))
            {
                this._xFrmTaskCentral = new XFrmTaskCentral();
            }
            FormsUtil.Show(_xFrmTaskCentral, _menu);
        }
    }
}
