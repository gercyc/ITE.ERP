using System;
using System.Linq;
using System.Windows.Forms;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.Forms;
using ITE.Entidades.POCO.Contabil;
using DevExpress.XtraEditors;
using ITE.Entidades.Enumeradores.TipoMovimentoEnum;
using ITSolution.Framework.GuiUtil;
using System.Reflection;
using ITSolution.Framework.Forms;

namespace ITE.Components
{
    public partial class LookUpTipoMovimento : XtraUserControl
    {

        /// <summary>
        /// Desabilitar ou habilita a inserção de texto
        /// </summary>
        public void ReadOnlyMode(bool onOff = true)
        {
            if (onOff)
            {
                txtCodTpMov.ReadOnly = true;
                txtDescTpMov.ReadOnly = true;
                btnFindTpMov.Enabled = false;
            }
            else
            {
                txtCodTpMov.ReadOnly = false;
                txtDescTpMov.ReadOnly = false;
                btnFindTpMov.Enabled = true;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return txtCodTpMov.ReadOnly && txtDescTpMov.ReadOnly;
            }
        }
        public TipoMovimento TipoMovimento { get; set; }
        public TypeFiltroMovimento TypeFiltroMovimento { get; set; }

        public TextEdit TextCodigoCentroTpMov { get { return this.txtCodTpMov; } }

        public LookUpTipoMovimento()
        {
            InitializeComponent();
        }

        private void indexarCampos()
        {
            if (this.TipoMovimento != null)
            {
                txtCodTpMov.Text = this.TipoMovimento.CodigoTipoMovimento;
                txtDescTpMov.Text = this.TipoMovimento.DescricaoTipoMovimento;
            }
        }

        public void FindSetTpMov(string codCentro)
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    txtCodTpMov.Text = codCentro;
                    if (!string.IsNullOrEmpty(codCentro))
                    {
                        var tpMovFind = ctx.TipoMovimentoDao
                            .Where(f => f.CodigoTipoMovimento == txtCodTpMov.Text)
                            .FirstOrDefault();

                        this.TipoMovimento = tpMovFind;
                        txtCodTpMov.Text = tpMovFind.CodigoTipoMovimento.ToString();
                        txtDescTpMov.Text = tpMovFind.DescricaoTipoMovimento;
                    }
                }
                catch (NullReferenceException)
                {
                    XMessageIts.Advertencia("Tipo de movimento não encontrado!");
                    txtDescTpMov.Text = "";
                    return;
                }
            }

        }
        /// <summary>
        /// Seleciona o centro de custo ou chama o form para selecionar
        /// </summary>
        public void ShowSelectTpMov()
        {
            this.TipoMovimento = null;
            this.txtDescTpMov.Text = "";
            if (String.IsNullOrEmpty(txtCodTpMov.Text))
                btnFindTpMov_Click(null, null);
            else
                FindSetTpMov(txtCodTpMov.Text);
        }

        private void btnFindTpMov_Click(object sender, EventArgs e)
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);

                var paramsFind = new ParamsFindEntity()
                {
                    Context = ctx,
                    Title = "Localizar tipo de movimento:",
                    Columns = new string[] { "CodigoTipoMovimento", "DescricaoTipoMovimento", "CategoriaTipoMovimento", "Direcao", "Numeracao", "MovimentarEstoque", "GeraMovimentoFiscal", "GerarFaturamento" },
                    Order = "",
                    DynamicObject = null,
                    Layout = GridViewUtil.GetLayoutStreamFromResource(Assembly.GetExecutingAssembly(),
             "ITE.Components.Resources.layout_tipoMovimento.xml")
                };

                //montagem da condicao
                
                if (TypeFiltroMovimento == TypeFiltroMovimento.Entradas)
                {
                    paramsFind.WhereCondition = "CodigoTipoMovimento.StartsWith(\"1\")";
                }
                else if (TypeFiltroMovimento == TypeFiltroMovimento.Saidas)
                {
                    paramsFind.WhereCondition = "CodigoTipoMovimento.StartsWith(\"2\")";
                }
                else
                {
                    paramsFind.WhereCondition = "CodigoTipoMovimento.StartsWith(\"3\")";
                }

                var selected = XFrmFindEntity.ShowDialogFindEntity<TipoMovimento>(paramsFind);

                if (selected != null)
                {
                    //recuperando os valores do objeto dinamico
                    //pego o tipo, dps a propriedade que quero, em seguida o valor
                    var id = selected.GetType().GetProperty("CodigoTipoMovimento").GetValue(selected, null);
                    var nome = selected.GetType().GetProperty("DescricaoTipoMovimento").GetValue(selected, null);

                    //seta os dados e indexa a filial
                    FindSetTpMov(id.ToString());
                }
            }
        }

        private void LookUpDescricaoTipoMovimento_Load(object sender, EventArgs e)
        {
            indexarCampos();
        }

        private void txtCodTpMov_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                ShowSelectTpMov();
            }
        }

        private void txtCodTpMov_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCodTpMov.Text))
                FindSetTpMov(txtCodTpMov.Text);
        }
    }
}
