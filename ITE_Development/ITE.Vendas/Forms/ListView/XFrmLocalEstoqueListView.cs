using System;
using System.Threading.Tasks;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;
using ITE.Vendas.Forms.View;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;

namespace ITE.Vendas.Forms.ListView
{
    public partial class XFrmLocalEstoqueListView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public XFrmLocalEstoqueListView()
        {
            InitializeComponent();
        }

        private async Task carregarLocais()
        {
            var ctx = new BalcaoContext();

            //this.Invoke(new MethodInvoker(delegate
            //{
            gridControlLocaisEstoque.DataSource = await ctx.LocalEstoqueDao.FindAllAsync();
            this.gridViewLocaisEstoque.Focus();
            //}));
        }

        private void XFrmGerenciarLocalEstoque_Shown(object sender, EventArgs e)
        {
            barBtnRefresh_ItemClick(null, null);
        }

        private void gridViewLocaisEstoque_DoubleClick(object sender, EventArgs e)
        {
            barBtnEditar_ItemClick(null, null);
        }

        private void barBtnNovo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmLocalEstoqueView().ShowDialog();

        }

        private void barBtnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var localEstAnt = gridViewLocaisEstoque.GetFocusedRow<LocalEstoque>();
            if (localEstAnt != null)
            {
                new XFrmLocalEstoqueView(localEstAnt).Show();
                gridViewLocaisEstoque.RefreshData();
            }
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarLocais(), "Carregando Locais de estoque ...");

        }
    }
}