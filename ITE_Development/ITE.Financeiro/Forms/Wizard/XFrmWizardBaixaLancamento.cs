using System;
using System.Collections.Generic;
using ITSolution.Framework.Util;
using System.Linq;
using System.Windows.Forms;
using ITE.Entities.DaoManager.FinanceiroDaoManager;
using ITSolution.Framework.GuiUtil;
using System.Threading.Tasks;
using ITE.Entidades.DaoManager.FinanceiroDaoManager;
using ITE.Entidades.Enumeradores.FinanceiroEnum;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.POCO.Sales;
using ITSolution.Framework.Listeners;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Beans.ProgressBar;
using ITE.Entidades.Repositorio;

namespace ITE.Financeiro.Forms.Wizard
{
    public partial class XFrmWizardBaixaLancamento : DevExpress.XtraEditors.XtraForm
    {
        private readonly LancamentoDaoManager _manager;
        public bool IsBaixa { get; private set; }
        private List<LancamentoFinanceiro> lancamentos;
        private TypeFaturamentoComissao typeFaturamento;

        public XFrmWizardBaixaLancamento()
        {
            InitializeComponent();
            this.typeFaturamento = TypeFaturamentoComissao.None;
            this._manager = new LancamentoDaoManager();
            //tenta recuperar a conta padrão
            ContaBancaria conta = new ContaBancariaDaoManager().GetContaDefault();
            if (conta != null)
                this.lookUpContaBancaria1.FindSetContaBancaria(conta.CodigoContaBancaria);

            chDataAtual_CheckedChanged(null, null);
            this.ActiveControl = this.cbFormaPagto;
            //listern default
            wizardControl1.EnableSelectedPageChanged();
            //listerner custom
            this.wizardControl1.SelectedPageChanged += new DevExpress.XtraWizard
                .WizardPageChangedEventHandler(this.wizardControl1_SelectedPageChanged);


        }


        public XFrmWizardBaixaLancamento(List<LancamentoFinanceiro> lancamentos) : this()
        {
            this.lancamentos = lancamentos;
            gridControlLancBaixa.DataSource = this.lancamentos;
            gridViewLanctosBaixa.SelectAllRow();
            this.gridViewLanctosBaixa.OptionsBehavior.Editable = false;
        }

        public XFrmWizardBaixaLancamento(List<LancamentoFinanceiro> lancamentos,
            TypeFaturamentoComissao typeFaturamento) : this(lancamentos)
        {
            this.typeFaturamento = typeFaturamento;
            this.welcomeWizardPage1.Text = "Bem vindo ao assistente para baixa das comissões";
            gridViewLanctosBaixa.UnSelectAllRow();
            gridViewLanctosBaixa.SelectRows(0, 0);
        }

        private void wizardControl1_SelectedPageChanged(object sender, DevExpress.XtraWizard.WizardPageChangedEventArgs e)
        {
            cbFormaPagto.ShowPopup();
            cbFormaPagto.Focus();

        }

        private void refreshTotal()
        {
            var lanctos = this.gridViewLanctosBaixa.GetSelectedItens<LancamentoFinanceiro>();
            txtTotalLancamentos.Text = lanctos.Sum(l => l.ValorLancamento + l.ValorJuros).ToString("N2");
        }

        private bool startBaixa()
        {


            //se mandei faturar comissoes
            if (typeFaturamento != TypeFaturamentoComissao.None || this.lancamentos.Any(l => l.IdLancamento == 0))
            {
                this.lancamentos = this.gridViewLanctosBaixa.GetSelectedItens<LancamentoFinanceiro>();
                try
                {
                    //gera os lancamentos antes de efetuar as baixas
                    new ComissaoVendaDaoManager().FaturarComissao(lancamentos, typeFaturamento);
                }
                catch
                {
                    return false;
                }
            }

            var frmPagto = cbFormaPagto.SelectedItem as FormaPagamento;

            //realiza a baixa do lançamento
            bool baixado = _manager.BaixarLancamentos(this.lancamentos, lookUpContaBancaria1.ContaBancaria,
                        dtEditDataBaixa.DateTime, frmPagto);
            return baixado;
        }

        private void gridViewLancsBaixa_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            refreshTotal();
        }

        private void gridViewLancsBaixa_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            //int r = e.ControllerRow;
            //if (e.Action == System.ComponentModel.CollectionChangeAction.Add)
            //    Console.WriteLine(e.Action);
            refreshTotal();

        }

        private void chDtVencimento_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chDtVencimento.Checked)
            {
                this.chDataAtual.Checked = false;
                this.dtEditDataBaixa.Enabled = true;


                if (this.lancamentos.Count == 1)
                    this.dtEditDataBaixa.EditValue = lancamentos.FirstOrDefault().DataVencimento.Date;
                else
                    this.dtEditDataBaixa.EditValue = null;
                
            }
            else
            {
                this.dtEditDataBaixa.EditValue = null;
                this.dtEditDataBaixa.Enabled = true;

                if (!chDataAtual.Checked)
                    this.dtEditDataBaixa.ShowPopup();
            }
        }

        private void chDataAtual_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chDataAtual.Checked)
            {
                this.chDtVencimento.Checked = false;
                this.dtEditDataBaixa.DateTime = DateTime.Now;
                this.dtEditDataBaixa.Enabled = false;
            }
            else
            {
                this.dtEditDataBaixa.Enabled = true;
                this.dtEditDataBaixa.EditValue = null;
                this.dtEditDataBaixa.Text = "";
                if (!chDtVencimento.Checked)
                    this.dtEditDataBaixa.ShowPopup();
            }
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
            if (e.Direction == DevExpress.XtraWizard.Direction.Forward)
            {
                if (lookUpContaBancaria1.ContaBancaria == null)
                {
                    XMessageIts.Advertencia("Informe a conta para a baixa !");
                    //cancele o evento
                    e.Valid = false;

                }
                else if (dtEditDataBaixa.DateTime.ValidateDate() == null)
                {

                    if (!chDataAtual.Checked && !chDtVencimento.Checked)
                    {
                        //cancele o evento
                        e.Valid = false;
                        XMessageIts.Advertencia("Informe a data de pagamento do(s) lançamento(s) !!!");
                    }
                }
                else if (cbFormaPagto.SelectedItem == null)
                {
                    //cancele o evento
                    e.Valid = false;
                    XMessageIts.Advertencia("Informe a forma de pagamento.");
                }
                else
                {
                    var lanctos = gridViewLanctosBaixa.GetSelectedItens<LancamentoFinanceiro>();
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

                            if (op != DialogResult.Yes)
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
        }

        private async void wizardPage1_PageCommit(object sender, EventArgs e)
        {

            Task<bool> taskBaixa = Task.Run(() => startBaixa());

            this.completionWizardPage1.AllowFinish = false;


            //mostra a barrinha ae jovem
            XFrmWait.ShowSplashScreen("Baixando lançamentos");

            //tenta baixar
            this.IsBaixa = await taskBaixa;

            //se deu errado
            if (!IsBaixa)
                //cancele o evento
                completionWizardPage1.FinishText = "Falha ao realizar a baixado dos lançamento(s).";

            //deixa encerrar
            this.completionWizardPage1.AllowFinish = true;

            //fecha a barra
            XFrmWait.CloseSplashScreen();
        }

        private void wizardControl1_CancelClick(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Dispose();
        }

        #endregion

        private void XFrmWizardBaixaLancamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;//nao deixei fechar

        }

        private void XFrmWizardBaixaLancamento_Shown(object sender, EventArgs e)
        {
            refreshTotal();
            using (var ctx = new BalcaoContext())
            {

                try
                {

                    var formasPagto = ctx.FormaPagamentoDao.FindAll();
                    this.cbFormaPagto.AddList<FormaPagamento>(formasPagto);

                    if (lancamentos.Count == 1)
                    {
                        var fp = lancamentos.First().FormaPagamento;
                        var formaPagamento = formasPagto.First(f => f.IdFormaPagamento == fp.IdFormaPagamento);

                        this.cbFormaPagto.SetSelectItem(formaPagamento);
                    }
                    else
                        cbFormaPagto.SelectedIndex = -1;
                }
                catch
                {
                    cbFormaPagto.SelectedIndex = -1;
                }

            }
        }


    }
}