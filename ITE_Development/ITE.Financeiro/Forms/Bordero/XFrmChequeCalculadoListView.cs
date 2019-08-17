using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITE.Entidades.POCO.Bordero;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;

namespace ITE.Bordero.Forms.Calculator
{
    public partial class XFrmChequeCalculadoView : DevExpress.XtraEditors.XtraForm
    {
        public XFrmChequeCalculadoView()
        {
            InitializeComponent();
            this.panelSum1.AddSomatorio(gridControl1, gridView1);
            FormsUtil.AddShortcutEscapeOnDispose(this);
            barBtnAtualizar_ItemClick(null, null);
        }


        public XFrmChequeCalculadoView(List<Cheque> cheques)
        {
            InitializeComponent();
            this.panelSum1.AddSomatorio(gridControl1, gridView1);
            this.gridControl1.DataSource = cheques;
            this.lblTotalJuros.Text = "R$ " + cheques.Sum(ch => ch.ValorJuros).ToString("N2");
            this.lblTotalLiquido.Text = "R$ " + cheques.Sum(ch => ch.ValorLiquido).ToString("N2");
            this.colCliente.Visible = false;
        }

        private void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var source = gridView1.GetItens<Cheque>();
            gridControl1.DataSource = source;
            this.gridControl1.DataSource = source;
            this.lblTotalJuros.Text = "R$ " + source.Sum(ch => ch.ValorJuros).ToString("N2");
            this.lblTotalLiquido.Text = "R$ " + source.Sum(ch => ch.ValorLiquido).ToString("N2");
        }

        private void barBtnVoltar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void bartBtnRemoveCh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.IsSelectOneRowWarning())
            {
                var row = gridView1.GetFocusedRow<Cheque>();
                var sb = new StringBuilder();

                sb.Append("Confirmação a remoção do cheque:\n\n");
                sb.Append("Número cheque: ");
                sb.Append(row.NumeroCheque);
                sb.Append("\n");
                sb.Append("Valor cheque: ");
                sb.Append(row.ValorCheque);

                var op = XMessageIts.Confirmacao(sb);

                if (op == System.Windows.Forms.DialogResult.Yes)
                {
                    gridView1.DeleteSelectedRows();
                    barBtnAtualizar_ItemClick(null, null);
                }
            }
        }
    }
}