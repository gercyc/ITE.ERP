using System;
using System.Collections.Generic;
using ITE.Entidades.POCO.Financeiro;
using ITSolution.Framework.Util;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.GuiUtil;
using System.Windows.Forms;
using System.Linq;
using ITE.Entidades.DaoManager.FinanceiroDaoManager;
using ITSolution.Framework.Beans.ProgressBar;
using ITE.Entidades.Enumeradores;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.Validador;

namespace ITE.Financeiro.Forms.Wizard
{
    public partial class XFrmAssitenteLancamentoFinanceiro : DevExpress.XtraEditors.XtraForm
    {
        private LancamentoFinanceiro _lancamentoAtual;
        private List<LancamentoFinanceiro> _lancamentoList;
        private FormTypeAction _action;
        private XFrmAssitenteLancamentoFinanceiro()
        {
            InitializeComponent();

            repNatureza.Items.Add(TypeLancamentoFinanceiro.Pagar);
            repNatureza.Items.Add(TypeLancamentoFinanceiro.Receber);
            //repNatureza.Items.AddRange(Enum.GetValues(typeof(TypeLancamentoFinanceiro)));
            repStatus.Items.Add(TypeStatusLancamentoFinanceiro.Aberto);
            repStatus.Items.Add(TypeStatusLancamentoFinanceiro.Vencido);

            new TextEditUtil(this.txtTotalLancamento).CustomizeNumberField();

            //bloquea a add de texto
            repStatus.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            repNatureza.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        public XFrmAssitenteLancamentoFinanceiro(LancamentoFinanceiro lancamentoFinanceiro,
            FormTypeAction action = FormTypeAction.Salvar)
            : this()
        {
            //evitar o erro 
            //the entity wrapper stored in the proxy does not reference the same proxy
            //pq ele nao faz parte das opçoes do combo
            lancamentoFinanceiro.StatusLancamento = TypeStatusLancamentoFinanceiro.Aberto;
            //lançamento base
            //nao posso mexer no lançamento do grid
            this._lancamentoAtual = lancamentoFinanceiro.Clone();


            this._lancamentoAtual.IdLancamento = lancamentoFinanceiro.IdLancamento;
            this._lancamentoList = new List<LancamentoFinanceiro>();
            this.txtTotalLancamento.Text = _lancamentoAtual.TotalLancamento.ToString("N2");
            this._action = action;

            if (action != FormTypeAction.Salvar)
            {
                lblDesId.Visible = true;
                lblDescVencimento.Visible = true; lblDescValor.Visible = true;
                lblId.Visible = true;
                lblDataVencimento.Visible = true;
                lblTotalLancamento.Visible = true;

            }


            lblId.Text = lancamentoFinanceiro.IdLancamento.ToString();
            lblDataVencimento.Text = _lancamentoAtual.DataVencimento.ToShortDateString();
            lblTotalLancamento.Text = _lancamentoAtual.TotalLancamento.ToString("N2");
            //cria uma lancamento utilizando o lançamento base
            this.gerarParcelamento(1, 30);


        }

        public bool IsCancel { get; private set; }

        private void gerarParcelamento(int numParcelas, int intervalDias)
        {
            //calcule o prazo em cima da data do primeiro lançamento
            var row = gridView1.GetRow(0) as LancamentoFinanceiro;

            if (row == null)
                row = this._lancamentoAtual;

            DateTime dtParcela = row.DataLancamento;

            //limpo a lista de lancamentos anterior, se tiver.
            _lancamentoList.Clear();

            //valor informado 
            var valor = ParseUtil.ToDecimal(txtTotalLancamento.Text);

            for (int i = 1; i <= numParcelas; i++)
            {
                //retorna a data com o intervalo de dias escolhido
                DateTime dtVencimento = DataUtil.GetNextDate(dtParcela);

                if (intervalDias != 30)
                    dtVencimento = DataUtil.CalcularData(dtParcela, intervalDias);

                //lançamento identico
                var parcela = new LancamentoFinanceiro();

                parcela.Update(_lancamentoAtual);

                //usuario que criou
                parcela.RecCreatedBy = _lancamentoAtual.RecCreatedBy;
                parcela.RecCreatedDate = _lancamentoAtual.RecCreatedDate;

                //usuario que modificou
                parcela.RecModifyBy = _lancamentoAtual.RecModifyBy;
                parcela.RecModifyDate = _lancamentoAtual.RecModifyDate;

                parcela.DataVencimento = dtVencimento;
                parcela.SequencialParcela = i;
                parcela.ValorLancamento = valor / numParcelas;

                if(_lancamentoAtual.IdLancamento == 0)
                    parcela.Observacao += " | PARCELA " + i;
                else
                    parcela.Observacao += " | REPARCELAMENTO " + i;

                parcela.ValidarLancamento();

                //add a nova parcela
                _lancamentoList.Add(parcela);

                if (intervalDias > 0)
                    //a data atual passa ser a data do vencimento da parcela
                    //na proxima interação sera calcula mais 1 mes a frente e os dias desse periodo
                    dtParcela = dtVencimento;

            }


            //atualize o lançamento atual com o valor dividido por nº de parcelas escolhido.
            //lancamento.ValorLancamento = lancamento.ValorLancamento / numParcelas;
            this.txtTotalLancamento.Text = _lancamentoList.Sum(l => l.TotalLancamento).ToString("n2");
            this.gridControl1.DataSource = this._lancamentoList;
            this.gridView1.RefreshData();
        }

        private void btnGerarParcelas_Click(object sender, EventArgs e)
        {
            int numParcelas = ParseUtil.ToInt(spinNumLancamentos.EditValue);
            int intervalDias = ParseUtil.ToInt(spinIntervalDias.EditValue);

            if (numParcelas < 1)
            {
                XMessageIts.Mensagem("Parcelamento deve ser no minímo 1 parcela");
                spinNumLancamentos.EditValue = 1;
            }

            else if (intervalDias < 0)
            {
                XMessageIts.Mensagem("Intervalo de dias deve ser maior que 0");
                spinIntervalDias.EditValue = 1;
            }
            else
                gerarParcelamento(numParcelas, intervalDias);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            txtTotalLancamento.Text = gridView1.GetItens<LancamentoFinanceiro>().Sum(l => l.TotalLancamento).ToString("N2");
            var row = gridView1.GetFocusedRow<LancamentoFinanceiro>();
            row.ValidarLancamento();

        }

        private void txtTotalLancamento_Leave(object sender, EventArgs e)
        {
            btnGerarParcelas_Click(null, null);
        }

        private void spinNumLancamentos_EditValueChanged(object sender, EventArgs e)
        {
            btnGerarParcelas_Click(null, null);
        }

        private void spinIntervalDias_EditValueChanged(object sender, EventArgs e)
        {
            btnGerarParcelas_Click(null, null);
        }

        #region Wizard


        private void completionWizardPage1_PageCommit(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void wizardPage1_PageCommit(object sender, EventArgs e)
        {
            XFrmWait.ShowSplashScreen("Gerando lançamentos");
            this.completionWizardPage1.AllowFinish = false;

            var manager = new LancamentoDaoManager();
            this._lancamentoList.ForEach(delegate (LancamentoFinanceiro lan)
            {
                try
                {
                    if (_action == FormTypeAction.Salvar)
                        manager.SaveLancamento(lan);
                    else
                    {
                        manager.Reparcelar(_lancamentoAtual, lan);
                    }
                }
                catch (Exception ex)
                {
                    XMessageIts.Erro("Falha no parcelamento !\nVerifique a pasta de logs ou contate o administrador", "Operação cancelada");
                    LoggerUtilIts.GenerateLogs(ex);
                    this.Dispose();
                    return;
                }
            });
            this.completionWizardPage1.AllowFinish = true;
            XFrmWait.CloseSplashScreen();

        }

        private void wizardPage1_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            if (e.Direction == DevExpress.XtraWizard.Direction.Forward)
            {
                var vazio = this._lancamentoList.Exists(l => l.TotalLancamento <= 1);

                if (ValidadorDTO.ValidateListWarningAll(_lancamentoList))
                {
                    if (vazio)
                    {
                        XMessageIts.Advertencia("Existem lançamentos com valor menor ou igual que 1!");
                        e.Valid = false;
                    }
                    else if (_lancamentoAtual.IdLancamento != 0 && this._lancamentoList.Sum(l => l.TotalLancamento) >= _lancamentoAtual.TotalLancamento)
                    {
                        XMessageIts.Advertencia(
                            "O parcelamento não deve ser superior ou zerar o valor do lançamento existe!","Atenção");
                        e.Valid = false;
                    }
                    else if (_lancamentoList.Count < 1)
                    {
                        XMessageIts.Advertencia("O parcelamento mínimo é de 1 parcela!");
                        e.Valid = false;
                    }
                    else
                    {
                        var op = XMessageIts.Confirmacao("Deseja proseguir com criação dos lançamentos informados ?");
                        if (op != DialogResult.Yes)
                        {
                            e.Valid = false;
                        }
                    }
                }
                else
                {
                    e.Valid = false;
                }
            }
        }

        private void wizardControl1_CancelClick(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var op = XMessageIts.Confirmacao("Deseja realmente cancelar o parcelamento ?",
                "Atenção todas as informações serão perdidas.");

            if (op == DialogResult.Yes)
            {
                this.IsCancel = true;
                this.Dispose();
            }
        }

        #endregion
    }
}