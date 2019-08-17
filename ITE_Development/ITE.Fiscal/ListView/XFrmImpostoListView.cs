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
    public partial class XFrmImpostoListView : DevExpress.XtraEditors.XtraForm
    {
        public XFrmImpostoListView()
        {
            InitializeComponent();
        }

        private void barBtnViewImposto_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var impostoAnt = gridViewLocaisEstoque.GetFocusedRow<TipoImposto>();
            if (impostoAnt != null)
            {
                new XFrmAddImposto(impostoAnt, FormTypeAction.Alterar).ShowDialog();
            }

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarImpostos(), "Carregando impostos ...");

        }

        private async Task carregarImpostos()
        {
            var ctx = new BalcaoContext();
            var impostos = await ctx.TipoImpostoDao.FindAllAsync();
            gridControlLocaisEstoque.DataSource = impostos;
            this.gridViewLocaisEstoque.Focus();
        }

        private void XFrmGerenciarImpostos_Shown(object sender, EventArgs e)
        {
            btnRefresh_ItemClick(null, null);
        }

        private void barBtnAddImposto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmAddImposto().ShowDialog();
        }

        private void gridViewImpostos_DoubleClick(object sender, EventArgs e)
        {
            var imposto = GridViewUtil.GetFocusedRow<TipoImposto>(gridViewLocaisEstoque);

            if (imposto != null)
            {
                //FormsUtil.ShowDialog(new XFrmNotaFiscal(notaFiscal, FormTypeAction.Visualizar));
            }
        }
    }
}