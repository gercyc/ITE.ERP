using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;

namespace ITE.Vendas.Forms.ListView
{
    public partial class XFrmProdutoSemEstoque : DevExpress.XtraEditors.XtraForm
    {
        public XFrmProdutoSemEstoque()
        {
            InitializeComponent();
        }

        private void XFrmInfoProdutoDefasado_Shown(object sender, EventArgs e)
        {
            XFrmWait.StartTask(carregarProdutos(), "Procurando Produtos Defasados");
        }

        private async Task carregarProdutos()
        {
            var ctx = new BalcaoContext();

            //if (gridControlProduto.InvokeRequired)
            var produtos = await ctx.ProdutoDao.WhereAsync(p => p.StatusProduto == TypeStatusProduto.SemEstoque);

            this.Invoke(new MethodInvoker(delegate
            {
                gridControlProduto.DataSource = produtos;
                this.gridViewProduto.SelectRows(0, 0);
                this.gridViewProduto.Focus();
            }));
        }

        private void gridViewProdutoDef_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                gridViewProduto.DeleteRow();
            }
        }

        private void XFrmInfoProdutoSemEstoque_KeyDown(object sender, KeyEventArgs e)
        {
        }

    }
}