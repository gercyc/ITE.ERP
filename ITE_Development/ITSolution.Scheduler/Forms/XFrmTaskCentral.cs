using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.XtraBars;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Beans.Forms;
using System.Threading;
using ITSolution.Scheduler.Manager;
using ITSolution.Scheduler.EntidadesBd;
using ITSolution.Scheduler.Repositorio;
using ITSolution.Framework.Util;
using System.Collections.Generic;
using System.Reflection;
using ITE.Entidades.DaoManager.RHDaoManager;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Eventos.GridViewEvents;

/// <summary>
/// Utiliza invocação de metódos por reflexão
/// 
/// Perda significativa de performace
///
/// </summary>
namespace ITSolution.Scheduler.Forms
{
    public partial class XFrmTaskCentral : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        CancellationTokenSource cts;
        private readonly FocusRowChangedEvent _gridFocusUtil;

        public XFrmTaskCentral()
        {
            InitializeComponent();
            this._gridFocusUtil = new FocusRowChangedEvent(gridViewTasks);
        }
        private async Task carregarTarefas()
        {
            var ctx = SchedulerContextGeneric<TaskIts>.Instance;
            var result = await ctx.Dao.FindAllAsync();

            if (result != null)
            {

                gridControlTasks.DataSource = result.OrderByDescending(t => t.DtCriacao);
                this._gridFocusUtil.KeepFocusedRowChanged();
            }

        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ctx = SchedulerContextGeneric<TaskIts>.Instance;

            //gridControlTasks.DataSource = ctx.Dao.FindAll().OrderByDescending(t => t.DtCriacao);
            XFrmWait.StartTask(carregarTarefas());

        }

        private void btnNewTask_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.cts = new CancellationTokenSource();
            new XFrmAddNewTask(cts).ShowDialog();
            btnRefresh_ItemClick(null, null);
        }

        private void btnRemoverTarefa_ItemClick(object sender, ItemClickEventArgs e)
        {
            var taskSel = GridViewUtil.GetFocusedRow<TaskIts>(gridViewTasks);
            var ctx = SchedulerContextGeneric<TaskIts>.Instance;
            if (taskSel != null)
            {
                var taskRem = ctx.Dao.Find(taskSel.IdTask);
                ctx.Dao.Delete(taskRem);
                btnRefresh_ItemClick(null, null);
            }
        }

        private void btnDetTarefa_ItemClick(object sender, ItemClickEventArgs e)
        {
            var taskSel = GridViewUtil.GetFocusedRow<TaskIts>(gridViewTasks);
            if (taskSel != null)
            {
                XFrmOptionPane.ShowListTextArea<LogIts>(
                            taskSel.TaskDetails.OrderBy(l => l.DataLog).ToList(),
                            "Detalhes da tarefa:");
            }
        }

        private void btnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
            }
        }

        private async void btnStartExec_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.cts = new CancellationTokenSource();
            var taskSel = GridViewUtil.GetFocusedRow<TaskIts>(gridViewTasks);
            var sc = new SchedulerControl();

            //executa. nao precisa ver se e nulo, o metodo ja faz isso
            await sc.Execute(taskSel, cts);
        }

        private void XFrmTaskCentral_Shown(object sender, EventArgs e)
        {
            btnRefresh_ItemClick(null, null);
        }
    }
}