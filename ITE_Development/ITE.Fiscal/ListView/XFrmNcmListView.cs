using System;
using System.Threading.Tasks;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.ProgressBar;

namespace ITE.Fiscal.ListView
{
    public partial class XFrmNcmListView : DevExpress.XtraEditors.XtraForm
    {
        public XFrmNcmListView()
        {
            InitializeComponent();
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarNcms(), "Carregando NCMs ...");

        }

        private async Task carregarNcms()
        {
            using (var ctx = new BalcaoContext())
            {
                var ncms = await ctx.NcmsDao.FindAllAsync();
                gridControl1.DataSource = ncms;
                this.gridView1.Focus();
            }
        }

        private void XFrmViewNcm_Shown(object sender, EventArgs e)
        {
            barBtnRefresh_ItemClick(null, null);
        }

        private void barBtnViewMunicipio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}