using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Util;
using ITSolution.Framework.Mensagem;
using System.Threading;
using ITE.Entidades.DaoManager.VendasDaoManager;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.UnitControl;
using ITE.Entidades.POCO.Sales;
using ITE.Reports.Relatorios;

namespace ITE.Vendas.Forms.ControleVenda
{
    public partial class XFrmFechamento : DevExpress.XtraEditors.XtraForm
    {
        private readonly XFrmFormaPagto _xFrmFormaPagto;
        private readonly Venda _proposta;
        //Proposta a ser utilizada para calculo
        private Venda _propBase;
        private readonly IllustrateBarItem _ilustrador;
        private readonly XFrmVenda _xFrmProposta;
        private CancellationTokenSource _cts;

        public bool IsSucess { get; set; }

        public XFrmFechamento()
        {
            InitializeComponent();
            this._ilustrador = new IllustrateBarItem(this, this.barStaticInfoImprimir,
                "(CTRL + P) Imprimir/Salvar a nota");
            this._ilustrador.Intervalo = 700;
            this.ActiveControl = txtVlrRecebido;
            this.txtVlrRecebido.Focus();
            new TextEditUtil(this.txtDesconto).CustomizeNumberField();
            new TextEditUtil(this.txtVlrRecebido).CustomizeNumberField();

        }

        public XFrmFechamento(Venda novo, XFrmVenda xFrmProposta)
            : this()
        {
            this._xFrmProposta = xFrmProposta;
            this._proposta = indexarCampos(novo);
        }

        public XFrmFechamento(Venda novo, XFrmFormaPagto xFrmFormaPagto) : this()
        {
            this._xFrmFormaPagto = xFrmFormaPagto;
            this._proposta = indexarCampos(novo);

        }

        #region Calculos

        private Venda indexarCampos(Venda novo)
        {
            this._propBase = novo.Clone();
            using (var ctx = new BalcaoContext())
            {
                var formaPagto = ctx.FormaPagamentoDao.Find(novo.IdFormaPagamentoVenda);

                if (formaPagto == null)
                    formaPagto = ctx.FormaPagamentoDao.Where(f => f.NomeFormaPagamento == "Dinheiro" 
                                            || f.NomeFormaPagamento == "Á Vista").FirstOrDefault();


                var tipo = formaPagto.TipoFormaPagamento;
                if (tipo == TypeFormaPagamento.Cartao || tipo == TypeFormaPagamento.Cheque ||
                    tipo == TypeFormaPagamento.Boleto || tipo == TypeFormaPagamento.Parcelado)
                {
                    this.txtDesconto.ReadOnly = true;
                    this.txtVlrRecebido.ReadOnly = true;
                    this.cbDescontoOp.ReadOnly = true;
                }
                else
                {
                    this.txtDesconto.ReadOnly = false;
                    this.txtVlrRecebido.ReadOnly = false;
                    this.cbDescontoOp.ReadOnly = false;
                }

                this.txtVlrRecebido.Text = novo.TotalVenda.ToString("N2");


                this.navBarFormaPagto.Caption = formaPagto.NomeFormaPagamento;
                this.navBarParcelas.Caption = novo.NumeroParcelas.ToString() + "x";
                this.navBarDescontos.Caption = novo.Desconto.ToString("N2");
                this.navBarJuros.Caption = novo.Parcelas.Sum(p => p.ValorJuros)
                                                                    .ToString("N2");

                this.navBarItens.Caption = novo.ItensVendas.Count.ToString();
                this.navBarSubTotal.Caption = novo.CalculaTotalVenda(novo.TotalVenda, novo.ValorDesconto)
                                                                .ToString("N2");
                this.navBarTotal.Caption = novo.TotalVenda.ToString("N2");
                this.navBarVencimento.Caption = novo.DataVencimento.ToShortDateString();

                if (novo.Desconto != 0)
                    this.txtDesconto.Text = novo.Desconto.ToString("N2");
                else
                    this.txtDesconto.Text = novo.ValorDesconto.ToString("N2");

                this.navBarDescontos.Caption = novo.ValorDesconto.ToString("N2");
                this.lblTotalVenda.Text = novo.TotalVenda.ToString("N2");

                return novo;
            }
        }

        private void calcularTroco()
        {
            if (this._proposta != null)
            {
                int index = cbDescontoOp.SelectedIndex;
                //terei sempre o valor da proposta guardado
                this._propBase = this._proposta.Clone();
                var vlrRecebido = ParseUtil.ToDecimal(this.txtVlrRecebido.Text);
                var desconto = ParseUtil.ToDecimal(this.txtDesconto.Text);
                decimal troco = 0;

                //Calcule a porcentagem em seguinda o valor em reais
                if (index == (int)TypeDesconto.Reais)
                {
                    this._propBase.Desconto = this._propBase.CalculaDesconto(this._propBase.TotalVenda, desconto);
                    this._propBase.ValorDesconto = this._propBase.CalculaValorDesconto(this._propBase.TotalVenda, this._propBase.Desconto);

                }
                //Calcule o valor em reais em seguinda porcentagem
                else
                {
                    this._propBase.ValorDesconto = this._propBase.CalculaValorDesconto(this._propBase.TotalVenda, desconto);
                    this._propBase.Desconto = this._propBase.CalculaDesconto(this._propBase.TotalVenda, this._propBase.ValorDesconto);

                }
                //atualiza o total da proposta
                this._propBase.TotalVenda = _propBase.CalculaTotalVenda(this._propBase.TotalVenda,
                                                                                this._propBase.ValorDesconto);

                //seta a proposta apos o desconto
                this.navBarSubTotal.Caption = this._propBase.TotalVenda.ToString("N2");
                //desconto em reais
                this.navBarDescontos.Caption = this._propBase.ValorDesconto.ToString("N2");

                //calcula o troco
                troco = _propBase.CalculaTotalVenda(vlrRecebido, this._propBase.TotalVenda);

                //labels
                this.lblVlrTroco.Text = troco.ToString("N2");
                this.lblTotalVenda.Text = this._propBase.TotalVenda.ToString("N2");

            }
        }

        /// <summary>
        /// Verifica se o desconto está acima do permitido
        /// </summary>
        /// <returns></returns>
        private bool checkDesconto()
        {
            var desconto = ParseUtil.ToDecimal(txtDesconto.Text);

            if (desconto > 10)
            {
                UnitWork login = new UnitWork();
                login.XFrmLogin.Text = "Autorização de Desconto";
                login.XFrmLogin.Run();
                var isLogin = login.IsLogin();
                if (isLogin == null)
                {
                    checkDesconto();
                    //cancelar a permissao
                    return false;
                }
            }
            return true;
        }


        ///Cotação

        #endregion Calculos

        #region Flag de impressao
        /// <summary>
        /// Imprime a proposta ao pressionar CTRL + P
        /// </summary>
        /// <param name="e"></param>
        private void printProposta()
        {
            if (IsSucess)
            {
                //termina a thread
                //cuidado precisa ser false
                IsSucess = false;
                _ilustrador.Running = IsSucess;

                new RptNotaVenda(this._proposta).Run();
            }
            else
                XMessageIts.Advertencia("Você não pode imprimir uma proposta que ainda não foi fechada!",
                    "Atençao: Venda não realizada");
        }

        private void showConfirmationProposta()
        {
            //Flag para ativar a Thread
            this.IsSucess = true;
            this._cts = new CancellationTokenSource();
            //desabilite tudo
            ComponenteUtil.DesabilitarComponentes(new Component[]  {
                                    barManager1, groupBoxReceb,
                                    barBtnVoltar,
                                    barBtbFinalizar,txtDesconto,lblTotalVenda,
                                    txtDesconto });

            //Task para exibir mensagem de impressao
            //Task.Run(() => this.showMessagePrintProposta());

            Task.Run(() => _ilustrador.Run());
        }

        #endregion Flag de impressao

        #region Eventos

        private void txtDesconto_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            calcularTroco();
        }

        //Chamado aqui e no desconto 
        private void txtVlrRecebido_EditValueChanged(object sender, EventArgs e)
        {
            //var x = sender as TextEdit;
            //var value = x.Text;
            calcularTroco();

        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            calcularTroco();
        }

        private void txtVlrRecebido_Leave(object sender, EventArgs e)
        {
            calcularTroco();
        }

        private void barBtnVoltar_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            if (this._xFrmFormaPagto == null)
                this._xFrmProposta.Show();
            else
                this._xFrmFormaPagto.Show();
        }

        private void barBtbFinalizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            calcularTroco();
            var vlrRecebido = ParseUtil.ToDecimal(txtVlrRecebido.Text);
            var vlrTroco = ParseUtil.ToDecimal(lblVlrTroco.Text);

            //nao mapeado
            this._propBase.ValorRecebido = Math.Round(vlrRecebido, 2);
            this._propBase.ValorTroco = Math.Round(vlrTroco, 2);
            //seta os valores
            this._propBase.Desconto = Math.Round(_propBase.Desconto, 2);
            this._propBase.ValorDesconto = Math.Round(_propBase.ValorDesconto, 2);
            this._propBase.TotalVenda = Math.Round(_propBase.TotalVenda, 2);

            if (this._propBase.ValorRecebido <= 0)
            {
                XMessageIts.Advertencia("Informe o valor recebido !", "Atenção");
            }

            else if (this._propBase.ValorDesconto > this._propBase.TotalVenda)
            {
                XMessageIts.Advertencia("Valor do desconto não pode ser superior ao valor da proposta");
            }

            else if (this._propBase.ValorRecebido < this._propBase.TotalVenda)
            {
                XMessageIts.Advertencia("Valor informado inferior ao valor da proposta",
                    "Valor Insuficiente");
            }
            else
            {
                var msg = "A proposta será finalizada\n\nValor : R$ "
                    + this._propBase.TotalVenda.ToString("N2");

                var op = XMessageIts.Confirmacao(msg, "Confirmar fechamento ?");

                if (op == DialogResult.Yes)
                {
                    //atualiza o objeto original
                    this._proposta.Update(this._propBase);

                    bool transation = new VendaDaoManager().FecharProposta(this._proposta);

                    //venda ou cotação exibe o flag de impressao
                    if (transation)
                    {
                        barItemNumVenda.Caption = "Venda Número: " + this._proposta.IdVenda;

                        showConfirmationProposta();
                    }
                    else
                        this.IsSucess = false;
                }
            }

        }

        private void navBarItens_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            new XFrmItensProposta(this._propBase.ItensVendas.ToList()).ShowDialog();
        }

        private void XFrmFechamento_DEV_FormClosing(object sender, FormClosingEventArgs e)
        {
            //se o form existe e nao esta sendo usado
            if (this._xFrmFormaPagto != null && !this._xFrmFormaPagto.Visible)
            {
                //libere o objeto
                this._xFrmFormaPagto.Dispose();
            }

            //se o form existe e nao esta sendo usado
            if (this._xFrmProposta != null && !this._xFrmProposta.Visible)
            {
                //libere o objeto
                this._xFrmProposta.Dispose();
            }
        }

        private void XFrmFechamento_DEV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && this.IsSucess)
            {
                if (_cts != null)
                {
                    _cts.Cancel();
                }
                _ilustrador.Running = false;
                this.Dispose();
            }
            else if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                printProposta();
                this.Dispose();
            }
        }
     
        #endregion

        #region Enum
        enum TypeDesconto
        {
            Porcentagem = 0, Reais = 1
        }

        #endregion

    }
}