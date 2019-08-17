using System;
using ITSolution.Framework.Util;
using System.Threading;
using ITSolution.Scheduler.EntidadesBd;
using System.Collections.Generic;
using ITSolution.Scheduler.Repositorio;
using ITE.Entidades.DaoManager;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO.RH.Folha;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using System.Linq;
using ITE.Entidades.UnitControl;

namespace ITSolution.Scheduler.Forms
{
    public partial class XFrmAddNewTask : DevExpress.XtraEditors.XtraForm
    {
        private CancellationTokenSource cts;

        public XFrmAddNewTask()
        {
            InitializeComponent();
            var ctx = SchedulerContextGeneric<ProcessIts>.Instance;
            cbProcesso.Properties.Items.AddRange(ctx.Dao.FindAll());
            FillCbGrupoEventos();
        }

        public XFrmAddNewTask(CancellationTokenSource cts) : this()
        {
            this.cts = cts;
        }
        private TaskIts indexarTarefa()
        {
            var proccessSelected = cbProcesso.SelectedItem as ProcessIts;
            if (proccessSelected != null)
            {
                memDescProcess.Text = proccessSelected.DescricaoProcesso;

                if (proccessSelected.CodigoProcesso == "INS_TSTE")
                {
                    //List<TaskParamIts> parameters = new List<TaskParamIts>();
                    //var vezes = ParseUtil.ToInt(txtNumVezes.Text);
                    //var schedulerControl = new Scheduler.Manager.SchedulerControl();
                    //var id = Guid.NewGuid().ToString();
                    ////o que será gravado no banco
                    //var className = Type.GetType(proccessSelected.ClassName).FullName;

                    //var methodName = proccessSelected.Metodo;

                    //var arguments = String.Format("{0}, {1}, {2}", vezes, cts, id);

                    //var p = new TaskParamIts(vezes.GetType(), "nVezes", vezes);
                    //var p2 = new TaskParamIts(typeof(String), "taskId", id);
                    //var p1 = new TaskParamIts(typeof(CancellationTokenSource), "cts", cts.ToString());
                    //parameters.Add(p);
                    //parameters.Add(p2);
                    //parameters.Add(p1);

                    //var bytes = SerializeIts.SerializeObject(parameters);

                    //var task = new TaskIts(id, 1, 1, 1, className, methodName, 
                    //    proccessSelected.NomeProcesso, proccessSelected.IdProcess, bytes);

                    //schedulerControl.CreateTask(task, cts);
                    //return task;
                }
                else if(proccessSelected.CodigoProcesso == "FEC_FOLHA")
                {
                    try
                    {
                        List<TaskParamIts> parameters = new List<TaskParamIts>();
                        //FillCbGrupoEventos();

                        var periodo = dtPeriodo.DateTime;
                        var usuario = UnitWork.Usuario;
                        var n_usuario = new ITE.Entidades.POCO.Usuario();
                        n_usuario.Update(usuario);
                        n_usuario.IdUsuario = usuario.IdUsuario;
                        var tipoFechamento = IndexTipoFechamentoFolha();
                        var grupoEvento = cbGrupoEvento.SelectedItem as GrupoEvento;
                        var consGrpEvtFunc = chkConsdGrpFunc.Checked;


                        var schedulerControl = new Scheduler.Manager.SchedulerControl();
                        var id = Guid.NewGuid().ToString();
                        //o que será gravado no banco
                        var className = proccessSelected.ClassName;

                        var methodName = proccessSelected.Metodo;

                        var p_periodo = new TaskParamIts(periodo.GetType(), "periodo", periodo);
                        var p_usuario = new TaskParamIts(usuario.GetType().BaseType, "usuario", n_usuario);
                        var p_tipoFech = new TaskParamIts(tipoFechamento.GetType(), "tipoFechamento", tipoFechamento);
                        var p_grpEvento = new TaskParamIts(grupoEvento.GetType(), "grupoEvento", grupoEvento);
                        var p_cnsGf = new TaskParamIts(consGrpEvtFunc.GetType(), "considerGrpFunc", consGrpEvtFunc);
                        var p_cancel = new TaskParamIts(typeof(CancellationTokenSource), "cts", cts.ToString());

                        parameters.Add(p_periodo);
                        parameters.Add(p_usuario);
                        parameters.Add(p_tipoFech);
                        parameters.Add(p_grpEvento);
                        parameters.Add(p_cnsGf);
                        parameters.Add(p_cancel);                        

                        var bytes = SerializeIts.SerializeObject(parameters);

                        var task = new TaskIts(id, 1, 1, 1, className, methodName,
                            proccessSelected.NomeProcesso, proccessSelected.IdProcess, bytes);

                        schedulerControl.CreateTask(task, cts);
                        return task;
                    }
                    catch (Exception ex)
                    {

                        XMessageIts.ExceptionMessage(ex);
                    }
                    
                }
                    return null;
            }
            return null;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var tarefa = indexarTarefa();
            this.Close();
        }
        private TypeTipoFechamentoFolha IndexTipoFechamentoFolha()
        {
            var tipo = TypeTipoFechamentoFolha.Mensal; //padrão

            if (cbTipoFechamento.SelectedIndex == 0 || cbTipoFechamento.SelectedIndex == -1)
                return tipo;
            else if (cbTipoFechamento.SelectedIndex == 1)
                tipo = TypeTipoFechamentoFolha.Quinzenal;
            else if (cbTipoFechamento.SelectedIndex == 2)
                tipo = TypeTipoFechamentoFolha.Semanal;

            return tipo;
        }

        private void FillCbGrupoEventos()
        {
            var ctx = new BalcaoContext();
            ctx.LazyLoading(false);
            ctx.Configuration.ProxyCreationEnabled = false;

            var grupos = ctx.GrupoEvento.Include("EventosGrupo").Include("EventosGrupo.Evento").ToList(); //ctx.GrupoEventoDao.FindAll();

            cbGrupoEvento.Properties.Items.AddRange(grupos);
            cbGrupoEvento.Refresh();
        }

        private void cbProcesso_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadProcesso();
        }

        private void loadProcesso()
        {
            var proccessSelected = cbProcesso.SelectedItem as ProcessIts;
            if(proccessSelected != null)
            {
                memDescProcess.Text = proccessSelected.DescricaoProcesso;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}