using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Forms;
using ITSolution.Framework.Beans.Forms;

namespace ITE.Components
{
    public partial class LookUpCfop : XtraUserControl
    {

        /// <summary>
        /// Desabilitar a inserção de texto
        /// </summary>
        public void ReadOnlyMode()
        {
            txtCodCfop.ReadOnly = true;
            buttonEdit1.ReadOnly = true;
            buttonEdit1.Enabled = false;
        }

        public bool IsReadOnly
        {
            get
            {
                return txtCodCfop.ReadOnly && buttonEdit1.ReadOnly;
            }
        }
        public Cfops CFOP { get; set; }

        public TextEdit TextCodigoCentroCusto { get { return this.txtCodCfop; } }
        public LookUpCfop()
        {
            InitializeComponent();
        }

        private void indexarCampos()
        {
            if (this.CFOP != null)
            {
                txtCodCfop.Text = this.CFOP.CodigoCfop;
                buttonEdit1.Text = this.CFOP.DescricaoCfop;
            }
        }


        public void FindSetCfop(string codCfop)
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    txtCodCfop.Text = codCfop;
                    if (!string.IsNullOrEmpty(codCfop))
                    {
                        var cfopFind = ctx.CfopsDao
                            .Where(f => f.CodigoCfop == txtCodCfop.Text)
                            .FirstOrDefault();

                        this.CFOP = cfopFind;
                        txtCodCfop.Text = cfopFind.CodigoCfop.ToString();
                        buttonEdit1.Text = cfopFind.DescricaoCfop;
                    }
                }
                catch (NullReferenceException)
                {
                    XMessageIts.Advertencia("CFOP não encontrado!");
                    buttonEdit1.Text = "";
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
                    Columns = new string[] { "CodigoCfop", "DescricaoCfop" },
                    Order = "CodigoCfop",
                    Title = "Localizar CFOP:",
                    DynamicObject = null
                };
                
                var selected = XFrmFindEntity.ShowDialogFindEntity<Cfops>(paramsFind);

                if (selected != null)
                {
                    //recuperando os valores do objeto dinamico
                    //pego o tipo, dps a propriedade que quero, em seguida o valor
                    var id = selected.GetType().GetProperty("CodigoCfop").GetValue(selected, null);
                    var nome = selected.GetType().GetProperty("DescricaoCfop").GetValue(selected, null);

                    //seta os dados e indexa a filial
                    FindSetCfop(id.ToString());
                } 
            }
        }

        private void LookUpMatrizCentroCusto_Load(object sender, EventArgs e)
        {
            indexarCampos();
        }

        private void txtCodCentro_KeyDown(object sender, KeyEventArgs e)
        {
            this.CFOP = null;
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(txtCodCfop.Text))
                    btnFindFilial_Click(null, null);
                else
                    FindSetCfop(txtCodCfop.Text);
            }
        }

    }
}
