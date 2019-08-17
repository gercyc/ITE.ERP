using System;
using System.Linq;
using ITE.Entidades.DaoManager;
using ITE.Entidades.DaoManager.VendasDaoManager;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.UnitControl;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Financeiro.Forms.Wizard
{
    public partial class XFrmWizardCancelamentoVenda : DevExpress.XtraEditors.XtraForm
    {
        private readonly Venda _venda;

        public bool IsVendaCancel { get; private set; }

        public XFrmWizardCancelamentoVenda(Venda venda)
        {
            InitializeComponent();
            this._venda = venda;
            this.lblCliFor.Text = venda.CliFor.RazaoSocial;

            this.lblNumVenda.Text = this.lblNumVenda.Text + " " + venda.IdVenda;
            this.txtVlrVenda.Text = venda.TotalVenda.ToString("N2");
            chDataAtual_CheckedChanged(null, null);
            this.ActiveControl = this.txtMotivoCancelamento;

        }

        private void chEstorno_CheckedChanged(object sender, EventArgs e)
        {
            if (chEstorno.Checked)
            {
                var result = _venda.Parcelas
                    .Count(p => p.StatusLancamento == TypeStatusLancamentoFinanceiro.Pago);

                //se o result nao eh igual
                //existe parcela q nao foi paga
                if (_venda.Parcelas.Count != result)
                {
                    lblMsg.Visible = true;
                    lblVlrVenda.Visible = false;
                    txtVlrVenda.Visible = false;
                    wizardPage1.AllowNext = false;
                }
                else
                {
                    lblMsg.Visible = false;
                    lblVlrVenda.Visible = true;
                    txtVlrVenda.Visible = true;
                    wizardPage1.AllowNext = true;
                }
            }
            else
            {
                lblMsg.Visible = false;
                lblVlrVenda.Visible = false;
                txtVlrVenda.Visible = false;
                wizardPage1.AllowNext = true;
            }
        }

        private void wizardPage1_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            if (e.Direction == DevExpress.XtraWizard.Direction.Forward)
            {
                if (lblMsg.Visible)
                {
                    MessageBoxBlack.Show("Para continuar o processo desmarque a opção estorno.",
                        "Atenção");
                    e.Valid = true;
                }
                else
                {

                    var motivo = txtMotivoCancelamento.Text;
                    var msgs = "";
                    if (dtEditDataCancelamento.DateTime.ValidateDate() == null)
                    {
                        msgs = "Informe a data do cancelamento\n\n";
                        e.Valid = false;
                    }

                    if (string.IsNullOrEmpty(motivo))
                    {
                        msgs = "Informe o motivo do cancelamento";
                        e.Valid = false;
                    }

                    if (!string.IsNullOrEmpty(msgs))
                        XMessageIts.Mensagem(msgs);
                }
            }
        }

        private void wizardPage1_PageCommit(object sender, EventArgs e)
        {
            this.IsVendaCancel = new VendaDaoManager().CancelarVenda(_venda, UnitWork.Usuario,
                txtMotivoCancelamento.Text, dtEditDataCancelamento.DateTime,
                chEstorno.Checked);

            if (this.IsVendaCancel){
                this.completionWizardPage1.AllowBack = false;
                this.completionWizardPage1.AllowCancel = false;
            }

        }

        private void chDataAtual_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chDataAtual.Checked)
            {
                this.dtEditDataCancelamento.Enabled = false;
                this.dtEditDataCancelamento.DateTime = DateTime.Now;
            }
            else
            {
                this.dtEditDataCancelamento.Enabled = true;
                this.dtEditDataCancelamento.EditValue = null;
                this.dtEditDataCancelamento.Text = "";
                this.dtEditDataCancelamento.ShowPopup();
            }
        }

        private void wizardPage1_PageInit(object sender, EventArgs e)
        {
            this.txtMotivoCancelamento.Focus();
        }
    }
}