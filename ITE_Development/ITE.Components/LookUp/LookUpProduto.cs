using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.Forms;
using ITSolution.Framework.Forms;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Components.LookUp
{
    public partial class LookUpProduto : XtraUserControl
    {
        private TextEdit textEditFoco;

        public Produto Produto { get; set; }

        public string LabelText
        {
            get { return this.labelControl1.Text; }
            set { this.labelControl1.Text = value; }

        }
        public FontEdit LabelTextFont { get; set; }

        public bool ReadOnly
        {

            get { return txtCodProduto.ReadOnly && txtNomeProduto.ReadOnly; }
            set
            {
                txtCodProduto.ReadOnly = value;
                txtNomeProduto.ReadOnly = value;
                btnFindProduto.Enabled = !value;
            }
        }

        public LookUpProduto()
        {

            InitializeComponent();
            this.ActiveControl = this.txtCodProduto;
            this.txtCodProduto.Focus();
        }

        #region Eventos
        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtCodProduto.Text))
                {
                    using (var ctx = new BalcaoContext())
                    {
                        var id = ParseUtil.ToInt(txtCodProduto.Text);
                        var produtoFind = ctx.ProdutoDao.Find(id);
                        this.Produto = produtoFind;
                        txtNomeProduto.Text = produtoFind.DescricaoProduto;
                    }
                }
            }
            catch (NullReferenceException)
            {
                XMessageIts.Advertencia("Produto não encontrado!");
                txtNomeProduto.Text = "";
                return;
            }
        }

        private void btnFindProduto_Click(object sender, EventArgs e)
        {
            ShowFindProduto();
        }

        private void LookUpProduto_Load(object sender, EventArgs e)
        {
            indexarCampos();
        }

        private void txtCodProduto_KeyDown(object sender, KeyEventArgs e)
        {
            var cod = ParseUtil.ToInt(txtCodProduto.Text);

            if (e.KeyCode == Keys.Enter)
                if (cod != 0)
                    FindSetProduto(cod);
                else
                    btnFindProduto_Click(null, null);
        }
        #endregion

        #region Metodos

        public void ShowFindProduto()
        {
            //var ctx = ITEGenericContext<Produto>.Instance;
            using (var ctx = new BalcaoContext())
            {
                var paramsEntity = new ParamsFindEntity()
                {
                    Columns = new string[] { "IdProduto", "DescricaoProduto", "PrecoVenda",
                "QuantidadeProduto", "StatusProduto", "TipoItemProduto", "CategoriaProduto" },
                    Layout = GridViewUtil.GetLayoutStreamFromResource(Assembly.GetExecutingAssembly(),
                "ITE.Components.Resources.produto_basico.xml"),
                    Context = ctx,
                    Title = "Localizar produto:",
                    Order = "IdProduto"
                };

                var selected = XFrmFindEntity.ShowDialogFindEntity<Produto>(paramsEntity);

                if (selected != null)
                {
                    //recuperando os valores do objeto dinamico
                    //pego o tipo, dps a propriedade que quero, em seguida o valor
                    var id = selected.GetType().GetProperty("IdProduto").GetValue(selected, null);
                    //var nome = selected.GetType().GetProperty("DescricaoProduto").GetValue(selected, null);
                    FindSetProduto(ParseUtil.ToInt(id.ToString()));
                }
            }
        }
        public void FindSetProduto(int idProduto)
        {
            using (var ctx = new BalcaoContext())
            {
                {
                    try
                    {
                        txtCodProduto.Text = idProduto.ToString();
                        if (idProduto > 0)
                        {
                            this.Produto = ctx.ProdutoDao
                                .Where(f => f.IdProduto == idProduto)
                                .FirstOrDefault();

                            indexarCampos();

                            if (textEditFoco != null)
                                textEditFoco.Focus();
                        }
                    }
                    catch (NullReferenceException)
                    {
                        XMessageIts.Advertencia("Forma de pagamento não encontrada!");
                        txtNomeProduto.Text = "";
                        return;
                    }
                }
            }
        }

        private void indexarCampos()
        {
            if (Produto != null)
            {
                txtCodProduto.Text = Produto.IdProduto.ToString();
                txtNomeProduto.Text = Produto.DescricaoProduto;
            }
        }

        public void RedirectFocusTo(TextEdit txtEdit)
        {
            this.textEditFoco = txtEdit;

        }

        public void RequestFocus()
        {
            this.txtCodProduto.Focus();
            this.txtCodProduto.SelectAll();
        }

        public void Clear()
        {
            txtCodProduto.Text = "";
            txtNomeProduto.Text = "";
        }


        #endregion Metodos
    }
}
