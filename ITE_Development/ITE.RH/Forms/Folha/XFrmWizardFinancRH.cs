using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ITE.Entidades.DaoManager.RHDaoManager;
using ITE.Entidades.Enumeradores.RHEnum;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.RH.Folha;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITSolution.Framework.Dao.Contexto;
using ITSolution.Framework.Enumeradores;

namespace ITE.RH.Forms.Folha
{
    public partial class XFrmWizardFinancRH : DevExpress.XtraEditors.XtraForm
    {
        private Usuario usuario;
        private CompetenciaFolha competencia;
        private bool reprocessamento = false;

        private FolhaDaoManager.ParamsGerarFinanceiro parametros;

        public XFrmWizardFinancRH()
        {
            InitializeComponent();
            chkGerarFinanceiro.Checked = true;
        }
        public XFrmWizardFinancRH(CompetenciaFolha competencia, Usuario usuario, EmpresaFilial filial, bool reprocessamento = false) : this()
        {
            this.competencia = competencia;
            this.usuario = usuario;
            this.reprocessamento = reprocessamento;

            init(filial);

        }
        private void init(EmpresaFilial filial)
        {
            try
            {
                lookUpFilial1.FindSetFilial(filial);

                if (reprocessamento)
                {
                    welcomeWizardPageRHFinanc.Text = "Geração de lançamentos financeiros";
                    welcomeWizardPageRHFinanc.IntroductionText = "Este assistente irá guia-lo até a geração completa dos lançamentos financeiros da competência escolhida.";
                    chkGerarFinanceiro.Visible = false;
                }

                int idCentroCustoRH = ParseUtil.ToInt(ParametroManager
                                                .FindParamByTypeParametro(TypeParametro.centro_custo_folha)
                                                            .ValorParametro);

                lookUpCentroCusto1.FindSetCentroCusto(idCentroCustoRH.ToString());

                int idCliForRH = ParseUtil.ToInt(ParametroManager
                                            .FindParamByTypeParametro(TypeParametro.clifor_folha)
                                                        .ValorParametro);

                lookUpCliFor1.FindSetCliFor(idCliForRH.ToString());

                if (lookUpCliFor1.CliFor == null && lookUpCentroCusto1.CentroCusto == null)
                {
                    lookUpCentroCusto1.Enabled = true;
                    lookUpCliFor1.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
            }

        }
        private void wizardPageConfiguracoes_PageCommit(object sender, EventArgs e)
        {
            //gerar os lancamentos financeiros se estiver marcado e se estiver fechando a comp. (nao reprocessamento)
            if (!reprocessamento)
            {
                if (encerrar())
                    XFrmWait.StartTask(gerar(), this);
            }
            else
            {
                //se a competencia foi encerrada sem gerar os lancamentos, é um reprocessamento
                //entao só gere os lancamentos financeiros...
                XFrmWait.StartTask(gerar(), this);
            }
        }

        private void chkBaixarLancamentos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBaixarLancamentos.Checked)
            {
                groupControl2.Visible = true;
            }
            else
            {
                groupControl2.Visible = false;
            }
        }
        private async Task gerar()
        {
            if (chkGerarFinanceiro.Checked)
            {
                var mang = new FolhaDaoManager();
                await mang.GerarFinanceiro(this.parametros);
            }
        }

        private void wizardPageConfiguracoes_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {

            this.parametros = indexParams();

        }
        private FolhaDaoManager.ParamsGerarFinanceiro indexParams()
        {
            var cliFor = lookUpCliFor1.CliFor;
            var centro = lookUpCentroCusto1.CentroCusto;
            var filial = lookUpFilial1.Filial;
            var tipoGeraca = IndexTipoFechamento();
            var conta = lookUpContaBancaria1.ContaBancaria;
            var formaPagto = lookUpFormaPagamento1.FormaPagto;

            var parametros = new FolhaDaoManager.ParamsGerarFinanceiro()
            {
                Filial = filial,
                CentroCusto = centro,
                CliFor = cliFor,
                Data = datePikData.Value,
                DataVencimento = datePikVencimento.Value,
                TipoGeracao = tipoGeraca,
                Competencia = competencia,
                Usuario = usuario
            };
            if (chkBaixarLancamentos.Checked)
            {
                parametros.BaixarLancamento = true;
                parametros.ContaBancaria = conta;
                parametros.DataBaixa = datePikDtBaixa.Value;
                parametros.FormaPagamento = formaPagto;
            }

            return parametros;
        }

        private TypeGeracaoFinanceiroFolha IndexTipoFechamento()
        {
            var tipo = TypeGeracaoFinanceiroFolha.Sintetico; //padrão

            if (cbTipoGeracao.SelectedIndex == 0)
                return tipo;
            else if (cbTipoGeracao.SelectedIndex == 1)
                return TypeGeracaoFinanceiroFolha.Analitico;
            else
                return TypeGeracaoFinanceiroFolha.Sintetico;
        }

        private void welcomeWizardPageRHFinanc_PageCommit(object sender, EventArgs e)
        {
            //se desmarcado, so encerra a competencia
            if (!chkGerarFinanceiro.Checked)
            {
                wizardControl1.SelectedPage = completionWizardPageRHFinanc;
            }
        }
        private bool encerrar()
        {
            if (!reprocessamento) //se for false
            {
                var manager = new FolhaDaoManager();
                return manager.EncerramentoCompetencia(competencia, chkGerarFinanceiro.Checked);
            }
            return false;
        }
    }
}