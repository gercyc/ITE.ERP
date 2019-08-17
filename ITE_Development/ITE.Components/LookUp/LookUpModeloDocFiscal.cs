using System;
using System.Linq;
using System.Windows.Forms;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.Forms;
using ITE.Entidades.POCO.Contabil;
using DevExpress.XtraEditors;
using ITE.Entidades.POCO.Fiscal;
using ITSolution.Framework.Forms;

namespace ITE.Components
{
    public partial class LookUpModeloDocFiscal : XtraUserControl
    {

        /// <summary>
        /// Desabilitar ou habilita a inserção de texto
        /// </summary>
        public void ReadOnlyMode(bool onOff = true)
        {
            if (onOff)
            {
                txtCodModelo.ReadOnly = true;
                txtDescModelo.ReadOnly = true;
                btnFindModelo.Enabled = false;
            }
            else
            {
                txtCodModelo.ReadOnly = false;
                txtDescModelo.ReadOnly = false;
                btnFindModelo.Enabled = true;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return txtCodModelo.ReadOnly && txtDescModelo.ReadOnly;
            }
        }
        public ModeloDocumentoFiscal ModeloDocumentoFiscal { get; set; }

        public TextEdit TextCodigoCentroCusto { get { return this.txtCodModelo; } }

        public LookUpModeloDocFiscal()
        {
            InitializeComponent();
        }

        private void indexarCampos()
        {
            if (this.ModeloDocumentoFiscal != null)
            {
                txtCodModelo.Text = this.ModeloDocumentoFiscal.CodigoModelo;
                txtDescModelo.Text = this.ModeloDocumentoFiscal.DescricaoModelo;
            }
        }

        public void FindSetModelo(string codModelo)
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    txtCodModelo.Text = codModelo;
                    if (!string.IsNullOrEmpty(codModelo))
                    {
                        var modeloFind = ctx.ModeloDocumentoFiscalDao
                            .Where(f => f.CodigoModelo == txtCodModelo.Text)
                            .FirstOrDefault();

                        this.ModeloDocumentoFiscal = modeloFind;
                        txtCodModelo.Text = modeloFind.CodigoModelo.ToString();
                        txtDescModelo.Text = modeloFind.DescricaoModelo;
                    }
                }
                catch (NullReferenceException)
                {
                    XMessageIts.Advertencia("Modelo não encontrado!");
                    txtDescModelo.Text = "";
                    return;
                }
            }

        }
        /// <summary>
        /// Seleciona o centro de custo ou chama o form para selecionar
        /// </summary>
        public void ShowSelectModelo()
        {
            this.ModeloDocumentoFiscal = null;
            this.txtDescModelo.Text = "";
            if (String.IsNullOrEmpty(txtCodModelo.Text))
                btnFindModelo_Click(null, null);
            else
                FindSetModelo(txtCodModelo.Text);
        }

        private void btnFindModelo_Click(object sender, EventArgs e)
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);
                var paramsFind = new ParamsFindEntity()
                {
                    Context = ctx,
                    Columns = new string[] { "CodigoModelo", "DescricaoModelo" },
                    Title = "Localizar modelo de documento fiscal:",
                    DynamicObject = null
                };

                var selected = XFrmFindEntity.ShowDialogFindEntity<ModeloDocumentoFiscal>(paramsFind);

                if (selected != null)
                {
                    //recuperando os valores do objeto dinamico
                    //pego o tipo, dps a propriedade que quero, em seguida o valor
                    var id = selected.GetType().GetProperty("CodigoModelo").GetValue(selected, null);
                    var nome = selected.GetType().GetProperty("DescricaoModelo").GetValue(selected, null);

                    //seta os dados e indexa a filial
                    FindSetModelo(id.ToString());
                }
            }
        }

        private void LookUpModeloDocFiscal_Load(object sender, EventArgs e)
        {
            indexarCampos();
        }

        private void txtCodCentro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                ShowSelectModelo();
            }
        }

        private void txtCodModelo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCodModelo.Text))
                FindSetModelo(txtCodModelo.Text);
        }
    }
}
