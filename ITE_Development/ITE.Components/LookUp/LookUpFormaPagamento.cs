using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Util;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Beans.Forms;
using ITSolution.Framework.Forms;

namespace ITE.Components
{
    public partial class LookUpFormaPagamento : XtraUserControl
    {

        /// <summary>
        /// Desabilitar ou habilitar a inserção de texto
        /// </summary>
        public void ReadOnlyMode(bool onOff = true)
        {
            if (onOff)
            {
                txtIdFormaPagto.ReadOnly = true;
                buttonEdit1.ReadOnly = true;
                buttonEdit1.Enabled = false;
            }
            else
            {
                txtIdFormaPagto.ReadOnly = false;
                buttonEdit1.ReadOnly = false;
                buttonEdit1.Enabled = true;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return txtIdFormaPagto.ReadOnly && buttonEdit1.ReadOnly;
            }
        }
        public FormaPagamento FormaPagto { get; set; }

        public TextEdit TextCodigoCentroCusto { get { return this.txtIdFormaPagto; } }
        public LookUpFormaPagamento()
        {
            InitializeComponent();
        }

        private void indexarCampos()
        {
            if (this.FormaPagto != null)
            {
                txtIdFormaPagto.Text = this.FormaPagto.IdFormaPagamento.ToString();
                buttonEdit1.Text = this.FormaPagto.NomeFormaPagamento;
            }
        }


        public void FindSetFormaPagto(string idFormaPagto)
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    txtIdFormaPagto.Text = idFormaPagto;
                    if (!string.IsNullOrEmpty(idFormaPagto))
                    {
                        var formaPagtoFind = ctx.FormaPagamentoDao
                            .Where(f => f.IdFormaPagamento == ParseUtil.ToInt(txtIdFormaPagto.Text))
                            .FirstOrDefault();

                        this.FormaPagto = formaPagtoFind;
                        txtIdFormaPagto.Text = formaPagtoFind.IdFormaPagamento.ToString();
                        buttonEdit1.Text = formaPagtoFind.NomeFormaPagamento;
                    }
                }
                catch (NullReferenceException)
                {
                    XMessageIts.Advertencia("Forma de pagamento não encontrada!");
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
                    Columns = new string[] { "IdFormaPagamento", "NomeFormaPagamento", "TipoFormaPagamento" },
                    Title = "Localizar forma de pagamento:",
                    DynamicObject = null
                };

                var selected = XFrmFindEntity.ShowDialogFindEntity<FormaPagamento>(paramsFind);

                if (selected != null)
                {
                    //recuperando os valores do objeto dinamico
                    //pego o tipo, dps a propriedade que quero, em seguida o valor
                    var id = selected.GetType().GetProperty("IdFormaPagamento").GetValue(selected, null);
                    var nome = selected.GetType().GetProperty("NomeFormaPagamento").GetValue(selected, null);

                    //seta os dados e indexa a filial
                    FindSetFormaPagto(id.ToString());
                } 
            }
        }

        private void LookUpMatrizCentroCusto_Load(object sender, EventArgs e)
        {
            indexarCampos();
        }

        private void txtCodCentro_KeyDown(object sender, KeyEventArgs e)
        {
            this.FormaPagto = null;
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(txtIdFormaPagto.Text))
                    btnFindFilial_Click(null, null);
                else
                    FindSetFormaPagto(txtIdFormaPagto.Text);
            }
        }

    }
}
