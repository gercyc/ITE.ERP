using System;
using System.Windows.Forms;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.Repositorio;
using ITE.Entidades.POCO;
using ITSolution.Framework.Beans.Forms;
using ITE.Entidades.DaoManager;
using DevExpress.XtraEditors;
using System.Reflection;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Forms;

namespace ITE.Components
{
    public partial class LookUpMatrizFilial : XtraUserControl
    {
        public EmpresaMatriz Matriz { get; set; }

        public EmpresaFilial Filial { get; set; }

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

        public void ReadyOnlyMode(bool onOff = true)
        {
            if (onOff)
            {
                txtCodFilial.ReadOnly = true; ;
                txtNomeFilial.ReadOnly = true;

                txtCodMatriz.ReadOnly = true;
                txtNomeMatriz.ReadOnly = true;

                btnFindFilial.Enabled = false;
                btnFindMatriz.Enabled = false;
            }
            else
            {
                txtCodFilial.ReadOnly = false;
                txtNomeFilial.ReadOnly = false;

                txtCodMatriz.ReadOnly = false;
                txtNomeMatriz.ReadOnly = false;

                btnFindFilial.Enabled = true;
                btnFindMatriz.Enabled = true;
            }
        }


        public LookUpMatrizFilial()
        {
            InitializeComponent();
            //foco inicial
            this.ActiveControl = txtCodMatriz;
            this.txtCodMatriz.Focus();
        }

        public void FocusCodigoMatriz()
        {
            this.txtCodMatriz.Focus();
        }

        public void FindSetMatrizFilial(EmpresaMatriz matriz, EmpresaFilial filial)
        {
            FindSetMatriz(matriz.CodigoMatriz);
            FindSetFilial(filial.CodigoFilial);
        }

        private void indexarCampos()
        {
            if (this.Filial != null)
            {
                txtCodMatriz.Text = this.Filial.Matriz.CodigoMatriz;
                txtNomeMatriz.Text = this.Filial.Matriz.RazaoSocial;

                txtCodFilial.Text = this.Filial.CodigoFilial;
                txtNomeFilial.Text = this.Filial.RazaoSocial;
            }
        }

        public void FindSetMatriz(string codMatriz)
        {
            if (!String.IsNullOrEmpty(codMatriz))
            {

                EmpresaMatriz matrizFind = new EmpresaDaoManager().FindMatrizByCodigo(codMatriz);

                if (matrizFind != null)
                {
                    this.Matriz = matrizFind;
                    txtCodMatriz.Text = matrizFind.CodigoMatriz;
                    txtNomeMatriz.Text = matrizFind.RazaoSocial;
                    txtCodFilial.Focus();
                }
                else
                {
                    Console.WriteLine("Matriz nao localizada " + codMatriz);
                    XMessageIts.Advertencia("Matriz \"" + codMatriz + "\" não encontrada!");
                    txtCodMatriz.Text = "";
                    txtNomeMatriz.Text = "";
                }
            }
        }

        public void FindSetFilial(string codFilial)
        {
            if (!String.IsNullOrEmpty(codFilial))
            {
                EmpresaFilial filialFind = new EmpresaDaoManager().FindFilialByCodigo(codFilial);

                if (filialFind != null)
                {
                    this.Filial = filialFind;
                    txtCodFilial.Text = filialFind.CodigoFilial.ToString();
                    txtNomeFilial.Text = filialFind.RazaoSocial;
                }
                else
                {
                    Console.WriteLine("Filial nao localizada " + codFilial);
                    XMessageIts.Advertencia("Filial \"" + codFilial + "\" não encontrada!");
                    txtCodFilial.Text = "";
                    txtNomeFilial.Text = "";

                }
            }
        }

        private void btnFindMatriz_Click(object sender, EventArgs e)
        {

            using (var ctx = new BalcaoContext())
            {
                var paramsFind = new ParamsFindEntity()
                {
                    Context = ctx,
                    Title = "Localizar Matriz:",
                    Columns = new string[] { "CodigoMatriz", "RazaoSocial", "Cidade", "Uf" },
                    DynamicObject = null,
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

                    //seta os dados e indexa a matriz
                    FindSetMatriz(id.ToString());
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
                    Title = "Localizar Filial:",
                    Columns = new string[] { "Matriz.CodigoMatriz", "CodigoFilial", "RazaoSocial", "Cidade", "Uf" },
                    Order = "",
                    DynamicObject = null,
                    WhereCondition = "Matriz.CodigoMatriz = " + "\"" + txtCodMatriz.Text + "\"",
                    Layout = GridViewUtil.GetLayoutStreamFromResource(Assembly.GetExecutingAssembly(),
                                 "ITE.Components.Resources.layout_filial.xml")
                };

                var selected = XFrmFindEntity.ShowDialogFindEntity<EmpresaFilial>(paramsFind);

                if (selected != null)
                {
                    //recuperando os valores do objeto dinamico
                    //pego o tipo, dps a propriedade que quero, em seguida o valor
                    var id = selected.GetType().GetProperty("CodigoFilial").GetValue(selected, null);
                    var nome = selected.GetType().GetProperty("RazaoSocial").GetValue(selected, null);

                    //seta os dados e indexa a filial
                    FindSetFilial(id.ToString());
                }
            }
        }

        private void LookUpMatrizFilial_Load(object sender, EventArgs e)
        {
            indexarCampos();
        }

        private void txtCodMatriz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(txtCodMatriz.Text))
                    btnFindMatriz_Click(null, null);
                else
                    FindSetMatriz(txtCodMatriz.Text);

            }
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
