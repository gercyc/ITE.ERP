using System.Linq;
using ITE.Entidades.POCO.Ardosia.Minning;
using ITSolution.Framework.GuiUtil;

namespace ITE.Slate.Forms.ControleCarga.View
{
    public partial class XFrmDetalhesOrdemCarga : DevExpress.XtraEditors.XtraForm
    {

        private XFrmDetalhesOrdemCarga()
        {
            InitializeComponent();
            FormsUtil.AddShortcutEscapeOnDispose(this);
        }

        public XFrmDetalhesOrdemCarga(OrdemCarga ordem) : this()
        {
            indexarFormulario(ordem);
        }
        private void indexarFormulario(OrdemCarga v)
        {
            if (v != null)
            {
                txtNumOrdemCarga.Text = v.IdOrdemCarga.ToString();
                lblCodigo.Text = "Código: " + v.IdCliFor.ToString();
                lblCliente.Text = v.Cliente.RazaoSocial;
                txtVlrDesconto.Text = v.ValorDesconto.ToString("n2");
                txtVlrTotal.Text = v.TotalCarga.ToString("n2");
                txtDataOrdemCarga.Text = v.DataCarregamento.Date.ToString("dd/MM/yyyy HH:MM");
                gridControlProdutos.DataSource = v.ItensOrdemCarga.ToList();
                txtObs.Text = v.Observacao;
                txtMotorista.Text = v.Motorista.NomeMotorista;
            }
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void XFrmDetalhamentoOrdemCarga_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
        }

    }
}