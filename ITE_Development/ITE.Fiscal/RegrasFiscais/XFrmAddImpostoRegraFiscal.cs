using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Util;
using ITE.Entidades.POCO.Fiscal;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.Enumeradores.RegraFiscalEnum;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.Beans.ProgressBar;

namespace ITE.Fiscal.RegrasFiscais
{
    public partial class XFrmAddImpostoRegraFiscal : DevExpress.XtraEditors.XtraForm
    {
        public ImpostosRegraFiscal ImpostoTpMov { get; set; }
        private FormTypeAction acao;

        private TipoImposto cacheImposto;
        private SituacaoTributaria cacheCst;

        public XFrmAddImpostoRegraFiscal()
        {
            InitializeComponent();
            cbTributacaoIcms.AddEnumValues(typeof(TypeTipoTributacaoICMS));
            cbTributacaoIpi.AddEnumValues(typeof(TypeTipoTributacaoIPI));
            cbTributacaoLivro.AddEnumValues(typeof(TypeTipoLancImposto));
            cbOperacaoICMS.AddEnumValues(typeof(TypeOperacaoTributariaICMS));
            FormsUtil.AddShortcutEscapeOnDispose(this);

        }

        public XFrmAddImpostoRegraFiscal(ImpostosRegraFiscal impostoTpMov, FormTypeAction acao) : this()
        {
            this.acao = acao;
            this.ImpostoTpMov = impostoTpMov;
            this.cacheImposto = impostoTpMov.TipoImposto;
            this.cacheCst = impostoTpMov.SituacaoTributaria;
            IndexarFormulario(impostoTpMov);
        }

        private ImpostosRegraFiscal IndexarImpostoTpMovimento()
        {
            var imposto = lkImposto.EditValue as TipoImposto;
            var cst = lkSituacaoTribut.EditValue as SituacaoTributaria;

            ImpostosRegraFiscal impostosTipoMovimento = new ImpostosRegraFiscal();

            impostosTipoMovimento.Aliquota = ParseUtil.ToDecimal(txtAliquota.Text);
            impostosTipoMovimento.IdCst = cst.IdCst;
            impostosTipoMovimento.SituacaoTributaria = cst;
            impostosTipoMovimento.IdImposto = imposto.IdImposto;
            impostosTipoMovimento.TipoImposto = imposto;
            impostosTipoMovimento.TipoLancImposto = cbTributacaoLivro.GetSelectedItem<TypeTipoLancImposto>();
            impostosTipoMovimento.TipoTributacaoICMS = cbTributacaoIcms.GetSelectedItem<TypeTipoTributacaoICMS>();
            impostosTipoMovimento.TipoTributacaoIPI = cbTributacaoIpi.GetSelectedItem<TypeTipoTributacaoIPI>();
            impostosTipoMovimento.OperacaoTributariaICMS = cbOperacaoICMS.GetSelectedItem<TypeOperacaoTributariaICMS>();
            impostosTipoMovimento.EnquadramentoIPI = txtEnquadIPI.Text;

            return impostosTipoMovimento;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.acao != FormTypeAction.Visualizar) //adicao
            {
                this.ImpostoTpMov = IndexarImpostoTpMovimento();
                this.Close();

            }
            else
            {
                this.ImpostoTpMov.Update(IndexarImpostoTpMovimento());
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void IndexarFormulario(ImpostosRegraFiscal imposto)
        {
            if (imposto != null)
            {
                txtAliquota.Text = imposto.Aliquota.ToString("n2");

                lkImposto.EditValue = cacheImposto;
                lkImposto.Text = imposto.TipoImposto.ToString();
                lkImposto.ResetText();

                lkSituacaoTribut.Properties.DataSource = cacheImposto.SituacaoTributaria;
                lkSituacaoTribut.EditValue = cacheCst;

                cbTributacaoLivro.SetSelectItem<TypeTipoLancImposto>(imposto.TipoLancImposto);
                cbTributacaoIcms.SetSelectItem<TypeTipoTributacaoICMS>(imposto.TipoTributacaoICMS);
                cbTributacaoIpi.SetSelectItem<TypeTipoTributacaoIPI>(imposto.TipoTributacaoIPI);
                cbOperacaoICMS.SetSelectItem<TypeOperacaoTributariaICMS>(imposto.OperacaoTributariaICMS);

                if(cacheImposto.CodigoImposto == "IPI")
                {
                    lbEnqIPI.Visible = true;
                    txtEnquadIPI.Visible = true;

                    txtEnquadIPI.Text = imposto.EnquadramentoIPI;
                }
            }

        }
        
        private async void XFrmAddImpostoTipoMovimento_Shown(object sender, EventArgs e)
        {

            bool result = await XFrmWait.StartTask<bool>(CarregarImpostos(), "Carregando impostos", this);

            if (result)
            {
                if (this.ImpostoTpMov != null)
                    IndexarFormulario(this.ImpostoTpMov);
            }
        }
        private async Task<bool> CarregarImpostos()
        {
            var ctx = new BalcaoContext();

            var impostos = await ctx.TipoImpostoDao.FindAllAsync();

            this.Invoke(new MethodInvoker(delegate
            {
                lkImposto.Properties.DataSource = impostos;
            }));

            return true;
        }

        private void lkImposto_EditValueChanged(object sender, EventArgs e)
        {
            var imposto = lkImposto.EditValue as TipoImposto;

            if (imposto != null)
            {
                lkSituacaoTribut.Properties.DataSource = imposto.SituacaoTributaria.ToList();

                if (imposto.CodigoImposto == "IPI")
                {
                    lbEnqIPI.Visible = true;
                    txtEnquadIPI.Visible = true;
                }
            }
        }
    }
}