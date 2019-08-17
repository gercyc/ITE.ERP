using System;
using System.ComponentModel;
using ITE.Entidades.POCO.Contabil;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Enumeradores;
using ITE.Entidades.Enumeradores.ContabilEnums;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.DaoManager.ContabilDaoManager;
using ITSolution.Framework.Util;

namespace ITE.Contabil.Forms.View
{
    public partial class XFrmAddContaContabil : DevExpress.XtraEditors.XtraForm
    {
        private ContaContabil _currentConta;
        FormTypeAction _actionForm;

        public XFrmAddContaContabil()
        {
            InitializeComponent();
            btnEditar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            FormsUtil.AddShortcutEscapeOnDispose(this);
        }

        //edição
        public XFrmAddContaContabil(ContaContabil cct, FormTypeAction actionForm) : this()
        {
            this._currentConta = cct;
            this._actionForm = actionForm;
            this.Text = "Conta contábil: " + cct.CodigoContaContabil + " - " + cct.DescricaoContaContabil;
            btnEditar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            IndexarCampos(cct);
            desativarComponents();
        }
        private void IndexarCampos(ContaContabil cct)
        {
            var conta = cct.CodigoContaContabil;
            if (cct.CodigoContaContabil.EndsWith("."))
                conta = conta.Remove(conta.Length - 1);
            if (cct.CodigoContaContabil.EndsWith("."))
                conta = conta.Remove(conta.Length - 1);

            conta = conta.Replace("_", "");

            lookUpMatriz1.FindSetMatriz(cct.Matriz);
            txtCodConta.Text = conta;
            txtCodReduzido.Text = cct.CodigoReduzido;
            txtDescConta.Text = cct.DescricaoContaContabil;
            rdNatureza.SelectedIndex = (int)cct.Natureza;
            rdSintAnalitica.SelectedIndex = (int)cct.IndAnaliticaSintetica;
            rdTipoSped.SelectedIndex = (int)cct.TipoContaSped - 1;
        }
        private Component[] getComponents()
        {
            return new Component[] { txtCodConta, txtCodReduzido, txtDescConta, rdNatureza, rdSintAnalitica, rdTipoSped };
        }
        private void desativarComponents()
        {
            ComponenteUtil.DesabilitarComponentes(getComponents());
            lookUpMatriz1.ReadyOnlyMode(true);
        }
        private void ativarComponents()
        {
            ComponenteUtil.HabilitarComponentes(getComponents());
            lookUpMatriz1.ReadyOnlyMode(false);
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ativarComponents();
            btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }

        private void btnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var conta = indexarConta();
            var manager = new ContaContabilDaoManager();

            if (_actionForm == FormTypeAction.Alterar)
            {
                if(manager.UpdateContaContabil(conta, _currentConta))
                {
                    desativarComponents();//desativa tudo
                    btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; //oculta o salvar de novo...
                }
            }
            else
            {
                if (manager.SaveContaContabil(conta))
                {
                    this.Dispose();
                }
            }
        }
        private ContaContabil indexarConta()
        {
            if (lookUpMatriz1.Matriz != null)
            {
                var conta = txtCodConta.Text;

                conta = conta.Replace("_", "");

                if (conta.EndsWith("."))
                    conta = conta.Remove(conta.Length - 1);
                if (conta.EndsWith("."))
                    conta = conta.Remove(conta.Length - 1);

                txtCodConta.Text = conta;

                ContaContabil cctNew = new ContaContabil();

                cctNew.IdMatriz = (int)lookUpMatriz1.Matriz?.IdMatriz; //operador condicional nulo, C# 6
                cctNew.Matriz = lookUpMatriz1.Matriz;
                cctNew.IndAnaliticaSintetica = (TypeAnaliticaSintetica)rdSintAnalitica.SelectedIndex;
                cctNew.Natureza = (TypeNaturezaConta)rdNatureza.SelectedIndex;
                cctNew.TipoContaSped = (TypeTipoContaSped)rdTipoSped.SelectedIndex + 1;
                cctNew.CodigoContaContabil = conta;
                cctNew.CodigoReduzido = txtCodReduzido.Text;
                cctNew.DataInclusao = DateTime.Now;
                cctNew.DescricaoContaContabil = txtDescConta.Text;

                return cctNew;
            }
            else
            {
                XMessageIts.Advertencia("Selecione a matriz!");
            }
            return null;
        }

        private void txtCodConta_Leave(object sender, EventArgs e)
        {
            var codigo = txtCodConta.Text;
            string reduzido;

            if (codigo.Length == 14)
            {
                var nivelFinal = codigo.Split('.')[4].ToString().Replace(".","");
                reduzido = codigo.Substring(0, 9);
                reduzido = reduzido.Replace(".", "") + ParseUtil.ToInt(nivelFinal).ToString();
                txtCodReduzido.Text = reduzido;
            }

            if (codigo.EndsWith("."))
                codigo = codigo.Substring(codigo.Length, 1);

            txtCodConta.Text = codigo;

        }
    }
}