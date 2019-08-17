using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITSolution.Framework.Beans.ProgressBar;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.POCO.Sales;

namespace ITE.Vendas.Forms.ControleVenda
{
    public partial class XFrmFormaPagto : DevExpress.XtraEditors.XtraForm
    {
        private XFrmVenda xFrmVenda;
        private FormaPagamento formaPagto;
        internal Venda proposta;

        public XFrmFormaPagto(XFrmVenda xFrmVenda, Venda proposta)
        {
            InitializeComponent();
            this.xFrmVenda = xFrmVenda;
            this.proposta = proposta;
            //use a forma de pagamneto atual
            this.formaPagto = this.proposta.FormaPagamentoVenda;
            //a lista das formas de pagamento indexada pelo shown
            this.listBoxControlFrmPagto.Items.Clear();
            this.listBoxControlParcelamento.Items.Clear();
            this.listBoxControlParcelamento.SelectedIndex = 0;
            this.lblTotalPagto.Text = "R$ " + proposta.TotalVenda.ToString("n2");
            this.gridControlCheques.DataSource = null;

        }

        #region Metodos de controle

        /// <summary>
        /// Carrega as formas de pagamento no ListBoxControl
        /// </summary>
        /// <returns></returns>
        private void carregarFormasPagto()
        {
            using (var ctx = new BalcaoContext())
            {
                var formasPagto = ctx.FormaPagamentoDao.FindAll();

                if (formasPagto.Count == 0)
                    this.listBoxControlFrmPagto.Enabled = false;
                else
                    this.listBoxControlFrmPagto.Enabled = true;

                listBoxControlFrmPagto.Items.Clear();

                listBoxControlFrmPagto.Items.AddRange(formasPagto.ToArray());

                if (this.proposta != null && this.proposta.TipoMovimento != TypeVenda.Cotacao)
                    //remove a venda a vista
                    listBoxControlFrmPagto.Items.Remove(formasPagto[0]);

                this.listBoxControlFrmPagto.SelectedIndex = 0;
            }
        }

        private bool isChequesPredatados()
        {
            var cheques = gridViewCheques.GetItens<LancamentoFinanceiro>();

            var total = ParseUtil.ToDecimal(cheques.Sum(ch => ch.ValorLancamento), 2);

            if (total < proposta.TotalVenda)
                XMessageIts.Mensagem("Valor dos cheques pré-datados é menor que o valor da proposta",
                    "Atenção Cheques Pré-datados");
            else if (total > proposta.TotalVenda)
                XMessageIts.Mensagem("Valor dos cheques pré-datados é maior que o valor da proposta",
                    "Atenção Cheques Pré-datados");
            else
                return true;

            return false;


        }

        /// <summary>
        /// Calcule a proposta por referencia
        ///Gera o parcelamento e exibe no list box ou grid dos cheques
        /// </summary>
        /// <param name="propBase"></param>
        private void calculaPagamento(Venda propBase)
        {
            //gere o parcelamento
            List<LancamentoFinanceiro> parcelamento = gerarParcelamento();

            //se for boleto 
            if (this.formaPagto.TipoFormaPagamento == TypeFormaPagamento.Boleto &&
                parcelamento.Count == 1)
            {
                //boleto com 7 dias
                foreach (var p in parcelamento)
                {
                    p.DataVencimento = propBase.DataVenda.AddDays(7);
                }
            }

            //se for cheque os dados do grid
            if (this.formaPagto.TipoFormaPagamento == TypeFormaPagamento.Cheque)
            {
                //ja foi gerado o parcelamento e ou usuario usou o grid
                //use o parcelamento existente
                gridControlCheques.DataSource = parcelamento;
            }

            else if (this.formaPagto.TipoFormaPagamento == TypeFormaPagamento.Dinheiro)
            {
                parcelamento.FirstOrDefault().DataVencimento = this.proposta.DataVenda;
            }


            var jurosAoMes = ParseUtil.ToDecimal(txtJuros.Text);
            int numParcelas = this.formaPagto.NumeroParcelas;
            var totalProposta = propBase.TotalVenda;

            //atualiza o parcelamento
            propBase.Parcelas = parcelamento;

            var vlrDesconto = propBase.CalculaValorDesconto(totalProposta, proposta.Desconto);
            var vlrJuros = propBase.CalculaJurosVenda(totalProposta, jurosAoMes, parcelamento);
            totalProposta = propBase.CalculaTotalVenda(totalProposta, vlrJuros, vlrDesconto);

            //dados de relevancia e nao podem sera alterados
            propBase.NumeroParcelas = numParcelas;
            propBase.ValorDesconto = vlrDesconto;
            propBase.TotalVenda = totalProposta;

            //informe a forma de pagamento para a verdadeira proposta           
            propBase.IdFormaPagamentoVenda = this.formaPagto.IdFormaPagamento;
            //cancela a referencia da forma de venda
            propBase.FormaPagamentoVenda = null;

            //limpa o parcelamento
            listBoxControlParcelamento.Items.Clear();
            
            //seta o parcelamento
            listBoxControlParcelamento.Items.AddRange(parcelamento.ToArray());

            listBoxControlFrmPagto.Refresh();

            //atualiza os labels
            txtTotalJuros.Text = vlrJuros.ToString("N2");
            lblTotalPagto.Text = "R$ " + propBase.TotalVenda.ToString("N2");

        }

        private FormaPagamento getFormaPagamentoAtual()
        {
            var frmPagamento = listBoxControlFrmPagto.SelectedItem as FormaPagamento;

            if (frmPagamento != null)
                using (var ctx = new BalcaoContext())
                {
                    frmPagamento = ctx.FormaPagamentoDao.Find(frmPagamento.IdFormaPagamento);
                }
            return frmPagamento;
        }


        private void showHideOpcaoParcelamento(bool status)
        {
            //exibe as opcoes de parcelamento caso contrário as opções 
            this.lblParcelas.Visible = status;
            this.listBoxControlParcelamento.Enabled = status;
            this.spinNumParcelas.ReadOnly = true;

        }

        #endregion Metodos de controle

        #region Eventos

        /// <summary>
        /// Indexar os componentes de maneira assincrona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XFrmFormaPagto_Shown(object sender, EventArgs e)
        {
            if (this.formaPagto == null)
                carregarFormasPagto();
            else
                this.listBoxControlFrmPagto.Items.Add(this.formaPagto);
        }

        private void XFrmFormaPagto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.xFrmVenda != null && !this.xFrmVenda.Visible)
            {
                this.xFrmVenda.Dispose();
            }
        }


        private void checkEditEditar_CheckedChanged(object sender, EventArgs e)
        {
            //Solicitar permissao para alterar os juros
            //ver depois
            this.txtJuros.ReadOnly = !checkEditEditar.Checked;

            if (!this.checkEditEditar.Checked)
            {
                this.txtJuros.Text = "0";
                calculaPagamento(this.proposta.Clone());
            }

        }

        private void btnCheques_Click(object sender, EventArgs e)
        {
            calculaPagamento(this.proposta.Clone());
            //exibe o flyout
            flyoutChequePredatado.ShowPopup();
        }

        private void listBoxControlFrmPagto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //localiza a forma de pagamento e numero de parcelas originais
            var frmPagto = getFormaPagamentoAtual();

            if (frmPagto != null)
            {
                this.formaPagto = frmPagto;

                this.btnCheques.Visible = false;
                //numero de parcelas
                this.spinNumParcelas.EditValue = this.formaPagto.NumeroParcelas;

                //se entrar aqui ativa o spinNumParcelas
                if (this.formaPagto.TipoFormaPagamento != TypeFormaPagamento.Dinheiro)
                {
                    //this.formaPagto.TipoFormaPagamento == TypeFormaPagamento.Cartao
                    //  || this.formaPagto.TipoFormaPagamento == TypeFormaPagamento.Cheque
                    //  || this.formaPagto.TipoFormaPagamento == TypeFormaPagamento.Boleto
                    //  || this.formaPagto.TipoFormaPagamento == TypeFormaPagamento.Parcelado
                    showHideOpcaoParcelamento(true);
                    //habilita escolha de parcelas
                    this.spinNumParcelas.ReadOnly = false;

                    //se for cheque
                    if (this.formaPagto.TipoFormaPagamento == TypeFormaPagamento.Cheque)
                    {    //exibe o botao para predatar
                        this.btnCheques.Visible = true;
                    }
                }
                else
                {
                    if (listBoxControlFrmPagto.SelectedIndex > (int)TypeFormaPagamento.Parcelado)
                        // exiba
                        showHideOpcaoParcelamento(true);
                    else
                        //nao exiba
                        showHideOpcaoParcelamento(false);
                }

                //calcula e gera o parcelamento
                //exibe no produtoList box o parcelamento
                calculaPagamento(this.proposta.Clone());

            }


        }

        private void listBoxControlParcelamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculaPagamento(this.proposta.Clone());
        }

        /// <summary>
        /// Modifica o número de parcelas existe no objeto Forma de pagamento para um número definido pelo usuário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spinNumParcelas_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (spinNumParcelas.Visible)
            {
                var frmPagto = getFormaPagamentoAtual();
                if (frmPagto != null)
                {
                    int numParcelas = ParseUtil.ToInt(e.NewValue);

                    if (numParcelas <= 0)
                    {
                        XMessageIts.Mensagem("Valor da parcela deve ser maior que 0");
                        e.NewValue = 1;
                    }
                    else if (numParcelas > frmPagto.NumeroParcelas)
                    {
                        XMessageIts.Advertencia("Número máximo de parcela não pode ser superior a " +
                                                frmPagto.NumeroParcelas);
                        e.NewValue = frmPagto.NumeroParcelas;
                    }
                    else
                    {
                        //atualize a forma de pagamento
                        this.formaPagto.NumeroParcelas = numParcelas;

                        //gerar as novas parcelas
                        calculaPagamento(this.proposta.Clone());
                    }
                }
            }

        }

        private void barBtnAvancar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formaPagto == null)
            {
                XMessageIts.Mensagem("Informe a forma de pagamento");
            }
            else
            {
                //gera um copia da proposta
                var prop = proposta.Clone();

                //se o spin foi exibido
                if (this.spinNumParcelas.Visible)
                {
                    this.formaPagto.NumeroParcelas = ParseUtil.ToInt(spinNumParcelas.EditValue);
                }

                //atualize a proposta por referencia
                this.calculaPagamento(prop);

                //se for cheque os dados do grid
                if (this.formaPagto.TipoFormaPagamento == TypeFormaPagamento.Cheque)
                {
                    //ja foi gerado o parcelamento e ou usuario usou o grid
                    //use o parcelamento existente
                    prop.Parcelas = gridViewCheques.GetItens<LancamentoFinanceiro>();
                }
                this.Hide();
                new XFrmFechamento(prop, this).ShowDialog();
            }
        }

        private void barBtnVoltar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.xFrmVenda != null)
            {
                this.xFrmVenda.Show();
                this.Hide();
            }
            else
                this.Dispose();
        }

        private void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            carregarFormasPagto();
        }

        #endregion Eventos

        #region Eventos Flyout
        private void btnAddCheque_Click(object sender, EventArgs e)
        {
            var i = ParseUtil.ToInt(this.spinNumParcelas.EditValue) + 1;
            this.spinNumParcelas.EditValue = i;
            this.proposta.NumeroParcelas = i;

            calculaPagamento(this.proposta.Clone());

        }

        private void btnExcluirCheque_Click(object sender, EventArgs e)
        {
            var numParcelas = this.proposta.NumeroParcelas;
            if (numParcelas == 1)
            {
                XMessageIts.Mensagem("Parcelamento no cheque deve conter no minímo uma parcela");

            }
            else if (gridViewCheques.GetFocusedRow() != null)
            {
                gridViewCheques.DeleteRow();
                //informa que o numero parcelas mudou
                this.proposta.NumeroParcelas -= 1;
                calculaPagamento(this.proposta.Clone());
            }
        }

        private void btnHideFlyCheque_Click(object sender, EventArgs e)
        {
            if (isChequesPredatados())
            {
                this.flyoutChequePredatado.HidePopup();
            }
        }
        #endregion Evento Flyout

        #region Parcelamento

        /// <summary>
        /// Crie as forma de pagamento de uma proposta e seta o total de juros
        /// </summary>
        /// <param name="proposta"></param>Tipo proposta a ser criada
        /// <param name="parcelamento"></param>
        /// <returns></returns>Uma lista de pagamento com cheques predatados
        private List<LancamentoFinanceiro> gerarParcelamento()
        {
            List<LancamentoFinanceiro> parcelamento = new List<LancamentoFinanceiro>();
            DateTime dtParcela = proposta.DataVenda;
            int numParcelas = this.formaPagto.NumeroParcelas;

            proposta.NumeroParcelas = numParcelas;
            DateTime dataBase = dtParcela;
            var vlrParcela = proposta.CalculaValorParcela(proposta.TotalVenda, numParcelas);

            for (int i = 1; i <= numParcelas; i++)
            {
                //retorna a data um mes a frente
                DateTime dtVencimento = DataUtil.GetNextDate(dataBase);

                //a data da proposta é a data da primeira parcela a vencer
                if (numParcelas == 1)
                    proposta.DataVencimento = dtVencimento;

                //crie uma parcela com 1 mes de prazo
                //e os dias que tem esses
                var parcela = new LancamentoFinanceiro(proposta, vlrParcela, dtParcela, dtVencimento, i, TypeStatusLancamentoFinanceiro.Aberto);
                parcela.SequencialParcela = i;

                //venda a vista use a data da venda
                if (this.formaPagto.TipoFormaPagamento == TypeFormaPagamento.Dinheiro)
                {
                    //vencimento da proposta eh a data da venda
                    parcela.DataVencimento = proposta.DataVenda;
                    //vencimento da venda eh data da proposta
                    proposta.DataVencimento = proposta.DataVenda;

                }

                parcelamento.Add(parcela);

                //a data atual passa ser a data do vencimento da parcela
                //na proxima interação sera calcula mais 1 mes a frente e os dias desse periodo
                dataBase = dtVencimento;
            }

            return parcelamento;
        }

        #endregion Parcelamento

        #region Classes internas


        /// <summary>
        /// Classe para predatar os cheques exibir no grid do flyout
        /// </summary>
        internal class Cheque
        {
            public DateTime DataCheque { get; set; }
            public Decimal ValorCheque { get; set; }

            public Cheque(DateTime dtCh, Decimal valorCh)
            {
                this.DataCheque = dtCh;
                this.ValorCheque = valorCh;
            }
        }


        #endregion Classes internas

        private void txtJuros_Leave(object sender, EventArgs e)
        {
            calculaPagamento(this.proposta.Clone());

        }
    }
}