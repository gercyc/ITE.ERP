using System;
using System.Threading.Tasks;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;
using ITE.Fiscal.View;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.GuiUtil;

namespace ITE.Fiscal.ListView
{
    public partial class XFrmViewCfop : DevExpress.XtraEditors.XtraForm
    {
        public XFrmViewCfop()
        {
            InitializeComponent();
        }

        private void barBtnViewLocalEstoque_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var cfopAnt = gridViewLocaisEstoque.GetFocusedRow<Cfops>();
            if (cfopAnt != null)
            {
                new XFrmAddCfop(cfopAnt, FormTypeAction.Alterar).ShowDialog();
            }

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarLocais(), "Carregando CFOPs ...");

        }

        private async Task carregarLocais()
        {
            using (var ctx = new BalcaoContext())
            {
                var Cfops = await ctx.CfopsDao.FindAllAsync();
                gridControlLocaisEstoque.DataSource = Cfops;
                this.gridViewLocaisEstoque.Focus();
            }
        }

        private void XFrmViewCfops_Shown(object sender, EventArgs e)
        {
            btnRefresh_ItemClick(null, null);
        }

        private void barBtnAddCfop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmAddCfop().ShowDialog();
        }

        private void gridViewCfops_DoubleClick(object sender, EventArgs e)
        {
            var cfop = GridViewUtil.GetFocusedRow<Cfops>(gridViewLocaisEstoque);

            if (cfop != null)
            {
                //new XFrmNotaFiscal(notaFiscal, FormTypeAction.Visualizar).ShowDialog();
            }
        }
    }
}