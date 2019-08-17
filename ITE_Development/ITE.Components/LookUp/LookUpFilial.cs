using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ITE.Entidades.POCO;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Forms;
using ITSolution.Framework.Beans.Forms;

namespace ITE.Components
{
    public partial class LookUpFilial : XtraUserControl
    {

        public EmpresaMatriz Matriz { get; set; }
        public EmpresaFilial Filial { get; set; }

        public void ReadOnlyMode(bool onOff = true)
        {
            if (onOff)
            {
                txtCodFilial.ReadOnly = true;
                buttonEdit1.ReadOnly = true;
                buttonEdit1.Enabled = false;
            }
            else
            {
                txtCodFilial.ReadOnly = false;
                buttonEdit1.ReadOnly = false;
                buttonEdit1.Enabled = false;
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

        public LookUpFilial()
        {
            InitializeComponent();
            this.ActiveControl = this.txtCodFilial;
            this.txtCodFilial.Focus();
        }


        public void FindSetFilial(EmpresaFilial filial)
        {
            FindSetFilial(filial.CodigoFilial);
        }

        private void indexarCampos()
        {
            if (this.Filial != null)
            {

                txtCodFilial.Text = this.Filial.CodigoFilial;
                buttonEdit1.Text = this.Filial.RazaoSocial;
            }
        }

        public void FindSetFilial(string codFilial)
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    txtCodFilial.Text = codFilial;
                    if (!string.IsNullOrEmpty(codFilial))
                    {
                        var filialFind = ctx.EmpresaFilialDao.Where(f => f.CodigoFilial == txtCodFilial.Text).FirstOrDefault();
                        this.Filial = filialFind;
                        this.Matriz = this.Filial.Matriz;
                        txtCodFilial.Text = filialFind.CodigoFilial.ToString();
                        buttonEdit1.Text = filialFind.RazaoSocial;
                    }
                }
                catch (NullReferenceException)
                {
                    XMessageIts.Advertencia("Filial não encontrada!");
                    buttonEdit1.Text = "";
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
                    Columns = new string[] { "Matriz.CodigoMatriz", "CodigoFilial", "RazaoSocial", "Uf" },
                    Title = "Localizar filial:",
                    Layout = GridViewUtil.GetLayoutStreamFromResource(Assembly.GetExecutingAssembly(),
            "ITE.Components.Resources.layout_matriz.xml"),
                };

                var selected = XFrmFindEntity.ShowDialogFindEntity<EmpresaFilial>(paramsFind);

                if (selected != null)
                {
                    //recuperando os valores do objeto dinamico
                    //pego o tipo, dps a propriedade que quero, em seguida o valor
                    var id = selected.GetType().GetProperty("CodigoFilial").GetValue(selected, null);
                    //var nome = selected.GetType().GetProperty("RazaoSocial").GetValue(selected, null);

                    //seta os dados e indexa a filial
                    FindSetFilial(id.ToString());
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
                    FindSetFilial(txtCodFilial.Text);
            }
        }

    }
}
