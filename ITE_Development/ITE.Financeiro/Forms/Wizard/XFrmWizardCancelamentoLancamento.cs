using System;
using System.Collections.Generic;
using ITE.Entidades.DaoManager.FinanceiroDaoManager;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.POCO.Financeiro;
using ITSolution.Framework.Util;

namespace ITE.Financeiro.Forms.Wizard
{
    public partial class XFrmWizardCancelamentoLancamento : DevExpress.XtraEditors.XtraForm
    {
        private readonly List<LancamentoFinanceiro> _lancamentos;
        public bool IsBaixa { get; private set; }

        public XFrmWizardCancelamentoLancamento()
        {
            InitializeComponent();
            this.IsBaixa = false;
            chDataAtual_CheckedChanged(null, null);

            this.ActiveControl = memoMotivoCancel;
        }

        public XFrmWizardCancelamentoLancamento(List<LancamentoFinanceiro> lancamentosBaixa) : this()
        {
            this._lancamentos = lancamentosBaixa;
            this.gridControlLancBaixa.DataSource = lancamentosBaixa;
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

        #region Wizard
        /// <summary>
        /// Ocorre quando clica no Finish
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void completionWizardPage1_PageCommit(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void wizardPage1_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            if (e.Direction == DevExpress.XtraWizard.Direction.Forward)
            {
                if (string.IsNullOrEmpty(memoMotivoCancel.Text))
                {
                    XMessageIts.Advertencia("Informe o motivo do cancelamento !");
                    //cancele o evento
                    e.Valid = false;

                }
                else if (dtEditDataCancelamento.DateTime.ValidateDate() == null)
                {
                    //cancele o evento
                    e.Valid = false;
                    XMessageIts.Advertencia("Informe a data para baixa do(s) lançamento(s) !!!");

                }
            }
        }

        private void wizardPage1_PageCommit(object sender, EventArgs e)
        {
            // O lancamento tera seu status apenas alterado pra cancelado
            var manager = new LancamentoDaoManager();
            foreach (var l in _lancamentos)
            {
                l.MotivoCancelamento = memoMotivoCancel.Text;
                l.DataCancelamento = dtEditDataCancelamento.DateTime;

                manager.CancelarLancamento(l);

                l.StatusLancamento = Entidades.Enumeradores.TypeStatusLancamentoFinanceiro.Cancelado;
            }
        }
        #endregion

        private void wizardPage1_PageInit(object sender, EventArgs e)
        {

            memoMotivoCancel.Focus();
        }
    }
}