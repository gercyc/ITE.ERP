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
    public partial class XFrmPaisListView : DevExpress.XtraEditors.XtraForm
    {
        public XFrmPaisListView()
        {
            InitializeComponent();
        }

        private void barBtnViewPais_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var localEstAnt = gridViewLocaisEstoque.GetFocusedRow<LocalEstoque>();
            //if (localEstAnt != null)
            //{
            //    new XFrmAddPais(localEstAnt, FormTypeAction.Alterar).ShowDialog();
            //}

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarPaises(), "Carregando países...");

        }

        private async Task carregarPaises()
        {
            var ctx = new BalcaoContext();

            //if (gridControlLocaisEstoque.InvokeRequired)
            //{
            var paises = await ctx.PaisDao.FindAllAsync();

            this.Invoke(new MethodInvoker(delegate
            {
                gridControlPaises.DataSource = paises;
                this.gridViewPaises.Focus();
            }));
        }

        private void XFrmPaisListView_Shown(object sender, EventArgs e)
        {
            btnRefresh_ItemClick(null, null);
        }

        private void barBtnAddPais_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmAddPais().ShowDialog();
        }

        private void gridViewLocaisEstoque_DoubleClick(object sender, EventArgs e)
        {
            var pais = GridViewUtil.GetFocusedRow<Pais>(gridViewPaises);

            if (pais != null)
            {
                //FormsUtil.ShowDialog(new XFrmNotaFiscal(notaFiscal, FormTypeAction.Visualizar));
            }
        }
    }
}