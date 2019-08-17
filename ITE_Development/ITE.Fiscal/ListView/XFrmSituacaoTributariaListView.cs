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
    public partial class XFrmSituacaoTributariaListView : DevExpress.XtraEditors.XtraForm
    {
        public XFrmSituacaoTributariaListView()
        {
            InitializeComponent();
        }

        private void barBtnViewLocalEstoque_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var cstAnt = GridViewUtil.GetFocusedRow<SituacaoTributaria>(gridViewLocaisEstoque);
            if (cstAnt != null)
            {
                new XFrmAddSituacaoTributaria(cstAnt, FormTypeAction.Alterar).ShowDialog();
            }

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarCsts(), "Carregando situações tributárias ...");

        }

        private async Task carregarCsts()
        {
            var ctx = new BalcaoContext();

            var sitTributs = await ctx.SituacaoTributariaDao.FindAllAsync();
            gridControlLocaisEstoque.DataSource = sitTributs;
            this.gridViewLocaisEstoque.Focus();
        }

        private void XFrmGerenciarLocalEstoque_Shown(object sender, EventArgs e)
        {
            btnRefresh_ItemClick(null, null);
        }

        private void barBtnAddLocalEstoque_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmAddSituacaoTributaria().ShowDialog();
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