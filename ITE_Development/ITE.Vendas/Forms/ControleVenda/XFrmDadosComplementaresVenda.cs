using ITE.Entidades.POCO.Sales;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Util;
using System;
using System.Windows.Forms;

namespace ITE.Vendas.Forms.ControleVenda
{
    public partial class XFrmDadosComplementaresVenda : DevExpress.XtraEditors.XtraForm
    {
        private Venda venda;
        public XFrmDadosComplementaresVenda(Venda v)
        {
            InitializeComponent();
            this.venda = v;

            this.deDataVenda.DateTime = this.venda.DataVenda;
            FormsUtil.AddShortcutEscapeOnDispose(this);
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            //var d = deDataVenda.DateTime.Day;
            //var m = deDataVenda.DateTime.Month;
            //var y = deDataVenda.DateTime.Year;

            if (deDataVenda.DateTime.ValidateDate() != null)
                this.venda.DataVenda = deDataVenda.DateTime;
            else
                this.venda.DataVenda = DateTime.Now;
            this.Dispose();
            //ver o restante dps
            
        }

        private void XFrmDadosComplementaresVenda_Shown(object sender, EventArgs e)
        {
            this.deDataVenda.ShowPopup();
        }

        private void XFrmDadosComplementaresVenda_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Enter)
                btnOk_Click(null, null);
        }
    }
}