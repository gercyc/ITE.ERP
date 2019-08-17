using System;
using System.Windows.Forms;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using System.IO;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.Enumeradores;
using ITSolution.Framework.Util;
using ITE.Entidades.DaoManager;
using ITE.Entidades.POCO.Sales;

namespace ITE.Vendas.Forms.View
{
    public partial class XFrmProdutoSimplesView : DevExpress.XtraEditors.XtraForm
    {
        private Produto produtoAnt;

        public XFrmProdutoSimplesView()
        {
            InitializeComponent();
            cbCategoriaProduto.ShowPopup();

            this.openFileFoto.Filter = ImageUtilIts.ImageFilter;
        }

        public XFrmProdutoSimplesView(Produto pro) : this()
        {
            this.produtoAnt = pro;
            this.indexarDados(produtoAnt);
        }

        private void indexarDados(Produto pro)
        {
            txtDescricao.Text = pro.DescricaoProduto;

            ComboBoxUtil.AddItem<CategoriaProduto>(cbCategoriaProduto, pro.CategoriaProduto);
            ComboBoxUtil.AddItem<UnidadeMedida>(cbUnidadeMed, pro.UnidadeMedida);
            cbStatusProduto.SelectedIndex = (int)pro.StatusProduto;

            ComponenteUtil.ReadyOnly(true,
                cbCategoriaProduto, txtDescricao,
                cbUnidadeMed, cbStatusProduto);

            pictureFotoProduto.Image = ImageUtilIts.GetImageFromBytes(pro.FotoProduto);
            txtCodigoBarras.Text = pro.CodigoBarras;

        }

        public Produto indexarDados()
        {
            string desc = txtDescricao.Text;

            var cat = cbCategoriaProduto.GetSelectedItem<CategoriaProduto>();

            var unidadeMed = cbUnidadeMed.GetSelectedItem<UnidadeMedida>();

            var codBarras = txtCodigoBarras.Text;

            var tpProduto = (TypeItemProduto)rdProdServ.SelectedIndex;

            byte[] bytesProduto = null;

            if (!String.IsNullOrWhiteSpace(openFileFoto.FileName) && this.openFileFoto.CheckFileExists)
            {
                try
                {
                    bytesProduto = ImageUtilIts.GetBytesFromStream(openFileFoto.OpenFile());
                }
                catch (FileNotFoundException ex)
                {
                    XMessageIts.ExceptionMessage(ex);
                }
            }

            TypeStatusProduto status = (TypeStatusProduto)cbStatusProduto.SelectedIndex;

            var novo = new Produto(desc, cat, unidadeMed, codBarras, tpProduto,
                                0, 0, bytesProduto, status);

            if (produtoAnt != null)
                novo.IdProduto = produtoAnt.IdProduto;

            return novo;
        }

        //Gera o codigo de barras se ele nao for informado
        private void generateCodigoBarras(BalcaoContext ctx, Produto p)
        {
            if (String.IsNullOrEmpty(p.CodigoBarras))
            {
                var r = ctx.ProdutoDao.Last();
                int id = 1;
                if (r != null)
                {
                    var tam = r.IdProduto.ToString().Length;

                    id = r != null ? (r.IdProduto + 1)
                                            : 1;
                    if (tam == 1)
                        p.CodigoBarras = "0000" + id;
                    else if (tam == 2)
                        p.CodigoBarras = "000" + id;
                    else if (tam == 3)
                        p.CodigoBarras = "00" + id;
                    else if (tam == 4)
                        p.CodigoBarras = "0" + id;
                    else
                        p.CodigoBarras = "" + id;
                }
                else
                {
                    p.CodigoBarras = "0000" + id;

                }
            }
        }

        #region Eventos
        private void XFrmAddProduto_Shown(object sender, EventArgs e)
        {
            //cbStatusProduto.Properties.Items.AddRange(Enum.GetValues(typeof(TypeStatusProduto)));
            if (produtoAnt == null)
                btnAtualizarCategorias_Click(null, null);

        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            new XFrmCategoriaProdutoView().ShowDialog();
            btnAtualizarCategorias_Click(null, null);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto novo = indexarDados();

            using (var ctx = new BalcaoContext())
            {
                var manager = new ProdutoDaoManager();

                //se foi setado o codigo de barras
                if (string.IsNullOrEmpty(novo.CodigoBarras) == false)
                {
                    //sempre cheque o codigo de barras
                    var find = manager.GetProdutoByCodigoBarras(novo.CodigoBarras);

                    if (find != null)
                    {
                        var op = XMessageIts.Confirmacao("Código de barras " + novo.CodigoBarras + " já utilizado !\n\n"
                            + "Gerar código de barra aleatóriamente ?");

                        if (op == DialogResult.Yes)
                            novo.CodigoBarras = null;
                        else
                            return;
                    }
                }
                //localizado pelo nome
                var current = manager.GetProdutoByDescricao(novo.DescricaoProduto);

                if (current != null)
                {
                    XMessageIts.Advertencia("Nome \"" + novo.DescricaoProduto + "\" já utilizado !", "Aviso");
                }
                else
                {
                    //se estou cadastrando um novo produto
                    if (produtoAnt == null)
                    {
                        generateCodigoBarras(ctx, novo);

                        if (ctx.ProdutoDao.Save(novo))
                        {

                            XMessageIts.Mensagem("Produto salvo com sucesso.");
                            this.Dispose();
                        }
                    }
                    else
                    {
                        //estou atualizando o produto
                        //nao vai entrar nesse caso pois a tela de update eh tela detalhada
                        var pro = ctx.ProdutoDao.Find(produtoAnt.IdProduto);

                        pro.FotoProduto = novo.FotoProduto;

                        if (ctx.ProdutoDao.Update(pro))
                        {
                            XMessageIts.Mensagem("Produto atualizado com sucesso.");
                            this.Dispose();
                        }
                    }
                }
            }
        }

        private void barBtnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                var op = XMessageIts.Confirmacao("Deseja cancelar cadastro de produto ?");

                if (op == DialogResult.Yes)
                    this.Dispose();
            }
            else
                this.Dispose();
        }
        private void btnAtualizarCategorias_Click(object sender, EventArgs e)
        {
            var cats = new BalcaoContext().CategoriaProdutoDao.FindAll();
            var unm = new BalcaoContext().UnidadeMedidaDao.FindAll();
            ComboBoxUtil.AddList<CategoriaProduto>(cbCategoriaProduto, cats);
            ComboBoxUtil.AddList<UnidadeMedida>(cbUnidadeMed, unm);

            cbCategoriaProduto.SelectedItem = null;
            cbUnidadeMed.SelectedItem = null;
        }

        private void pictureFotoProduto_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var op = openFileFoto.ShowDialog();
                if (op == DialogResult.OK)
                {
                    byte[] b = ImageUtilIts.GetBytesFromStream(openFileFoto.OpenFile());
                    pictureFotoProduto.Image = ImageUtilIts.GetImageFromBytes(b);
                }
            }
        }


        #endregion

     
    }
}