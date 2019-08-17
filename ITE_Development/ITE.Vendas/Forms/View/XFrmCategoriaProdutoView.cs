using System;
using ITE.Entidades.DaoManager.VendasDaoManager;
using ITE.Entidades.POCO.Sales;

namespace ITE.Vendas.Forms.View
{
    public partial class XFrmCategoriaProdutoView : DevExpress.XtraEditors.XtraForm
    {
        public XFrmCategoriaProdutoView()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CategoriaProduto categoria = new CategoriaProduto(txtNomeCategoria.Text);


            if (new CategoriaProdutoDaoManager().SaveUpdate(categoria))
            {
                this.Dispose();
            }
        }
    }
}