using System;
using ITE.Entidades.DaoManager;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.UnitControl;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITSolution.Framework.Validador;

namespace ITE.Financeiro.Forms.Caixa
{
    public partial class XFrmAddMovimentoCaixa : DevExpress.XtraEditors.XtraForm
    {
        
        private TypeMovimentacaoMonetaria _movimento;
        private string _saldo;
        public XFrmAddMovimentoCaixa(TypeMovimentacaoMonetaria movimento )
        {
            InitializeComponent();
            dtEditMovimento.DateTime = DateTime.Now;
            this._movimento = movimento;
            new TextEditUtil(this.txtValorMovimento, "", 2).CustomizeNumberField();
            FormsUtil.AddShortcutEscapeOnDispose(this);
            if (movimento == TypeMovimentacaoMonetaria.Credito)
            {
                this.Text = "Depósito";
                this.txtHistorico.Properties.NullText = "Motivo do depósito";
                this.txtHistorico.Properties.NullValuePrompt = "Motivo do depósito";
                this.barChAbertura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

            }
            else
            {
                this.Text = "Saque";
                this.txtHistorico.Properties.NullText = "Motivo do retirada";
                this.txtHistorico.Properties.NullValuePrompt = "Motivo do retirada";
                this.barChFechamento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

            }

            this._saldo = new CaixaDaoManager().GetSaldoDinheiro().ToString("N2");
            lblSaldo.Text = lblSaldo.Text + " : " + _saldo;
        }

        private MovimentoCaixa indexarDados()
        {
            MovimentoCaixa novo = new MovimentoCaixa
            {
                ValorMovimento = ParseUtil.ToDecimal(txtValorMovimento.Text),
                HistoricoMov = txtHistorico.Text,
                DataMovimento = dtEditMovimento.DateTime,
                TipoMov = _movimento
            };

            novo.IdUsuario = UnitWork.Usuario.IdUsuario;
            return novo;
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            var novo = indexarDados();

            if (ValidadorDTO.ValidateWarningAll(novo))
            {
                var manager = new CaixaDaoManager();

                if (_movimento == TypeMovimentacaoMonetaria.Credito)
                {
                    if(manager.AddMovimentoCaixa(novo))
                    {
                        XMessageIts.Mensagem("Depósito efetuado com sucesso.");
                        this.Dispose();
                    }
                }
                else
                {
                    if (manager.GetSaldoDinheiro() >= novo.ValorMovimento)
                    {
                        if (manager.AddMovimentoCaixa(novo))
                        {
                            XMessageIts.Mensagem("Saque efetuado com sucesso.");
                            this.Dispose();
                        }
                    }else
                    {
                        XMessageIts.Advertencia("Saldo insuficiente.", "Aviso");
                    }
                }

            }
        }

        private void barChAbertura_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.txtHistorico.Text = "Abertura de caixa";
            this.txtValorMovimento.Text = "0,00";
        }

        private void barChFechamento_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.txtHistorico.Text = "Fechamento de caixa";
            this.txtValorMovimento.Text = _saldo;

        }
    }
}