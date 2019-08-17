using System;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.Repositorio;
using ITE.Entidades.UnitControl;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Financeiro.Forms.View
{
    public partial class XFrmAddContaBancaria : DevExpress.XtraEditors.XtraForm
    {
        private ContaBancaria _conta;

        public XFrmAddContaBancaria()
        {
            InitializeComponent();
            this.lookUpFilial1.FindSetFilial(UnitWork.Filial);
            this.dtEditInicial.DateTime = DateTime.Now;
        }

        public XFrmAddContaBancaria(ContaBancaria conta) : this()
        {
            this._conta = conta;
            indexarDados(conta);
        }
        private ContaBancaria indexarDados(ContaBancaria conta)
        {
            txtCodigoConta.Text = conta.CodigoContaBancaria;
            txtDescConta.Text = conta.DescricaoContaBancaria;
            txtSaldoInicial.Text = conta.SaldoInicial.ToString("N2");
            txtNumeroConta.Text = conta.NumeroConta;
            dtEditInicial.DateTime = conta.DataAbertura;
            lookUpFilial1.Filial = conta.Filial;

            txtNomeBanco.Text = conta.NomeBanco;
            txtNumAgencia.Text = conta.Agencia;
            txtDescConta.Text = conta.DescricaoContaBancaria;
            rdTipoConta.SelectedIndex = (int)conta.TipoConta;

            return conta;
        }
        private ContaBancaria indexarDados()
        {

            DateTime? dt = dtEditInicial.DateTime;

            if (dt.ValidateDate() != null)
            {
                var filial = lookUpFilial1.Filial;
                string cod = txtCodigoConta.Text;
                string descricao = txtDescConta.Text;
                decimal saldo = ParseUtil.ToDecimal(txtSaldoInicial.Text);


                ContaBancaria cb = new ContaBancaria(filial.IdFilial, cod, descricao, saldo, dt.Value);
                cb.Agencia = txtNumAgencia.Text;
                cb.NomeBanco = txtNomeBanco.Text;
                cb.NumeroConta = txtNumeroConta.Text;
                cb.TipoConta = (TypeContaBancaria)rdTipoConta.SelectedIndex;

                if (_conta != null)
                {
                    cb.IdContaBancaria = this._conta.IdContaBancaria;
                }
                return cb;
            }
            else
            {
                XMessageIts.Advertencia("Informe a data de aberuta da conta");
            }
            return null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var novo = indexarDados();
                    if (novo.IdContaBancaria == 0)
                    {
                        if (ctx.ContaBancariaDao.Save(novo))
                        {
                            XMessageIts.Mensagem("Conta aberta com sucesso!");
                            this.Dispose();
                        }

                    }
                    else
                    {
                        var current = ctx.ContaBancariaDao.Find(novo.IdContaBancaria);
                        current.Update(novo);
                        if (ctx.ContaBancariaDao.Update(current))
                        {
                            XMessageIts.Mensagem("Conta atualizada com sucesso!");
                            this.Dispose();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Falha ao salvar conta!");
            }

        }
    }
}