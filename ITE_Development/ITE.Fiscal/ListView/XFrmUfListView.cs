using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;
using ITE.Fiscal.View;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.GuiUtil;

namespace ITE.Fiscal.ListView
{
    public partial class XFrmUfListView : DevExpress.XtraEditors.XtraForm
    {
        public XFrmUfListView()
        {
            InitializeComponent();
        }

        private void barBtnViewLocalEstoque_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var localEstAnt = gridViewLocaisEstoque.GetFocusedRow<LocalEstoque>();
            if (localEstAnt != null)
            {
                new XFrmAddUf(localEstAnt, FormTypeAction.Alterar).ShowDialog();
            }

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarLocais(), "Carregando Locais de estoque ...");

        }

        private async Task carregarLocais()
        {
            var ctx = new BalcaoContext();

            //if (gridControlLocaisEstoque.InvokeRequired)
            //{
            var locaisEstoque = await ctx.LocalEstoqueDao.FindAllAsync();

            this.Invoke(new MethodInvoker(delegate
            {
                gridControlLocaisEstoque.DataSource = locaisEstoque;
                this.gridViewLocaisEstoque.Focus();
            }));
        }

        private void XFrmGerenciarLocalEstoque_Shown(object sender, EventArgs e)
        {
            btnRefresh_ItemClick(null, null);
        }

        private void barBtnAddLocalEstoque_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmUfListView().ShowDialog();
        }

        private void gridViewLocaisEstoque_DoubleClick(object sender, EventArgs e)
        {
            var localEstoque = GridViewUtil.GetFocusedRow<LocalEstoque>(gridViewLocaisEstoque);

            if (localEstoque != null)
            {
                //FormsUtil.ShowDialog(new XFrmNotaFiscal(notaFiscal, FormTypeAction.Visualizar));
            }
        }
    }
}