using System;
using System.Threading.Tasks;
using ITE.Entidades.Repositorio;
using ITE.Fiscal.View;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;

namespace ITE.Fiscal.ListView
{
    public partial class XFrmMunicipioListView : DevExpress.XtraEditors.XtraForm
    {
        public XFrmMunicipioListView()
        {
            InitializeComponent();
        }

        private void barBtnViewLocalEstoque_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var municipioAnt = gridViewMunicipios.GetFocusedRow<Entidades.POCO.Fiscal.Municipios>();
            if (municipioAnt != null)
            {
                new XFrmAddMunicipio(municipioAnt).ShowDialog();
            }

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarMunicipios(), "Carregando municipios ...");

        }

        private async Task carregarMunicipios()
        {
            using (var ctx = new BalcaoContext())
            {
                var municipios = await ctx.MunicipiosDao.FindAllAsync();
                gridControlMunicipios.DataSource = municipios;
                this.gridViewMunicipios.Focus();
            }
        }

        private void XFrmGerenciarMunicipios_Shown(object sender, EventArgs e)
        {
            btnRefresh_ItemClick(null, null);
        }

        private void barBtnAddMunicipio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmAddMunicipio().ShowDialog();
        }

        private void gridViewLocaisEstoque_DoubleClick(object sender, EventArgs e)
        {
            var municipio = GridViewUtil.GetFocusedRow<Entidades.POCO.Fiscal.Municipios>(gridViewMunicipios);

            if (municipio != null)
            {
                //FormsUtil.ShowDialog(new XFrmNotaFiscal(notaFiscal, FormTypeAction.Visualizar));
            }
        }
    }
}