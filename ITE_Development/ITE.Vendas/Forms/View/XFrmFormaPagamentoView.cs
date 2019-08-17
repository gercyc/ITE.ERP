using ITSolution.Framework.Util;
using ITE.Entidades.Enumeradores;
using System;
using ITE.Entidades.DaoManager.VendasDaoManager;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.POCO.Sales;

namespace ITE.Vendas.Forms.View
{
    public partial class XFrmFormaPagamentoView : DevExpress.XtraEditors.XtraForm
    {
        public FormaPagamento FormaPagamento { get; private set; }

        public bool IsSave { get; internal set; }

        public XFrmFormaPagamentoView()
        {
            InitializeComponent();
            this.IsSave = false;

            cbTipoFormaPagto.AddEnumValues(typeof(TypeFormaPagamento));

        }

        public XFrmFormaPagamentoView(FormaPagamento frmPagamento)
           : this()
        {
            this.FormaPagamento = indexarDados(frmPagamento);
        }

        private FormaPagamento indexarDados(FormaPagamento frmPagamento)
        {
            txtNumParcelas.Text = frmPagamento.NumeroParcelas.ToString();
            txtDescFormaPagamento.Text = frmPagamento.NomeFormaPagamento;
            cbTipoFormaPagto.SelectedItem = frmPagamento.TipoFormaPagamento;

            return frmPagamento;
        }

        private FormaPagamento indexarDados()
        {

            var descricao = txtDescFormaPagamento.Text;
            var numParcelas = ParseUtil.ToInt(txtNumParcelas.Text);
            //forma de pagamento indexada a partir do "1"
            var tipo = cbTipoFormaPagto.SelectedIndex + 1;

            var novo = new FormaPagamento(descricao, (TypeFormaPagamento)tipo, numParcelas);

            if (FormaPagamento != null)
                novo.IdFormaPagamento = FormaPagamento.IdFormaPagamento;

            return novo;
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            var novo = indexarDados();
            if (new FormaPagamentoDaoManager().SaveUpdate(novo))
            {
                //atualiza no grid
                if(FormaPagamento!=null)
                    this.FormaPagamento.Update(novo);

                this.IsSave = true;
                //libera a memoria do objeto
                this.Dispose();
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
