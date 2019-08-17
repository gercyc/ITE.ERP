using System;
using System.Threading.Tasks;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;
using ITE.CE.Forms.View;
using ITE.Entidades.UnitControl;

namespace ITE.CE.Forms
{
    public partial class XFrmCusteioListView : DevExpress.XtraEditors.XtraForm
    {
        public XFrmCusteioListView()
        {
            InitializeComponent();
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarCusteios(), "Carregando custeios ...");

        }

        private async Task carregarCusteios()
        {
            using (var ctx = new BalcaoContext())
            {
                var custeios = await ctx.CusteioDao.FindAllAsync();
                gridControl1.DataSource = custeios;
                this.gridView1.Focus();
            }
        }

        private void XFrmCusteioListView_Shown(object sender, EventArgs e)
        {
            barBtnRefresh_ItemClick(null, null);
        }

        private void barBtnViewCusteio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnAddCusteio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormsUtil.ShowDialog(new XFrmCusteio(UnitWork.Usuario));
        }
    }
}