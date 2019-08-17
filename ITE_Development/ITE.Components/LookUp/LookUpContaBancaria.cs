using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITSolution.Framework.Forms;
using ITSolution.Framework.Beans.Forms;

namespace ITE.Components
{
    public partial class LookUpContaBancaria : XtraUserControl
    {
        public ContaBancaria ContaBancaria { get; set; }
        public string LabelText
        {
            get { return this.labelControl1.Text; }
            set { this.labelControl1.Text = value; }

        }

        public LookUpContaBancaria()
        {
            InitializeComponent();
            this.ActiveControl = this.txtCodConta;
            this.txtCodConta.Focus();
        }

        private void indexarCampos()
        {
            if (this.ContaBancaria != null)
            {
                txtCodConta.Text = this.ContaBancaria.CodigoContaBancaria;
                buttonEdit1.Text = this.ContaBancaria.DescricaoContaBancaria;
            }
        }

        public void FindSetContaBancaria(string codigoConta)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    //nao carregar os relacionamentos
                    ctx.LazyLoading(false);


                    if (!String.IsNullOrEmpty(codigoConta))
                    {
                        var contas = ctx.ContasBancaria
                            .Where(f => f.CodigoContaBancaria == codigoConta);

                        if (contas.ToList().Count > 1)
                        {
                            //se isso aconteceu tem algo errado
                            XMessageIts.Mensagem("Número da conta informado pertence a mais de uma conta");
                        }
                        else
                        {
                            var current = contas.FirstOrDefault();

                            this.ContaBancaria = current;

                            txtCodConta.Text = current.Agencia;
                            buttonEdit1.Text = current.DescricaoContaBancaria;
                        }
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                LoggerUtilIts.ShowExceptionLogs(ex);
                XMessageIts.Advertencia("Conta bancária não encontrada!");
                buttonEdit1.Text = "";
                return;
            }
        }

        private void btnFindContaBancaria_Click(object sender, EventArgs e)
        {
            using (var ctx = new BalcaoContext())
            {
                var paramsFind = new ParamsFindEntity()
                {
                    Context = ctx,
                    Columns = new string[] { "CodigoContaBancaria", "Agencia", "NumeroConta", "DescricaoContaBancaria" },
                    Order = "CodigoContaBancaria",
                    Title = "Localizar conta bancária:",
                    DynamicObject = null
                };

                var selected = XFrmFindEntity.ShowDialogFindEntity<ContaBancaria>(paramsFind);

                if (selected != null)
                {
                    //recuperando os valores do objeto dinamico
                    //pego o tipo, dps a propriedade que quero, em seguida o valor
                    var id = selected.GetType().GetProperty("CodigoContaBancaria").GetValue(selected, null);

                    //seta os dados e indexa a filial
                    FindSetContaBancaria(id.ToString());
                }
            }
        }

        private void LookUpContaBancaria_Load(object sender, EventArgs e)
        {
            indexarCampos();
        }

        private void txtNumeroConta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                this.ContaBancaria = null;
                this.buttonEdit1.Text = "";
                findConta();

            }
        }

        private void txtNumeroConta_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtCodConta.Text))
                findConta();
        }

        private void findConta()
        {
            if (String.IsNullOrEmpty(txtCodConta.Text))
                btnFindContaBancaria_Click(null, null);
            else
                FindSetContaBancaria(txtCodConta.Text);
        }
    }
}