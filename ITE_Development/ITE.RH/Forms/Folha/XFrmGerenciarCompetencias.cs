using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Beans.ProgressBar;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.RH.Folha;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.DaoManager.RHDaoManager;
using ITE.Reports.Relatorios;
using ITE.Reports.Relatorios.RH;
using ITE.Reports.RH;
using ITE.Entidades.Enumeradores.RHEnum;
using ITSolution.Framework.Windows.BaseForms;

namespace ITE.RH.Forms.Folha
{
    public partial class XFrmViewCompetencias : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Usuario userLogado;
        private EmpresaFilial filialCurrent;

        public XFrmViewCompetencias()
        {
            InitializeComponent();
        }

        public XFrmViewCompetencias(Usuario userLogado, EmpresaFilial filial) : this()
        {
            this.userLogado = userLogado;
            this.filialCurrent = filial;

        }
        private async Task carregarCompetencias()
        {
            using (var ctx = new BalcaoContext())
            {

                var competencias = await ctx.CompetenciaFolhaDao.FindAllAsync();

                this.Invoke(new MethodInvoker(delegate
                {
                    gridControlCompetencias.DataSource = competencias;
                }));
            }

        }

        private void barBtnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarCompetencias(), "Carregando competências...");
        }


        private void barBtnShowMov_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridViewCompetencias.IsSelectOneRowWarning())
            {
                var comp = gridViewCompetencias.GetFocusedRow<CompetenciaFolha>();
                new XFrmMovimentoCompetencia(comp).ShowDialog();
            }
            else
                XMessageIts.Advertencia("Selecione uma linha para exibição!");
        }

        private void barBtnProxComp_ItemClick(object sender, ItemClickEventArgs e)
        {
            //FormsUtil.ShowDialog(new XFrmCalculoFolha());
            //FormsUtil.ShowDialog(new ITSolution.Scheduler.Forms.XFrmAddNewTask(new ucFechFolhaParams(), "FEC_FOLHA"));
            FormsUtil.ShowDialog(new ITSBasicJobForm(new ucFechFolhaParams()));
            barBtnRefresh_ItemClick(null, null);
        }

        private void barBtnImpRecibos_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridViewCompetencias.IsSelectOneRowWarning())
            {
                var comp = gridViewCompetencias.GetFocusedRow() as CompetenciaFolha;
                new RptHolerite(comp).Run();
            }
        }

        private void barBtnFecharCompetencia_ItemClick(object sender, ItemClickEventArgs e)
        {
            var comp = gridViewCompetencias.GetFocusedRow<CompetenciaFolha>();
            if (comp.Status == Entidades.Enumeradores.RHEnum.TypeStatusCompetencia.EmEdicao)
            {
                var msg = "Tem certeza que deseja encerrar a competência selecionada? \n Não será possível lançar novos eventos após o fechamento.";
                var manager = new FolhaDaoManager();
                var confirm = XMessageIts.Confirmacao(msg);
                try
                {
                    if (confirm == DialogResult.Yes)
                    {
                        var wiz = new XFrmWizardFinancRH(comp, userLogado, filialCurrent);
                        wiz.ShowDialog();

                        //if (manager.EncerramentoCompetencia(comp))
                        //    XMessageIts.Mensagem("Encerramento realizado com sucesso!");

                        barBtnRefresh_ItemClick(null, null);
                    }
                }
                catch (Exception ex)
                {
                    XMessageIts.ExceptionMessage(ex);
                }
            }
            else
            {
                XMessageIts.Mensagem("Competência já encerrada. Verifique o Status da linha selecionada.");
            }
        }

        private void barBtnRelatFolha_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridViewCompetencias.IsSelectOneRowWarning())
            {
            }
        }

        private void gridViewCompetencias_DoubleClick(object sender, EventArgs e)
        {
            barBtnShowMov_ItemClick(null, null);
        }

        private void XFrmViewCompetencias_Shown(object sender, EventArgs e)
        {
            barBtnRefresh_ItemClick(null, null);
        }

        private void barBtnRptLiqFolha_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridViewCompetencias.IsSelectOneRowWarning())
            {
                var comp = gridViewCompetencias.GetFocusedRow() as CompetenciaFolha;
                new RptListagemLiqFolha(comp).Run();
            }
        }

        private void barBtnCancelarMov_ItemClick(object sender, ItemClickEventArgs e)
        {
            var comp = gridViewCompetencias.GetFocusedRow<CompetenciaFolha>();
            if (comp.Status == TypeStatusCompetencia.EmEdicao)
            {
                var msg = "Tem certeza que deseja excluir a competência selecionada? \n Este processo é irreversível.";
                var manager = new FolhaDaoManager();
                var confirm = XMessageIts.Confirmacao(msg);
                try
                {
                    if (confirm == DialogResult.Yes)
                    {
                        if (manager.ExcluirCompetencia(comp))
                            XMessageIts.Mensagem("Exclusão realizada com sucesso!");

                        barBtnRefresh_ItemClick(null, null);
                    }
                }
                catch (Exception ex)
                {
                    XMessageIts.ExceptionMessage(ex);
                }
            }
            else
            {
                XMessageIts.Advertencia("Não é possível excluir uma competência já encerrada!");
            }
        }

        private void barBtnReabrir_ItemClick(object sender, ItemClickEventArgs e)
        {
            var comp = gridViewCompetencias.GetFocusedRow<CompetenciaFolha>();
            if (comp.Status == TypeStatusCompetencia.Encerrada || comp.Status == TypeStatusCompetencia.EncerradaFinanceiro)
            {
                var msg = "Tem certeza que deseja reabrir a competência selecionada?";
                var manager = new FolhaDaoManager();
                var confirm = XMessageIts.Confirmacao(msg);
                try
                {
                    if (confirm == DialogResult.Yes)
                    {
                        if (manager.ReabrirCompetencia(comp))
                            XMessageIts.Mensagem("Reabertura realizada com sucesso!");

                        barBtnRefresh_ItemClick(null, null);
                    }
                }
                catch (Exception ex)
                {
                    XMessageIts.ExceptionMessage(ex);
                }
            }
            else
            {
                XMessageIts.Advertencia("Não é possível reabrir uma competência ainda em edição!");
            }
        }

        private void barBtnGeraFinanceiro_ItemClick(object sender, ItemClickEventArgs e)
        {
            var comp = gridViewCompetencias.GetFocusedRow<CompetenciaFolha>();
            if (comp.Status == TypeStatusCompetencia.Encerrada)
            {
                var wiz = new XFrmWizardFinancRH(comp, userLogado, filialCurrent, true);

                wiz.ShowDialog();

                barBtnRefresh_ItemClick(null, null);
            }
            else
            {
                XMessageIts.Advertencia("Você escolher um reprocessamento, porém só é possível reprocessar o movimento financeiro para uma competência com status \'Encerrada\' e que não teve seus lançamentos gerados!");
            }

        }
    }
}