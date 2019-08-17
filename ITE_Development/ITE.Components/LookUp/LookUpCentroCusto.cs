using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ITE.Entidades.Repositorio;
using ITE.Entidades.POCO.Contabil;
using ITSolution.Framework.Forms;
using ITSolution.Framework.Beans.Forms;
using ITSolution.Framework.Mensagem;

namespace ITE.Components
{
    public partial class LookUpCentroCusto : XtraUserControl
    {
        public CentroCusto CentroCusto { get; set; }

        public string LabelText
        {
            get { return this.labelControl1.Text; }
            set { this.labelControl1.Text = value; }

        }

        /// <summary>
        /// Desabilitar ou habilita a inserção de texto
        /// </summary>
        public void ReadOnlyMode(bool onOff = true)
        {
            if (onOff)
            {
                txtCodCentro.ReadOnly = true;
                buttonEdit1.ReadOnly = true;
                buttonEdit1.Enabled = false;
            }
            else
            {
                txtCodCentro.ReadOnly = false;
                buttonEdit1.ReadOnly = false;
                //btnFindCentro.Enabled = true;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return txtCodCentro.ReadOnly && buttonEdit1.ReadOnly;
            }
        }

        public TextEdit TextCodigoCentroCusto { get { return this.txtCodCentro; } }

        public LookUpCentroCusto()
        {
            InitializeComponent();
        }

        private void indexarCampos()
        {
            if (this.CentroCusto != null)
            {
                txtCodCentro.Text = this.CentroCusto.CodigoCentroCusto;
                buttonEdit1.Text = this.CentroCusto.NomeCentroCusto;
            }
        }

        public void FindSetCentroCusto(string codCentro)
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    txtCodCentro.Text = codCentro;
                    if (!string.IsNullOrEmpty(codCentro))
                    {
                        var centroFind = ctx.CentroCustoDao
                            .Where(f => f.CodigoCentroCusto == txtCodCentro.Text || f.IdCentroCusto.ToString() == codCentro)
                            .FirstOrDefault();

                        txtCodCentro.Text = centroFind.CodigoCentroCusto;
                        buttonEdit1.Text = centroFind.NomeCentroCusto;

                        this.CentroCusto = centroFind;
                    }
                }
                catch (NullReferenceException)
                {
                    XMessageIts.Advertencia("Centro de custo não encontrado!");
                    buttonEdit1.Text = "";
                    return;
                }
            }

        }

        /// <summary>
        /// Seleciona o centro de custo ou chama o form para selecionar
        /// </summary>
        public void ShowSelectCentroCusto()
        {
            this.CentroCusto = null;
            this.buttonEdit1.Text = "";
            if (String.IsNullOrEmpty(txtCodCentro.Text))
                btnFindCentroCusto_Click(null, null);
            else
                FindSetCentroCusto(txtCodCentro.Text);
        }

        private void btnFindCentroCusto_Click(object sender, EventArgs e)
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);

                var paramsFind = new ParamsFindEntity()
                {
                    Context = ctx,
                    Columns = new string[] { "Matriz.CodigoMatriz", "CodigoCentroCusto", "NomeCentroCusto" },
                    Order = "CodigoCentroCusto",
                    Title = "Localizar centro de custo:",
                    DynamicObject = null
                };
                
                var selected = XFrmFindEntity.ShowDialogFindEntity<CentroCusto>(paramsFind);

                if (selected != null)
                {
                    //recuperando os valores do objeto dinamico
                    //pego o tipo, dps a propriedade que quero, em seguida o valor
                    var id = selected.GetType().GetProperty("CodigoCentroCusto").GetValue(selected, null);
                    var nome = selected.GetType().GetProperty("NomeCentroCusto").GetValue(selected, null);

                    //seta os dados e indexa a filial
                    FindSetCentroCusto(id.ToString());
                } 
            }
        }

        private void LookUpMatrizCentroCusto_Load(object sender, EventArgs e)
        {
            indexarCampos();
        }

        private void txtCodCentro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                ShowSelectCentroCusto();
            }
        }

        private void txtCodCentro_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCodCentro.Text))
                FindSetCentroCusto(txtCodCentro.Text);
        }
    }
}
