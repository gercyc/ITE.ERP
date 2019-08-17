using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO.Financeiro;
using System.Collections.Generic;
using System;
using ITSolution.Framework.Util;

// Classe nao terminada 
namespace ITE.Financeiro.Forms.Caixa
{
    public partial class XFrmFluxoCaixaVendas : DevExpress.XtraEditors.XtraForm
    {
        private List<MovimentoCaixa> _movimentos;

        public XFrmFluxoCaixaVendas()
        {
            InitializeComponent();
        }

        public void Show(List<MovimentoCaixa> movimentos)
        {
            this._movimentos = movimentos;

            if (this._movimentos == null)
                this._movimentos = new List<MovimentoCaixa>();

            updateIndicadores();

            this.ShowDialog();
        }


        private void updateIndicadores()
        {

            Controle ct = new Controle();
            //separa os valores Dinheiro/Cartao/Cheque/Outros/ Totals das Entradas
            this._movimentos.ForEach(ct.SplitValues);

            //entrada
            lbVlrDinheiro.Text = ct.Dinheiro.ToString("n2");
            lbVlrCartao.Text = ct.Cartao.ToString("n2");
            lbVlrChqRecebidos.Text = ct.Cheque.ToString("n2");
            lbVlrOutros.Text = ct.Outros.ToString("n2");
            lbVlrTotEntradas.Text = ct.TotalEntradas.ToString("n2");

            //retiradas
            lbVlrRetiradas.Text = ct.Saques.ToString("n2");
            lbVlrEstornos.Text = ct.Estornos.ToString("n2");
            lbVlrTotSaidas.Text = ct.TotalSaidas.ToString("n2");


            lbVlrSaldoDinheiro.Text = ct.SaldoDinheiro.ToString("n2");
            lbSaldo.Text = ct.Saldo.ToString("n2");

        }

        private void XFrmFluxoCaixaVendas_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
                this.Hide();
        }


        #region Classe para controle Interno
        private class Controle
        {

            public decimal Dinheiro { get; set; }
            public decimal Cartao { get; set; }
            public decimal Cheque { get; set; }
            public decimal Outros { get; set; }

            public decimal Depositos { get; set; }
            public decimal Saques { get; set; }
            public decimal Estornos { get; set; }
            public decimal TotalEntradas { get; set; }
            public decimal TotalSaidas { get; set; }

            public decimal TotalNaoMapeado { get; set; }
            public decimal SaldoDinheiro { get; set; }
            public decimal Saldo { get; set; }

            /// <summary>
            /// Separa os valores de forma de pagamentos padronizados
            /// Credito 
            /// Dinheiro
            /// Cartao
            /// Cheque
            /// Outros
            /// Total das Entrada
            /// 
            /// Débito
            /// Total
            /// 
            /// </summary>
            /// <param name="mov"></param>
            public void SplitValues(MovimentoCaixa mov)
            {

                if (mov.Venda != null)
                {
                    var tipoPagamento = mov.Venda.FormaPagamentoVenda.TipoFormaPagamento;

                    if (mov.TipoMov == TypeMovimentacaoMonetaria.Credito)
                    {
                        if (tipoPagamento == TypeFormaPagamento.Dinheiro)
                        {
                            this.Dinheiro += mov.ValorMovimento;
                        }

                        else if (tipoPagamento == TypeFormaPagamento.Cartao)
                        {
                            this.Cartao += mov.ValorMovimento;
                        }

                        else if (tipoPagamento == TypeFormaPagamento.Cheque)
                        {
                            this.Cheque += mov.ValorMovimento;
                        }

                        else if (tipoPagamento == TypeFormaPagamento.Boleto
                            || tipoPagamento == TypeFormaPagamento.Parcelado)
                        {
                            this.Outros += mov.ValorMovimento;
                        }

                        this.TotalEntradas += mov.ValorMovimento;
                    }
                    //venda pode ser estornda
                    else if (mov.TipoMov == TypeMovimentacaoMonetaria.Estorno)
                    {
                        this.Estornos += mov.ValorMovimento;
                    }
                    else
                    {
                        //para testes
                        this.TotalNaoMapeado += mov.ValorMovimento;
                    }
                }
                else//nao eh movimento de venda entao so pode ser credito ou debito
                {
                    if (mov.TipoMov == TypeMovimentacaoMonetaria.Credito)
                    {
                        this.Depositos += mov.ValorMovimento;
                    }
                    //saque ou retirada
                    else 
                    {
                        this.Saques += mov.ValorMovimento;
                    }
                }

                //tudo que for debito
                this.TotalSaidas = this.Saques + this.Estornos;
                //tudo que entrou e saiu literalmente (bruto)
                this.Saldo = this.TotalEntradas - this.TotalSaidas;
                //tudo que for entrada do caixa em especie
                //menos as saidas em especie
                this.SaldoDinheiro = this.Depositos + this.Dinheiro - this.TotalSaidas;

                if (TotalNaoMapeado != 0)
                    LoggerUtilIts.GenerateLogs(new Exception("Fluxo de caixa divergente"), 
                        "Classe interna de calculo do fluxo de caixa" + 
                        typeof(XFrmFluxoCaixaVendas).ToString()
                        );
            }

        }
        #endregion

    }
}
