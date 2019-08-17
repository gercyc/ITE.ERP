using System;
using System.Linq;
using System.Windows.Forms;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.Repositorio;
using ITE.Entidades.POCO;
using ITSolution.Framework.Beans.Forms;
using DevExpress.XtraEditors;
using ITSolution.Framework.GuiUtil;
using System.Reflection;
using ITSolution.Framework.Forms;

namespace ITE.Components
{
    public partial class LookUpMatriz : XtraUserControl
    {

        public EmpresaMatriz Matriz { get; set; }
        public EmpresaFilial Filial { get; set; }
        public TextEdit TextCodigoMatriz { get { return this.txtCodFilial; } }

        public void ReadyOnlyMode(bool onOff = true)
        {
            if (onOff)
            {
                txtCodFilial.ReadOnly = true;
                txtNomeFilial.ReadOnly = true;
                btnFindFilial.Enabled = false;
            }
            else
            {
                txtCodFilial.ReadOnly = false;
                txtNomeFilial.ReadOnly = false;
                btnFindFilial.Enabled = true;
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

        public LookUpMatriz()
        {
            InitializeComponent();
            this.ActiveControl = this.txtCodFilial;
            this.txtCodFilial.Focus();
        }


        public void FindSetMatriz(EmpresaMatriz matriz)
        {
            FindSetMatriz(matriz.CodigoMatriz);
        }

        private void indexarCampos()
        {
            if (this.Filial != null)
            {

                txtCodFilial.Text = this.Filial.CodigoFilial;
                txtNomeFilial.Text = this.Filial.RazaoSocial;
            }
        }

        public void FindSetMatriz(string codMatriz)
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    txtCodFilial.Text = codMatriz;
                    if (!string.IsNullOrEmpty(codMatriz))
                    {
                        var matrizFind = ctx.EmpresaMatrizDao.Where(f => f.CodigoMatriz == txtCodFilial.Text).FirstOrDefault();
                        this.Matriz = matrizFind;
                        txtCodFilial.Text = matrizFind.CodigoMatriz.ToString();
                        txtNomeFilial.Text = matrizFind.RazaoSocial;
                    }
                }
                catch (NullReferenceException)
                {
                    XMessageIts.Advertencia("Matriz não encontrada!");
                    txtNomeFilial.Text = "";
                    return;
                }
            }
        }

        private void btnFindFilial_Click(object sender, EventArgs e)
        {
            using (var ctx = new BalcaoContext())
            {
                var paramsFind = new ParamsFindEntity()
                {
                    Context = ctx,
                    Title = "Localizar Matriz:",
                    Columns = new string[] { "CodigoMatriz", "RazaoSocial", "Cnpj", "Uf" },
                    Layout = GridViewUtil.GetLayoutStreamFromResource(Assembly.GetExecutingAssembly(),
                                        "ITE.Components.Resources.layout_matriz.xml")

                };

                var selected = XFrmFindEntity.ShowDialogFindEntity<EmpresaMatriz>(paramsFind);

                if (selected != null)
                {
                    //recuperando os valores do objeto dinamico
                    //pego o tipo, dps a propriedade que quero, em seguida o valor
                    var id = selected.GetType().GetProperty("CodigoMatriz").GetValue(selected, null);
                    //var nome = selected.GetType().GetProperty("RazaoSocial").GetValue(selected, null);

                    //seta os dados e indexa a filial
                    FindSetMatriz(id.ToString());
                }
            }
        }

        private void LookUpMatrizFilial_Load(object sender, EventArgs e)
        {
            indexarCampos();
        }

        private void txtCodFilial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(txtCodFilial.Text))
                    btnFindFilial_Click(null, null);
                else
                    FindSetMatriz(txtCodFilial.Text);
            }
        }

    }
}
