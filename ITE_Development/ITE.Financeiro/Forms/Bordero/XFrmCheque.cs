using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using ITE.Bordero.Forms.Calculator;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO.Bordero;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITSolution.Framework.Validador;

namespace ITE.Financeiro.Forms.Bordero
{
    public partial class XFrmCheque : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Cheque _chequeAnt;
        private List<Cheque> _cheques;
        private TypeLancamentoFinanceiro _tipoLancamento;
        private bool _modoCalculador;

        public XFrmCheque()
        {
            InitializeComponent();
            new TextEditUtil(txtPrazo, "0", -1).CustomizeNumberField();
            new TextEditUtil(txtCompensacao, "0", -1).CustomizeNumberField();
            new TextEditUtil(txtTaxaJuros, 2).CustomizeNumberField();
            new TextEditUtil(txtValorLiquido, 2).CustomizeNumberField();
            new TextEditUtil(txtValorJuros, 2).CustomizeNumberField();
            new TextEditUtil(txtValorCheque, 2).CustomizeNumberField();

            this._cheques = new List<Cheque>();
        }

        public XFrmCheque(Cheque ch, FormTypeAction action = FormTypeAction.Alterar)
            : this()
        {
            this._chequeAnt = indexarDados(ch);
            if (action == FormTypeAction.Visualizar)
            {
                this.Enabled = false;
                this.btnSalvar.Text = "Alterar";
            }
        }
        /// <summary>
        /// Inicia o form em modo de cálculo
        /// </summary>

        public XFrmCheque(bool modo)
            : this()
        {
            setModoCalculador(modo);
        }

        public void setModoCalculador(bool modo)
        {
            this._tipoLancamento = TypeLancamentoFinanceiro.Receber;
            this._modoCalculador = modo;

            TextEdit[] txts = new TextEdit[]{ this.txtPrazo,this.txtCompensacao,
                this.txtTaxaJuros,this.txtValorJuros,this.txtValorLiquido,
                };

            LabelControl[] lbls = new LabelControl[]{ this.lblPrazo,this.lblCompensacao,
                this.lblTaxaJuros,this.lblVlrJuros,this.lblVlrLiq,
                };

            this.lblPrazo.Visible = modo;


            foreach (var item in txts)
                item.Visible = modo;

            foreach (var item in lbls)
                item.Visible = modo;

            this.checkEditGerarNumCh.Visible = modo;

            if (modo)
            {
                this.barBtnCalcular.Visibility = BarItemVisibility.Always;
                this.barStaticNumChFlag.Visibility = BarItemVisibility.Always;
                this.barBtnClearCheques.Visibility = BarItemVisibility.Always;
            }
            else
            {
                this.barStaticNumChFlag.Visibility = BarItemVisibility.Never;
                this.barBtnCalcular.Visibility = BarItemVisibility.Never;
                this.barBtnClearCheques.Visibility = BarItemVisibility.Never;

            }
        }

        public XFrmCheque(TypeLancamentoFinanceiro tipo)
            : this()
        {
            this._tipoLancamento = tipo;
        }

        private void calcular_EditValueChanged(object sender, EventArgs e)
        {
            barBtnCalcular_ItemClick(null, null);
        }

        private void XFrmAddChequeEntrada_Shown(object sender, EventArgs e)
        {
            //if (chequeAnt == null)
            //new Thread(carregarClientes).Start();
        }


        private Cheque indexarDados()
        {
            var cc = lookUpCliFor1.CliFor;
            var valor = ParseUtil.ToDecimal(txtValorCheque.Text);

            var dataLan = dtPickerLancamento.Value;
            var dataVenc = dtPickerVencimento.Value;
            var taxaJuros = ParseUtil.ToDecimal(txtTaxaJuros.Text);
            var prazo = ParseUtil.ToInt(txtPrazo.Text);
            var comp = ParseUtil.ToInt(txtCompensacao.Text);
            var numCh = txtNumeroCheque.Text;
            var obs = richTxtObs.Text;


            return new Cheque(cc, dataLan, dataVenc, valor, prazo, comp,
                              taxaJuros, numCh, obs, _tipoLancamento);

        }

        private Cheque indexarDados(Cheque ch)
        {
            if (ch != null)
            {
                lookUpCliFor1.FindSetCliFor(ch.Cliente.IdCliFor.ToString());

                txtNumeroCheque.Text = ch.NumeroCheque;
                dtPickerLancamento.Value = ch.DataLancamento;
                dtPickerVencimento.Value = ch.DataVencimento;
                txtValorCheque.Text = ch.ValorCheque.ToString("N2");
                txtCompensacao.Text = ch.Compensacao.ToString();
                txtTaxaJuros.Text = ch.TaxaJuros.ToString("N2");
                txtValorJuros.Text = ch.ValorJuros.ToString("N2");
                txtValorLiquido.Text = ch.ValorJuros.ToString("N2");
                richTxtObs.Text = ch.Observacao;
            }
            return ch;
        }

        private void updateCheque(BalcaoContext ctx, Cheque novo)
        {
            var ch = ctx.ChequeDao.Find(_chequeAnt.IdCheque);

            //atualize cc objeto 
            ch.IdCliente = novo.IdCliente;
            ch.NumeroCheque = novo.NumeroCheque;
            ch.DataVencimento = novo.DataVencimento;
            ch.ValorCheque = novo.ValorCheque;
            ch.Observacao = novo.Observacao;

            //atualize no banco
            if (ctx.ChequeDao.Update(ch))
            {
                XMessageIts.Mensagem("Lancamento \"" + ch.IdCheque + "\" atualizado com sucesso.");
                this.Dispose();
            }
        }

        private void calcularPrazoApartirData(Cheque ch = null)
        {
            DateTime dtLancto = dtPickerLancamento.Value.Date;
            DateTime dtVencimento = dtPickerVencimento.Value.Date;
            if (DataUtil.ToDateZerada(dtLancto) < DataUtil.ToDateZerada(dtVencimento))
            {
                bool maior = DataUtil.CompararMaiorData(dtLancto, dtVencimento);

                //se true a data de emissao eh maior a data de vencimento
                if (maior)
                {
                    XMessageIts.Advertencia("A data de lançamento não pode ser superior\n"
                            + "a data de vencimento.\n");
                    //entao sao iguais
                    dtPickerLancamento.Value = dtVencimento;
                }
                else
                {
                    //calcula o prazo 
                    int prazo = DataUtil.CalcularDias(dtLancto, dtVencimento);
                    //seta o prazo no campo
                    txtPrazo.Text = prazo + "";

                    if (ch == null)
                        ch = indexarDados();
                    //calcula o cheque
                    calcularCheque(ch);
                }
            }
        }

        private void flagChequesAdicionados()
        {
            if (_cheques.Count > 0)
            {
                this.barStaticFlag.Visibility = BarItemVisibility.Always;
                this.barStaticNumChFlag.Caption = this._cheques.Count.ToString();

            }
            else
            {
                this.barStaticFlag.Visibility = BarItemVisibility.Never;
                this.barStaticNumChFlag.Caption = "0";
            }
        }

        private void dtPickerLancamento_ValueChanged(object sender, EventArgs e)
        {
            calcularPrazoApartirData();
        }

        private void dtPickerVencimento_ValueChanged(object sender, EventArgs e)
        {
            calcularPrazoApartirData();
        }

        private void txtPrazo_EditValueChanged(object sender, EventArgs e)
        {
            int prazo = ParseUtil.ToInt(txtPrazo.Text);
            int comp = ParseUtil.ToInt(txtCompensacao.Text);
            if ((prazo + comp) > 0)
            {
                try
                {
                    var dataVencimento = DataUtil.CalcularData(dtPickerLancamento.Value, prazo + comp);
                    dtPickerVencimento.Value = dataVencimento;
                }
                catch (ArgumentOutOfRangeException)
                {
                    txtPrazo.Text = "0";
                }
            }
        }

        private void txtCompensacao_EditValueChanged(object sender, EventArgs e)
        {
            txtPrazo_EditValueChanged(null, null);
        }

        private void dtPickerLancamento_CloseUp(object sender, EventArgs e)
        {
            calcularPrazoApartirData();
        }

        private void dtPickerVencimento_CloseUp(object sender, EventArgs e)
        {
            calcularPrazoApartirData();
        }

        private bool isCalcularCheque(Cheque ch)
        {

            if (ValidadorDTO.ValidateWarningAll(ch))
            {

                if (DataUtil.ToDateZerada(ch.DataLancamento) < DataUtil.ToDateZerada(ch.DataVencimento))
                {
                    return ch.Prazo != 0 || ch.Compensacao != 0
                   && ch.TaxaJuros != 0 && ch.ValorCheque != 0;
                }
                else
                {
                    XMessageIts.Mensagem("Data de lançamento deve ser menor que o vencimento !");
                }
            }
            return false;
        }

        private void XFrmAddCheque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (this.btnSalvar.Text.Equals("Alterar"))
                {
                    this.Dispose();
                }
            }
            else if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.D)
            {
                this.barBtnAddCheque_ItemClick(null, null);
            }
            else if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            {
                this.btnSalvar_Click(null, null);
            }

            else if (e.KeyCode == Keys.H)
            {
                XMessageIts.Mensagem("Atalhos disponíveis\n"
                    + "CTRL + D\t Adiciona cheque na lista"
                    + "CTRL + D\t Salva os cheque(s)");
            }
        }


        private void barBtnCalcular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ch = indexarDados();

            if (isCalcularCheque(ch))
                calcularCheque(ch);
            else
                calcularPrazoApartirData(ch);
        }

        private void calcularCheque(Cheque ch)
        {
            Cheque.CalcularCheque(ch);
            txtValorLiquido.Text = ch.ValorLiquido.ToString("N2");
            txtValorJuros.Text = ch.ValorJuros.ToString("N2");
            txtPrazo.Text = ch.Prazo.ToString();
            dtPickerVencimento.Value = ch.DataVencimento;

            if (barToggleSwitchAddCheques.Checked)
                barBtnAddCheque_ItemClick(null, null);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var ch = indexarDados();

            if (ch.IdCliente == 0)
            {
                XMessageIts.Mensagem("Informe o cliente antes de salvar");
            }
            else
            {
                var ctx = new BalcaoContext();

                if (_modoCalculador)
                {

                    if (_cheques.Count > 0)
                    {
                        //validar
                        foreach (var x in _cheques)
                            if (ValidadorDTO.ValidateWarningAll(x) == false)
                                return;

                        var op = XMessageIts.Confirmacao("Cheques válidados !\n\n" +
                                                         "Deseja salvar os " + this._cheques.Count + " cheques ?",
                            "Atenção");

                        if (op == DialogResult.Yes)
                        {
                            foreach (var x in _cheques)
                                if (ctx.ChequeDao.Save(x) == false)
                                {
                                    XMessageIts.Erro("Falha ao salvar o cheque !\nNúmero cheque: "+ x.NumeroCheque);
                                    return;
                                }
                            XMessageIts.Mensagem("Cheques salvos com sucesso");
                        }
                    }
                    else
                    {
                        XMessageIts.Mensagem("Não existem cheques calculado a serem salvos");
                    }

                }
                else
                {

                    if (ValidadorDTO.ValidateWarningAll(ch))
                    {
                        if (_chequeAnt == null)
                        {
                            if (ctx.ChequeDao.Save(ch))
                            {
                                var op = XMessageIts.Confirmacao("Cheque incluso com sucesso.\nContinuar lançamentos ?");

                                if (op == DialogResult.No)
                                    this.Dispose();
                            }
                        }
                        else
                            updateCheque(ctx, ch);
                    }
                }
            }
        }

        private void barBtnVoltar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void txtValorCheque_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsNumber((char)e.KeyValue))
                calcular_EditValueChanged(null, null);
        }

        private void txtTaxaJuros_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsNumber((char)e.KeyValue))
                calcular_EditValueChanged(null, null);
        }

        private void dtPickerVencimento_Leave(object sender, EventArgs e)
        {
            dtPickerVencimento_CloseUp(null, null);
        }

        private void dtPickerLancamento_Leave(object sender, EventArgs e)
        {
            dtPickerVencimento_CloseUp(null, null);
        }

        private void barBtnCheques_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this._cheques.Count > 0)
                new XFrmChequeCalculadoView(this._cheques).ShowDialog();
            else
                XMessageIts.Mensagem("Lista de cheques está vazia.");

        }

        private void barBtnClearCheques_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_cheques.Count > 0)
            {
                if (XMessageIts.Confirmacao("Todos os " + +this._cheques.Count +
                    " calculados serão removidos", "Alerta !!!") == DialogResult.Yes)
                {
                    this._cheques.Clear();
                }
                flagChequesAdicionados();
            }
            else
            {
                XMessageIts.Mensagem("Não há cheques calculados");

            }
        }

        private void barBtnAddCheque_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cheque ch = indexarDados();
            if (isCalcularCheque(ch))
            {
                if (checkEditGerarNumCh.Checked)
                    txtNumeroCheque.Text = "000" + (this._cheques.Count + 1);

                ch.Sequencial = this._cheques.Count + 1;
                this._cheques.Add(ch);
                flagChequesAdicionados();
            }

        }


    }
}