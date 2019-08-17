using System;
using System.Windows.Forms;
using ITE.Entidades.POCO.Ardosia.Minning;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Util;

namespace ITE.Slate.Forms.ControleCarga.View
{
    public partial class XFrmComplementoOrdemCarga : DevExpress.XtraEditors.XtraForm
    {
        private OrdemCarga _ordem;
        public XFrmComplementoOrdemCarga(OrdemCarga v)
        {
            InitializeComponent();
            this._ordem = v;

            this.deDataVenda.DateTime = this._ordem.DataCarregamento;
            FormsUtil.AddShortcutEscapeOnDispose(this);
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            //var d = deDataVenda.DateTime.Day;
            //var m = deDataVenda.DateTime.Month;
            //var y = deDataVenda.DateTime.Year;

            if (deDataVenda.DateTime.ValidateDate() != null)
                this._ordem.DataCarregamento = deDataVenda.DateTime;
            else
                this._ordem.DataCarregamento = DateTime.Now;
            this.Dispose();
            //ver o restante dps
            
        }

        private void XFrmComplementoOrdemCarga_Shown(object sender, EventArgs e)
        {
            this.deDataVenda.ShowPopup();
        }

        private void XFrmComplementoOrdemCarga_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Enter)
                btnOk_Click(null, null);
        }
    }
}