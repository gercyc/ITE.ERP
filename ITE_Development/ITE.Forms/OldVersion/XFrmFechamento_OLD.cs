using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Util;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.Repositorio;
using ITE.Entidades.DaoManager.VendasDaoManager;
using ITE.Entidades.UnitControl;
using ITE.Entidades.POCO.Sales;
using ITE.Reports.Relatorios;

namespace ITE.Vendas.Forms.ControleVenda
{
    public partial class XFrmFechamento_OLD : DevExpress.XtraEditors.XtraForm
    {
        private Venda proposta;
        //Proposta a ser utilizada para calculo
        private Venda propostaBase;
        private IllustrateLabel ilustrador;
        private XFrmVenda xFrmProposta;
        private XFrmFechamento xFrmDetalhamento;
        public bool IsSucess { get; set; }

        #region Construtores
        private XFrmFechamento_OLD()
        {
            InitializeComponent();

            this.ilustrador = new IllustrateLabel(this, this.lblInfoImprimir, "(CTRL + P) para Imprimir/" +
                "Salvar a nota");
            this.ActiveControl = txtDesconto;
            this.txtDesconto.Focus();
        }

        public XFrmFechamento_OLD(Venda proposta)
            : this()
        {
            this.proposta = proposta;
            this.propostaBase = indexarCampos(proposta);
        }

        public XFrmFechamento_OLD(Venda venda, XFrmFechamento xFrmDetalhamento)
            : this(venda)
        {
            this.xFrmDetalhamento = xFrmDetalhamento;
        }

        public XFrmFechamento_OLD(Venda venda, XFrmVenda xFrmProposta)
            : this(venda)
        {
            this.xFrmProposta = xFrmProposta;
        }

        #endregion Construtores

        #region Eventos

        private void XFrmDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ilustrador.Running = false;
                this.Dispose();
            }
            else if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                printProposta();
            }

        }

        /// <summary>
        /// Salvar a proposta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtbFinalizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var vlrRecebido = ParseUtil.ToDecimal(txtVlrRecebido.Text);
            var vlrTroco = ParseUtil.ToDecimal(lblVlrTroco.Text);

            //nao mapeado
            this.propostaBase.ValorRecebido = vlrRecebido;
            this.propostaBase.ValorTroco = vlrTroco;
            //seta os valores
            this.propostaBase.Desconto = propostaBase.Desconto;
            this.propostaBase.ValorDesconto = propostaBase.ValorDesconto;
            this.propostaBase.TotalVenda = propostaBase.TotalVenda;

            if (this.propostaBase.ValorRecebido < this.propostaBase.TotalVenda)
            {
                XMessageIts.Advertencia("Informe o valor recebido !", "Atenção");
            }

            else if (this.propostaBase.ValorDesconto > this.propostaBase.TotalVenda)
            {
                XMessageIts.Advertencia("Valor do desconto não pode ser superior ao valor da proposta");
            }

            else if(this.propostaBase.ValorRecebido < this.propostaBase.TotalVenda)
            {
                XMessageIts.Advertencia("Valor do recebido inferior ao valor da proposta", 
                    "Valor Insuficiente");

            }
            else { 

            var msg = "A proposta será finalizada\n\nValor : R$ "
                + this.proposta.TotalVenda.ToString("N2");

            var op = XMessageIts.Confirmacao(msg, "Confirmar fechamento ?");

                if (op == DialogResult.Yes)
                {
                    //atualiza o objeto original
                    this.proposta.Update(this.propostaBase);

                    bool transation = new VendaDaoManager().FecharProposta(this.proposta);

                    //venda ou cotação exibe o flag de impressao
                    if (transation)
                    {
                        showConfirmationProposta();
                        this.IsSucess = true;
                        this.Enabled = false;
                    }
                    else
                        this.IsSucess = false;
                }
            }

        }

        private void XFrmFechamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            //se o form existe e nao esta sendo usado
            if (this.xFrmDetalhamento != null && !this.xFrmDetalhamento.Visible)
            {
                //libere o objeto
                this.xFrmDetalhamento.Dispose();
            }
            //se o form existe e nao esta sendo usado
            else if (this.xFrmProposta != null && !this.xFrmProposta.Visible)
            {
                //libere o objeto
                this.xFrmProposta.Dispose();
            }
        }

        private void txtDesconto_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            calcularTroco();
        }
 
        private void txtVlrRecebido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                calcularTroco();
        }

        private void txtDesconto_EditValueChanged(object sender, EventArgs e)
        {
            calcularTroco();
        }

        private void txtVlrRecebido_EditValueChanged(object sender, EventArgs e)
        {
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

        private void barBtnVoltar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //se for uma venda prazo verifique se a forma de pagamento foi chamada
            if (this.xFrmDetalhamento != null)
            {
                this.Hide();
                this.xFrmDetalhamento.Show();
            }
            //se for a vista então chame a tela de venda
            else if (this.xFrmProposta != null)
            {
                this.Hide();
                this.xFrmProposta.Show();
            }
        }

        #endregion Eventos

        #region Calculos

        private Venda indexarCampos(Venda v)
        {
            if (v != null)
            {
                txtVlrRecebido.Text = "0,00";
                if(v.Desconto != 0)
                    txtDesconto.Text = v.Desconto.ToString("N2");
                else
                    txtDesconto.Text = v.ValorDesconto.ToString("N2");

                lblValorDesconto.Text = v.ValorDesconto.ToString("N2");
                lblTotalVenda.Text = v.TotalVenda.ToString("N2");
            }
            return v.Clone();
        }

        private void calcularTroco()
        {
            int index = cbDescontoOp.SelectedIndex;
            //terei sempre o valor da proposta guardado
            this.propostaBase = proposta.Clone();
            var vlrRecebido = ParseUtil.ToDecimal(this.txtVlrRecebido.Text);
            var desconto = ParseUtil.ToDecimal(this.txtDesconto.Text);
            decimal troco = 0;

            //Calcule a porcentagem em seguinda o valor em reais
            if (index == 1)
            {
                this.propostaBase.Desconto = this.propostaBase.CalculaDesconto(this.propostaBase.TotalVenda, desconto);
                this.propostaBase.ValorDesconto = this.propostaBase.CalculaValorDesconto(this.propostaBase.TotalVenda, this.propostaBase.Desconto);

            }
            //Calcule o valor em reais em seguinda porcentagem
            else
            {
                this.propostaBase.ValorDesconto = this.propostaBase.CalculaValorDesconto(this.propostaBase.TotalVenda, desconto);
                this.propostaBase.Desconto = this.propostaBase.CalculaDesconto(this.propostaBase.TotalVenda, this.propostaBase.ValorDesconto);

            }
            //atualiza o total da proposta
            this.propostaBase.TotalVenda = propostaBase.CalculaTotalVenda(this.propostaBase.TotalVenda, 
                                                                            this.propostaBase.ValorDesconto);

            //seta a proposta apos o desconto
            this.lblTotalComDesconto.Text = this.propostaBase.TotalVenda.ToString("N2");

            //calcula o troco
            troco = propostaBase.CalculaTotalVenda(vlrRecebido, this.propostaBase.TotalVenda);

            this.lblVlrTroco.Text = troco.ToString("N2");
            this.lblValorDesconto.Text = this.propostaBase.ValorDesconto.ToString("N2");
            this.lblTotalVenda.Text = this.propostaBase.TotalVenda.ToString("N2");


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
            lblInfoImprimir.Visible = true;
            if (IsSucess)
            {
                //termina a thread
                //cuidado precisa ser false
                IsSucess = false;
                ilustrador.Running = IsSucess;
                var v = new BalcaoContext().VendaDao.FindAll().LastOrDefault();
                new RptNotaVendaBobina(v).Run();
                this.Dispose();
            }
            else
                XMessageIts.Advertencia("Você não pode imprimir uma proposta que ainda não foi fechada!",
                    "Atençao: Venda não realizada");
        }

        private void showConfirmationProposta()
        {
            //Flag para ativar a Thread
            IsSucess = true;

            //desabilite tudo
            ComponenteUtil.DesabilitarComponentes(new Component[]  { 
                                    barBtbFinalizar,txtDesconto,lblTotalVenda,
                                    txtDesconto });

            //Task para exibir mensagem de impressao
            //Task.Run(() => this.showMessagePrintProposta());

            Task.Run(() => ilustrador.RunOscillate());
        }

        #endregion Flag de impressao

    }
}