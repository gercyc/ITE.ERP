using System;
using System.Linq;
using System.Windows.Forms;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.Forms;
using ITE.Entidades.POCO.Contabil;
using DevExpress.XtraEditors;
using ITSolution.Framework.Forms;

namespace ITE.Components
{
    public partial class LookUpContaContabil : XtraUserControl
    {

        /// <summary>
        /// Desabilitar ou habilita a inserção de texto
        /// </summary>
        public void ReadOnlyMode(bool onOff = true)
        {
            if (onOff)
            {
                txtCodConta.ReadOnly = true;
                txtNomeConta.ReadOnly = true;
                btnFindConta.Enabled = false;
            }
            else
            {
                txtCodConta.ReadOnly = false;
                txtNomeConta.ReadOnly = false;
                btnFindConta.Enabled = true;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return txtCodConta.ReadOnly && txtNomeConta.ReadOnly;
            }
        }
        public ContaContabil ContaContabil { get; set; }

        public TextEdit TextCodigoContaContabil { get { return this.txtCodConta; } }

        public LookUpContaContabil()
        {
            InitializeComponent();
        }

        private void indexarCampos()
        {
            if (this.ContaContabil != null)
            {
                txtCodConta.Text = this.ContaContabil.CodigoContaContabil;
                txtNomeConta.Text = this.ContaContabil.DescricaoContaContabil;
            }
        }

        public void FindSetContaContabil(string codConta)
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    txtCodConta.Text = codConta;
                    if (!string.IsNullOrEmpty(codConta))
                    {
                        var contaFind = ctx.ContaContabilDao
                            .Where(f => f.CodigoContaContabil == txtCodConta.Text)
                            .FirstOrDefault();

                        this.ContaContabil = contaFind;
                        txtCodConta.Text = contaFind.CodigoContaContabil.ToString();
                        txtNomeConta.Text = contaFind.DescricaoContaContabil;
                    }
                }
                catch (NullReferenceException)
                {
                    XMessageIts.Advertencia("Conta contábil não encontrada!");
                    txtNomeConta.Text = "";
                    return;
                }
            }

        }

        private void btnFindConta_Click(object sender, EventArgs e)
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);


                var paramsFind = new ParamsFindEntity()
                {
                    Context = ctx,
                    Columns = new string[] { "Matriz.CodigoMatriz", "CodigoContaContabil", "DescricaoContaContabil", "TipoContaSped", "Natureza" },
                    Order = "CodigoContaContabil",
                    WhereCondition = "IndAnaliticaSintetica = \"Analitica\"",
                    Title = "Localizar conta contábil:",
                    DynamicObject = null
                };
                
                var selected = XFrmFindEntity.ShowDialogFindEntity<ContaContabil>(paramsFind);

                if (selected != null)
                {
                    //recuperando os valores do objeto dinamico
                    //pego o tipo, dps a propriedade que quero, em seguida o valor
                    var id = selected.GetType().GetProperty("CodigoContaContabil").GetValue(selected, null);
                    var nome = selected.GetType().GetProperty("DescricaoContaContabil").GetValue(selected, null);

                    //seta os dados e indexa a filial
                    FindSetContaContabil(id.ToString());
                }
            }
        }

        private void LookUpContaContabil_Load(object sender, EventArgs e)
        {
            indexarCampos();
        }

        private void txtCodConta_KeyDown(object sender, KeyEventArgs e)
        {
            this.ContaContabil = null;
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (String.IsNullOrEmpty(txtCodConta.Text))
                    btnFindConta_Click(null, null);
                else
                    FindSetContaContabil(txtCodConta.Text);
            }
        }
    }
}
