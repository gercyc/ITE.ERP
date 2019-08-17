using System;
using System.Linq;
using System.Windows.Forms;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.Forms;
using ITE.Entidades.POCO.Contabil;
using DevExpress.XtraEditors;
using ITE.Entidades.POCO.Fiscal;
using ITSolution.Framework.Util;
using ITSolution.Framework.Forms;

namespace ITE.Components
{
    public partial class LookUpLocalEstoque : XtraUserControl
    {

        /// <summary>
        /// Desabilitar ou habilita a inserção de texto
        /// </summary>
        public void ReadOnlyMode(bool onOff = true)
        {
            if (onOff)
            {
                txtCodLocalEstoque.ReadOnly = true;
                txtNomeLocalEstoque.ReadOnly = true;
                btnFindLocalEstoque.Enabled = false;
            }
            else
            {
                txtCodLocalEstoque.ReadOnly = false;
                txtNomeLocalEstoque.ReadOnly = false;
                btnFindLocalEstoque.Enabled = true;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return txtCodLocalEstoque.ReadOnly && txtNomeLocalEstoque.ReadOnly;
            }
        }
        public LocalEstoque LocalEstoque { get; set; }

        public TextEdit TextCodigoLocalEstoque { get { return this.txtCodLocalEstoque; } }

        public LookUpLocalEstoque()
        {
            InitializeComponent();
        }
        public string LabelText
        {
            get { return this.labelControl1.Text; }
            set { this.labelControl1.Text = value; }

        }

        private void indexarCampos()
        {
            if (this.LocalEstoque != null)
            {
                txtCodLocalEstoque.Text = this.LocalEstoque.CodigoLocalEstoque;
                txtNomeLocalEstoque.Text = this.LocalEstoque.NomeLocalEstoque;
            }
        }

        public void FindSetLocalEstoque(string codigoLocalEstoque)
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    txtCodLocalEstoque.Text = codigoLocalEstoque.ToString();
                    if (!string.IsNullOrEmpty(codigoLocalEstoque.ToString()))
                    {
                        var localEstoqueFind = ctx.LocalEstoqueDao
                            .Where(f => f.CodigoLocalEstoque == codigoLocalEstoque)
                            .FirstOrDefault();

                        this.LocalEstoque = localEstoqueFind;
                        txtCodLocalEstoque.Text = localEstoqueFind.IdLocalEstoque.ToString();
                        txtNomeLocalEstoque.Text = localEstoqueFind.NomeLocalEstoque;
                    }
                }
                catch (NullReferenceException)
                {
                    XMessageIts.Advertencia("Local de estoque não encontrado!");
                    txtNomeLocalEstoque.Text = "";
                    return;
                }
            }

        }

        private void btnFindFilial_Click(object sender, EventArgs e)
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);

                var paramsFind = new ParamsFindEntity()
                {
                    Context = ctx,
                    Columns = new string[] { "IdLocalEstoque", "CodigoLocalEstoque", "NomeLocalEstoque" },
                    Title = "Localizar local de estoque:",
                    DynamicObject = null
                };

                var selected = XFrmFindEntity.ShowDialogFindEntity<LocalEstoque>(paramsFind);

                if (selected != null)
                {
                    //recuperando os valores do objeto dinamico
                    //pego o tipo, dps a propriedade que quero, em seguida o valor
                    var id = selected.GetType().GetProperty("CodigoLocalEstoque").GetValue(selected, null);
                    var nome = selected.GetType().GetProperty("NomeLocalEstoque").GetValue(selected, null);

                    //seta os dados e indexa a filial
                    FindSetLocalEstoque(id);
                }
            }
        }

        private void LookUpMatrizCentroCusto_Load(object sender, EventArgs e)
        {
            indexarCampos();
        }

        private void txtCodCentro_KeyDown(object sender, KeyEventArgs e)
        {
            this.LocalEstoque = null;
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (String.IsNullOrEmpty(txtCodLocalEstoque.Text))
                    btnFindFilial_Click(null, null);
                else
                    FindSetLocalEstoque(txtCodLocalEstoque.Text);
            }
        }
    }
}
