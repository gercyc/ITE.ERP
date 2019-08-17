using System;
using ITE.Entidades.POCO.Contabil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.POCO.Fiscal;

namespace ITE.Vendas.Forms.Administrativo
{
    public partial class XFrmSetCentroVenda : DevExpress.XtraEditors.XtraForm
    {
        public CentroCusto Centro { get; private set; }
        public LocalEstoque LocalEstoque { get; private set; }

        public XFrmSetCentroVenda(CentroCusto cc)
        {
            InitializeComponent();
            this.Centro = cc;
            this.lookUpCentroCusto1.CentroCusto = Centro;

            FormsUtil.AddShortcutEscapeOnDispose(this);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Centro = lookUpCentroCusto1.CentroCusto;
            this.LocalEstoque = lookUpLocalEstoque1.LocalEstoque;

            if (Centro == null || LocalEstoque == null)
                XMessageIts.Advertencia("Centro de custo ou Local de Estoque não foram informado!");
            else
                this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}