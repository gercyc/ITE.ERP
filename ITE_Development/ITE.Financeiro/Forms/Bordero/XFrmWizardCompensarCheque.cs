using System;
using System.Collections.Generic;
using System.Linq;
using ITE.Entidades.DaoManager.BorderoManager;
using ITE.Entidades.DaoManager.FinanceiroDaoManager;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Financeiro.Forms.Bordero
{
    public partial class XFrmWizardCompensarCheque : DevExpress.XtraEditors.XtraForm
    {
        public bool IsCompensado { get; private set; }

        public XFrmWizardCompensarCheque()
        {
            InitializeComponent();

            //tenta recuperar a conta padrão
            ContaBancaria conta = new ContaBancariaDaoManager().GetContaDefault();
            if (conta != null)
                this.lookUpContaBancaria1.FindSetContaBancaria(conta.CodigoContaBancaria);

            chDataAtual_CheckedChanged(null, null);
            this.ActiveControl = this.dtEditDataBaixa;
            this.dtEditDataBaixa.Focus();

        }

        public XFrmWizardCompensarCheque(List<LancamentoFinanceiro> lancamentosBaixa) : this()
        {
            this.gridControlLancBaixa.DataSource = lancamentosBaixa;
            using (var ctx = new BalcaoContext())
            {
                var formas = ctx.FormaPagamentoDao.FindAll();

                bool isSelect = false;

                for (int i = 0; i < lancamentosBaixa.Count; i++)
                {
                    //selecione somente as parcelas vencidas
                    if (lancamentosBaixa[i].StatusLancamento == Entidades.Enumeradores.TypeStatusLancamentoFinanceiro.Vencido)
                    {
                        gridViewLancsBaixa.SelectRow(i);
                        isSelect = true;
                    }
                }

                if (isSelect == false)
                    gridViewLancsBaixa.SelectAllRow();

                refreshTotal();
            }
           
        }

        private void refreshTotal()
        {
            var lanctos = gridViewLancsBaixa.GetSelectedItens<LancamentoFinanceiro>();
            if(lanctos!=null)
                txtTotalLancamentos.Text = lanctos.Sum(l => l.ValorLancamento + l.ValorJuros).ToString("N2");
        }

        private bool baixar()
        {
            var lanctos = this.gridViewLancsBaixa.GetSelectedItens<LancamentoFinanceiro>();
            //realiza a baixa do lançamento
            bool baixado = false;//_manager.CompensarCheques(lanctos, lookUpContaBancaria1.ContaBancaria, dtEditDataBaixa.DateTime, frmPagto);

            return baixado;
        }

        private void chDataAtual_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chDataAtual.Checked)
                this.dtEditDataBaixa.DateTime = DateTime.Now;
            else
            {
                this.dtEditDataBaixa.EditValue = null;
                this.dtEditDataBaixa.Text = "";
                this.dtEditDataBaixa.ShowPopup();
            }
        }

        private void gridViewLancsBaixa_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            refreshTotal();
        }

        private void gridViewLancsBaixa_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
        }

        private void gridViewLancsBaixa_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            int r = e.ControllerRow;
            Console.WriteLine(r);

            if (e.Action == System.ComponentModel.CollectionChangeAction.Add)
                Console.WriteLine(e.Action);
            refreshTotal();

        }

        #region Wizard

        /// <summary>
        /// Ocorre quando clica no Finish
        /// </summary>
        private void completionWizardPage1_PageCommit(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void wizardPage1_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            if (lookUpContaBancaria1.ContaBancaria == null)
            {
                XMessageIts.Advertencia("Informe a conta para a baixa !");
                //cancele o evento
                e.Valid = false;

            }
            else if (DataUtil.ValidateDate(dtEditDataBaixa.DateTime) == null)
            {
                //cancele o evento
                e.Valid = false;
                XMessageIts.Advertencia("Informe a data para baixa do(s) lançamento(s) !!!");

            }
            else
            {
                var lanctos = gridViewLancsBaixa.GetSelectedItens<LancamentoFinanceiro>();
                if (lanctos.Count > 0)
                {
                    if (lanctos.Exists(l => l.TotalLancamento <= 0))
                    {
                        XMessageIts.Advertencia("Existe(m) lançamento(s) com valor menor ou igual a 0");
                    }
                    else
                    {
                        var sum = lanctos.Sum(l => l.ValorJuros + l.ValorLancamento).ToString("N2");
                        
                        var op = XMessageIts.Confirmacao("Confirme a baixa do(s) \""
                            + lanctos.Count + "\" lançamento(s) ?\n\n"
                            + "Total: R$ " + sum, "Atenção!!!");

                        if (op != System.Windows.Forms.DialogResult.Yes)
                        {
                            //cancele o evento
                            e.Valid = false;
                        }
                    }
                }
                else
                {
                    XMessageIts.Mensagem("Nenhum lançamento foi selecionado !");
                    //cancele o evento
                    e.Valid = false;
                }
            }
        }

        private void wizardPage1_PageCommit(object sender, EventArgs e)
        {
            this.completionWizardPage1.AllowFinish = false;
            XFrmWait.ShowSplashScreen("Baixando lançamentos");

            //tenta baixar
            this.IsCompensado = baixar();

            //se deu errado
            if (!IsCompensado)
                //cancele o evento
                completionWizardPage1.FinishText = "Falha ao realizar a baixado dos lançamento(s).";
            else
                this.completionWizardPage1.AllowFinish = true;

            //fecha a barra
            XFrmWait.CloseSplashScreen();
        }


        #endregion

    }
}