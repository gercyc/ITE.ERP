using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITE.Vendas.Forms.View;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;

namespace ITE.Vendas.Forms.ListView
{
    public partial class XFrmUnidMedidaListView : DevExpress.XtraEditors.XtraForm
    {

        public Usuario User { get; set; }

        public XFrmUnidMedidaListView()
        {
            InitializeComponent();
        }

        public XFrmUnidMedidaListView(Usuario user) : this()
        {
            // Construtor padrão, recebe o usuário logado no sistema
            this.User = user;
        }

        private void XFrmGerenciarUnidMedidas_Shown(object sender, EventArgs e)
        {
            barBtnAtualizar_ItemClick(null, null);
        }

        private void barBtnNovo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmUnidadeMedidaView().ShowDialog();
        }

        private void barBtnAlterar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewUnidMedidas.IsSelectOneRowWarning())
            {
                var unidMedida = gridViewUnidMedidas.GetFocusedRow() as UnidadeMedida;
                new XFrmUnidadeMedidaView(unidMedida).ShowDialog();
                gridViewUnidMedidas.FocusCurrentRow();
                
            }

        }

        private void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarUnidMedidas(), "Carregando Unidades de medida");
        }

        private async Task carregarUnidMedidas()
        {
            var ctx = new BalcaoContext();
            ctx.LazyLoading(false);
            var source = await Task.Run(() => ctx.UnidadeMedidaDao.FindAllAsync());

            gridControlUnidMedidas.DataSource = source;
        }
        private void gridControlUnidMedidas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var unidMedidaSelected = gridViewUnidMedidas.GetFocusedRow() as UnidadeMedida;
            //if(unidMedidaSelected != null)
            //FormsUtil.ShowDialog(new XFrmAddFormaPagamento(unidMedidaSelected));
        }

        private void gridViewUnidMedidas_DoubleClick(object sender, EventArgs e)
        {
            barBtnAlterar_ItemClick(null, null);
        }
    }
}