using System.Linq;
using ITE.Entidades.POCO;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.POCO.Sales;

namespace ITE.Vendas.Forms.ControleVenda
{
    public partial class XFrmDetalhesVenda : DevExpress.XtraEditors.XtraForm
    {

        private XFrmDetalhesVenda()
        {
            InitializeComponent();
            FormsUtil.AddShortcutEscapeOnDispose(this);
        }

        public XFrmDetalhesVenda(Venda v) : this()
        {
            indexarFormulario(v);
        }
        private void indexarFormulario(Venda v)
        {
            if (v != null)
            {
                txtNumVenda.Text = v.IdVenda.ToString();
                lblCodigo.Text = "Código: " + v.IdCliForVenda.ToString();
                lblCliente.Text = v.CliFor.RazaoSocial.ToString();
                txtPercDesconto.Text = v.Desconto.ToString("n2");
                txtVlrDesconto.Text = v.ValorDesconto.ToString("n2");
                txtVlrTotal.Text = v.TotalVenda.ToString("n2");
                lblMatrizFilial.Text = "Matriz: Filial: " + v.FilialVenda.Matriz.CodigoMatriz
                                                 + " / " + v.FilialVenda.CodigoFilial;
                txtDataVenda.Text = v.DataVenda.Date.ToString("dd/MM/yyyy HH:MM");
                gridControlProdutos.DataSource = v.ItensVendas.ToList();
                gridControlParcelas.DataSource = v.Parcelas.ToList();
                txtFormaPagto.Text = v.FormaPagamentoVenda.ToString();
                txtNumParcelas.Text = v.NumeroParcelas.ToString();
                txtStatus.Text = v.StatusVenda.ToString();
                if (v.Parcelas.Count > 0)
                    txtPrazo.Text = v.Parcelas.LastOrDefault().DiasPrazo.ToString();
                this.lblCliente.Text = v.CliFor.RazaoSocial.ToString();
                txtObs.Text = v.Observacao;
            }
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void XFrmDetalhamentoVenda_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
        }

    }
}