using System;
using System.ComponentModel;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.Enumeradores;
using ITSolution.Framework.Util;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.GuiUtil;

namespace ITE.Financeiro.Forms.View
{
    public partial class XFrmAddLancamentoExtrato : DevExpress.XtraEditors.XtraForm
    {
        private ExtratoBancario _extratoAnt;
        private FormTypeAction _acao;

        public XFrmAddLancamentoExtrato()
        {
            InitializeComponent();
            cbOperacao.Properties.Items.AddRange(Enum.GetValues(typeof(TypeExtratoBancario)));
        }

        public XFrmAddLancamentoExtrato(ExtratoBancario extrato, FormTypeAction acao = FormTypeAction.Nenhum) : this()
        {
            this._extratoAnt = extrato;
            this._acao = acao;
            IndexarDados(extrato);
        }

        //indexar o formulario
        private ExtratoBancario IndexarDados(ExtratoBancario extrato)
        {
            lookUpContaBancaria1.ContaBancaria = extrato.ContaBancaria;
            lookUpFilial1.Filial = extrato.FilialExtrato;
            lookUpCentroCusto1.CentroCusto = extrato.CentroCusto;
            //indexado a partir 0
            cbOperacao.SelectedIndex = (int)extrato.TipoExtrato;
            cbOperacao.Text = extrato.TipoExtrato.ToString();
            cbOperacao.Refresh();
            dtExtrato.DateTime = extrato.DataExtrato;

            if (extrato.DataCompensacao != null)
                dtCompensacao.DateTime = extrato.DataCompensacao.Value;

            chkCompensado.Checked = extrato.Compensado;
            txtNumeroDoc.Text = extrato.NumeroDocumento;
            txtHistorico.Text = extrato.Historico;
            txtValorExtrato.Text = extrato.ValorExtrato.ToString("n2");

            InativarComponentes();

            return extrato;
        }

        private ExtratoBancario IndexarExtrato()
        {
            try
            {
                var extratoNew = new ExtratoBancario();
                extratoNew.Historico = txtHistorico.Text;
                extratoNew.NumeroDocumento = txtNumeroDoc.Text;
                extratoNew.DataExtrato = dtExtrato.DateTime;
                extratoNew.ValorExtrato = ParseUtil.ToDecimal(txtValorExtrato.Text);
                extratoNew.CentroCusto = lookUpCentroCusto1.CentroCusto;
                extratoNew.IdCentroCusto = lookUpCentroCusto1.CentroCusto.IdCentroCusto;

                extratoNew.ContaBancaria = lookUpContaBancaria1.ContaBancaria;
                extratoNew.IdContaBancaria = lookUpContaBancaria1.ContaBancaria.IdContaBancaria;

                extratoNew.FilialExtrato = lookUpFilial1.Filial;
                extratoNew.IdFilial = lookUpFilial1.Filial.IdFilial;

                //cheque
                extratoNew.NumeroCheque = txtNumCheque.Text;
                extratoNew.BancoCheque = txtBancoCheque.Text;
                extratoNew.NumeroContaEmissorCheque = txtContaEmissorChq.Text;
                extratoNew.EmissorCheque = txtNomeEmissorCheque.Text;
                extratoNew.AgenciaCheque = txtAgenciacheque.Text;

                if (dtPreDatado.DateTime.Year != 1)
                    extratoNew.DataChequePreDatado = dtPreDatado.DateTime;
                else
                    extratoNew.DataChequePreDatado = null;

                if (chkCompensado.Checked)
                {
                    extratoNew.Compensado = true;
                    extratoNew.DataCompensacao = dtCompensacao.DateTime;
                }

                if (cbOperacao.SelectedIndex != -1) //se selecionou algum...
                    extratoNew.TipoExtrato = (TypeExtratoBancario)cbOperacao.SelectedIndex;
                else //senao defina como saque
                    extratoNew.TipoExtrato = TypeExtratoBancario.SaqueManual;

                if(extratoNew.TipoExtrato == TypeExtratoBancario.SaqueManual ||
                    extratoNew.TipoExtrato == TypeExtratoBancario.SaqueNaBaixa)
                {
                    extratoNew.ValorExtrato = extratoNew.ValorExtrato * -1;
                }

                return extratoNew;
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
                return null;
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var ctx = new BalcaoContext();
                var extAdd = IndexarExtrato();
                extAdd.CentroCusto = null;
                extAdd.ContaBancaria= null;
                extAdd.FilialExtrato = null;

                if (_acao == FormTypeAction.Salvar)
                {
                    if (ctx.ExtratoBancarioDao.Save(extAdd))
                    {
                        XMessageIts.Mensagem("Extrato incluido com sucesso!");
                        this.Dispose();
                    }
                }
                else //atualizar
                {
                    var extratoUpd = ctx.ExtratoBancarioDao.Find(_extratoAnt.IdExtrato);
                    extratoUpd.Update(extAdd);
                    _extratoAnt.Update(extAdd);
                    if (ctx.ExtratoBancarioDao.Update(extratoUpd))
                    {
                        XMessageIts.Mensagem("Extrato atualizado com sucesso!");
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
            }
            
        }

        private void cbOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOperacao.SelectedIndex == 4) //transferencia
            {
                grpContaDestino.Visible = true;
                this.Refresh();
            }
        }

        private void InativarComponentes()
        {
            lookUpFilial1.Enabled = false;
            lookUpContaBancaria1.Enabled = false;

            lookUpFilial2.Enabled = false;
            lookUpContaBancaria2.Enabled = false;

            ComponenteUtil.DesabilitarComponentes(new Component[]
            {
                lookUpCentroCusto1,
                lookUpContaBancaria1,
                lookUpFilial1,
                cbOperacao,
                dtExtrato,
                txtValorExtrato
            });
        }

        private void chkCompensado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCompensado.Checked)
            {
                labelControl3.Visible = true;
                dtCompensacao.Visible = true;
                this.Refresh();
            }
            else
            {
                labelControl3.Visible = false;
                dtCompensacao.Visible = false;
                this.Refresh();
            }
        }
    }
}