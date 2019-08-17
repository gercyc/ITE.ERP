using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ITE.Entidades.POCO;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.Forms;
using ITSolution.Framework.Forms;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Components.LookUp
{
    public partial class LookUpCliFor : XtraUserControl
    {
        public CliFor CliFor { get; set; }
        public EmpresaMatriz Matriz { get; set; }
        public EmpresaFilial Filial { get; set; }
        public TextEdit TextCodCliFor { get { return this.txtIdCliFor; } }
        public void ReadOnlyMode(bool onOff = true)
        {
            if (onOff)
            {
                txtIdCliFor.ReadOnly = true;
                buttonEdit1.ReadOnly = true;
                buttonEdit1.Enabled = false;
            }
            else
            {

                txtIdCliFor.ReadOnly = false;
                buttonEdit1.ReadOnly = false;
                buttonEdit1.Enabled = true;
            }
        }

        /// <summary>
        /// true se Matriz e filial foram selecionado caso contrário false
        /// </summary>
        public bool IsMatrizFilial
        {
            get
            {
                return (this.Matriz != null && this.Filial != null);
            }
        }

        public LookUpCliFor()
        {
            InitializeComponent();

            this.ActiveControl = this.txtIdCliFor;
            this.txtIdCliFor.Focus();
        }

        private void indexarCampos()
        {
            if (this.CliFor != null)
            {

                txtIdCliFor.Text = this.CliFor.IdCliFor.ToString();
                buttonEdit1.Text = this.CliFor.RazaoSocial;
            }
        }

        public string LabelText
        {
            get { return this.labelControl2.Text; }
            set { this.labelControl2.Text = value; }

        }

        public void FindSetCliFor(string idCliFor)
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    txtIdCliFor.Text = idCliFor;
                    if (!string.IsNullOrEmpty(idCliFor))
                    {
                        var cliFor = ctx.CliForDao.Where(f => f.IdCliFor == ParseUtil.ToInt(txtIdCliFor.Text)).FirstOrDefault();
                        this.CliFor = cliFor;
                        txtIdCliFor.Text = cliFor.IdCliFor.ToString();
                        buttonEdit1.Text = cliFor.RazaoSocial;
                    }
                }
                catch (NullReferenceException)
                {
                    XMessageIts.Advertencia("Cliente/fornecedor não encontrado!");
                    buttonEdit1.Text = "";
                    return;
                }
            }
        }

        private void btnFindCliFor_Click(object sender, EventArgs e)
        {
            var paramsFind = new ParamsFindEntity()
            {
                Context = new BalcaoContext(),
                Columns = new string[] { "IdCliFor", "RazaoSocial", "TipoCliente", "CpfCnpj" },
                Layout = GridViewUtil.GetLayoutStreamFromResource(Assembly.GetExecutingAssembly(),
                        "ITE.Components.Resources.cliente_basico.xml"),
                Title = "Localizar Cliente / Fornecedor: "
            };

            var selected = XFrmFindEntity.ShowDialogFindEntity<CliFor>(paramsFind);

            if (selected != null)
            {
                //recuperando os valores do objeto dinamico
                //pego o tipo, dps a propriedade que quero, em seguida o valor
                var id = selected.GetType().GetProperty("IdCliFor").GetValue(selected, null);
                var nome = selected.GetType().GetProperty("RazaoSocial").GetValue(selected, null);

                if (nome == "CONSUMIDOR")
                {
                    XMessageIts.Mensagem("Cliente \"CONSUMIDOR\" é utilizado somente em vendas onde o \"Cliente\" não precisa ser informado.",
                        "Cliente não permitido");
                }
                else
                {
                    //seta os dados e indexa a filial
                    FindSetCliFor(id.ToString());
                }
            }
        }

        private void LookUpCliFor_Load(object sender, EventArgs e)
        {
            indexarCampos();
        }

        private void txtCodFilial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ShowSelectCliFor();
            }
        }

        /// <summary>
        /// Seleciona o cliente/fornecedore ou chama a tela para selecionar
        /// </summary>
        public void ShowSelectCliFor()
        {
            this.CliFor = null;
            this.buttonEdit1.Text = "";
            if (String.IsNullOrEmpty(txtIdCliFor.Text))
                btnFindCliFor_Click(null, null);
            else
                FindSetCliFor(txtIdCliFor.Text);
        }

        private void txtIdCliFor_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIdCliFor.Text))
                FindSetCliFor(txtIdCliFor.Text);
        }
    }
}
