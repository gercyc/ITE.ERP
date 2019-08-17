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
    public partial class LookUpRegraFiscal : XtraUserControl
    {

        /// <summary>
        /// Desabilitar a inserção de texto
        /// </summary>
        public void ReadOnlyMode()
        {
            txtCodCfop.ReadOnly = true;
            txtNomeCfop.ReadOnly = true;
            btnFindCfop.Enabled = false;
        }

        public bool IsReadOnly
        {
            get
            {
                return txtCodCfop.ReadOnly && txtNomeCfop.ReadOnly;
            }
        }
        public RegraFiscal RegraFiscal { get; set; }

        public TextEdit TextCodigoCentroCusto { get { return this.txtCodCfop; } }
        public LookUpRegraFiscal()
        {
            InitializeComponent();
        }

        private void indexarCampos()
        {
            if (this.RegraFiscal != null)
            {
                txtCodCfop.Text = this.RegraFiscal.CodigoRegraFiscal;
                txtNomeCfop.Text = this.RegraFiscal.DescricaoRegraFiscal;
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
                        var cfopFind = ctx.RegraFiscalDao
                            .Where(f => f.CodigoRegraFiscal == txtCodCfop.Text)
                            .FirstOrDefault();

                        this.RegraFiscal = cfopFind;
                        txtCodCfop.Text = cfopFind.CodigoRegraFiscal.ToString();
                        txtNomeCfop.Text = cfopFind.DescricaoRegraFiscal;
                    }
                }
                catch (NullReferenceException)
                {
                    XMessageIts.Advertencia("Regra fiscal não encontrada!");
                    txtNomeCfop.Text = "";
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
                    Columns = new string[] { "CodigoRegraFiscal", "DescricaoRegraFiscal", "TipoNatureza", "TipoDevolucao" },
                    Title = "Localizar Regra Fiscal:",
                    DynamicObject = null
                };
                
                var selected = XFrmFindEntity.ShowDialogFindEntity<RegraFiscal>(paramsFind);

                if (selected != null)
                {
                    //recuperando os valores do objeto dinamico
                    //pego o tipo, dps a propriedade que quero, em seguida o valor
                    var id = selected.GetType().GetProperty("CodigoRegraFiscal").GetValue(selected, null);
                    var nome = selected.GetType().GetProperty("DescricaoRegraFiscal").GetValue(selected, null);

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
            this.RegraFiscal = null;
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
