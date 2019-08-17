using System;
using System.Threading.Tasks;
using DevExpress.XtraBars;
using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.Repositorio;
using ITE.Fiscal.Movimentacoes.OutrasMovimentacoes;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Enumeradores;
using System.Linq;

namespace ITE.Fiscal.TpMovimento
{
    public partial class XFrmMovimentoParametrizadoListView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public XFrmMovimentoParametrizadoListView()
        {
            InitializeComponent();
        }

        private void btnNovo_ItemClick(object sender, ItemClickEventArgs e)
        {
            new XFrmParametrizarMovimentoView().ShowDialog();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {

            XFrmWait.StartTask(carregarTiposMov(), "Carregando tipos mov...");
        }

        private void btnEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            var tipoSelect = gridView1.GetFocusedRow() as TipoMovimento;
            if (tipoSelect != null)
            {
                new XFrmParametrizarMovimentoView(tipoSelect, FormTypeAction.Alterar).ShowDialog();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_ItemClick(null, null);
        }

        private void XFrmViewTiposMovimento_Shown(object sender, EventArgs e)
        {
            btnRefresh_ItemClick(null, null);
        }
        private async Task carregarTiposMov()
        {
            var ctx = new BalcaoContext();
            var lista = await ctx.TipoMovimentoDao.FindAllAsync();

            gridControl1.DataSource = lista.OrderBy(l => l.CodigoTipoMovimento);
        }
    }
}