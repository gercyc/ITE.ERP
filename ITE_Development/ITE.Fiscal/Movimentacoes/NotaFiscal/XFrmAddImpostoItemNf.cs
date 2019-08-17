using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.ProgressBar;
using System.Threading;
using ITSolution.Framework.Util;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.POCO.Fiscal;
using ITSolution.Framework.Enumeradores;

namespace ITE.Fiscal.Movimentacoes.NotaFiscal
{
    public partial class XFrmAddImpostoItemNf : DevExpress.XtraEditors.XtraForm
    {
        private ImpostoItemMovimento impostoEdit;
        private XFrmAddItemNF_OLD xFrmAddItemNF_DEV;
        private Decimal baseCalculo;
        private FormTypeAction acao;

        #region Construtores
        public XFrmAddImpostoItemNf()
        {
            InitializeComponent();
            new TextEditUtil(txtAliquota).CustomizeNumberField();
            new TextEditUtil(txtBaseCalculo).CustomizeNumberField();
            new TextEditUtil(txtVlrImposto).CustomizeNumberField();
        }

        public XFrmAddImpostoItemNf(XFrmAddItemNF_OLD xFrmAddItemNF_DEV, Decimal baseCalculoItem) : this()
        {
            this.xFrmAddItemNF_DEV = xFrmAddItemNF_DEV;
            this.baseCalculo = baseCalculoItem;
        }

        public XFrmAddImpostoItemNf(ImpostoItemMovimento imposto, FormTypeAction acao) : this()
        {
            this.acao = acao; //Alterar
            this.impostoEdit = imposto;
            IndexarFormulario();
        }

        #endregion

        #region Eventos
        private async void XFrmAddImpostoItemNf_Shown(object sender, EventArgs e)
        {
            //carregando produtos
            var result1 = await XFrmWait.StartTask<bool>(carregarDados(), "Carregando informações",this);

            if (result1)
            {
                //txtBaseCalculo.Text = baseCalculo.ToString("n2");
                IndexarFormulario();
            }
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(acao == FormTypeAction.Alterar)//edição
            {
                impostoEdit.Update(indexarImposto());
            }
            else//Adicao de imposto
            {
                xFrmAddItemNF_DEV.impostosItem.Add(indexarImposto());
            }
            
            this.Close();
        }
        
        private void cbImposto_SelectedValueChanged(object sender, EventArgs e)
        {
            var impostoSelect = cbImposto.SelectedItem as TipoImposto;
            if (impostoSelect != null)
            {
                cbSitTribut.Properties.Items.AddRange(impostoSelect.SituacaoTributaria.ToList());
                lkSitTribut.Properties.DataSource = impostoSelect.SituacaoTributaria.ToList();
            }
        }
        
        private void txtAliquota_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            txtVlrImposto.Text = calculaVlrImposto().ToString("N2");
        }
        //carregar csts de acordo com imposto selecionado
        private void lkImposto_EditValueChanged(object sender, EventArgs e)
        {
            var impostoSelect = lkImposto.EditValue as TipoImposto;
            if (impostoSelect != null)
            {
                lkSitTribut.Properties.DataSource = impostoSelect.SituacaoTributaria.ToList();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        #region Metodos
        
        public void IndexarFormulario()
        {
            if(impostoEdit != null)
            {
                lkImposto.EditValue = impostoEdit.TipoImposto;
                lkImposto.Text = impostoEdit.TipoImposto.ToString();

                lkSitTribut.EditValue = impostoEdit.SituacaoTributaria;
                lkSitTribut.Text = impostoEdit.SituacaoTributaria.ToString();

                switch (ParseUtil.ToInt(impostoEdit.TpSitImposto))
                {
                    case 1:
                        cbTributacao.SelectedIndex = 0;
                        break;
                    case 2:
                        cbTributacao.SelectedIndex = 1;
                        break;
                    case 3:
                        cbTributacao.SelectedIndex = 2;
                        break;
                    default:
                        break;
                }

                txtAliquota.Text = impostoEdit.Aliquota.ToString();
                txtBaseCalculo.Text = impostoEdit.BaseCalculo.ToString();
                txtVlrImposto.Text = impostoEdit.ValorImposto.ToString();
            }
        }

        //indexar UM Imposto que vai compor o item
        private ImpostoItemMovimento indexarImposto()
        {
            var impostoItem = new ImpostoItemMovimento();
            var impSelect = lkImposto.EditValue as TipoImposto;
            var cstSelect = lkSitTribut.EditValue as SituacaoTributaria;
            var tributacao = cbTributacao.Text.Substring(0, 1);

            impostoItem.TipoImposto = impSelect;
            impostoItem.SituacaoTributaria = cstSelect;
            impostoItem.IdImposto = impSelect.IdImposto;
            impostoItem.IdCst = cstSelect.IdCst;
            //impostoItem.TpSitImposto = tributacao;
            impostoItem.BaseCalculo = ParseUtil.ToDecimal(txtBaseCalculo.Text);
            impostoItem.Aliquota = ParseUtil.ToDecimal(txtAliquota.Text);
            impostoItem.ValorImposto = ParseUtil.ToDecimal(txtVlrImposto.Text);

            return impostoItem;
        }
        private Decimal calculaVlrImposto()
        {
            var BaseCalculo = ParseUtil.ToDecimal(txtBaseCalculo.Text);
            var Aliquota = ParseUtil.ToDecimal(txtAliquota.Text);
            return (BaseCalculo * Aliquota) / 100;
        }
        
        private async Task<bool> carregarDados()
        {
            
                var ctx = new BalcaoContext();
                var impostos = await ctx.TipoImpostoDao.FindAllAsync();
                this.Invoke(new MethodInvoker(delegate
                {
                    cbImposto.Properties.Items.AddRange(impostos);
                    lkImposto.Properties.DataSource = impostos;
                }));
                return true;
        }

        #endregion

    }
}