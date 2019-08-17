using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ITE.Entidades.POCO;
using ITE.Entidades.UnitControl;
using ITSolution.Framework.Entities.Embedded;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.Repositorio;
using ITE.Entidades.POCO.RH.Folha;
using ITSolution.Framework.Util;
using ITE.Entidades.DaoManager.RHDaoManager;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.GuiUtil;
using ITSolution.Scheduler.EntidadesBd;
using System.Threading;

namespace ITE.RH.Forms.Folha
{
    public partial class ucFechFolhaParams : ItsControl
    {
        private Usuario userLogado;
        private ITSolution.Scheduler.EntidadesBd.TaskIts parametros;

        public ucFechFolhaParams()
        {

            if (!DesignMode)
            {
                InitializeComponent();
                parametros = new ITSolution.Scheduler.EntidadesBd.TaskIts()
                {
                    Classe = "ITE.Entidades.DaoManager.RHDaoManager.FolhaDaoManager, ITE.Entidades, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
                    DescricaoTarefa = "Calculo Folha Pagamento",
                    Metodo = "ExecutaCalculoFolha",
                    IdUsuario = UnitWork.Usuario.IdUsuario
                };

            }
        }

        private TypeTipoFechamentoFolha IndexTipoFechamento()
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

        private void cbGrupoEvento_EditValueChanged(object sender, EventArgs e)
        {
            var grpSel = cbGrupoEvento.SelectedItem as GrupoEvento;

            if (grpSel != null)
                gridControl1.DataSource = grpSel.EventosGrupo.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var grupoSelect = cbGrupoEvento.SelectedItem as GrupoEvento;
            if (grupoSelect != null)
            {
                var dtPeriodo = (cbPeriodo.SelectedItem as CalendarMonth).DateTime;
                dtPeriodo = DataUtil.GetDataFinalDoMes(dtPeriodo);

                Task<bool> myTask = new Task<bool>(
                    () => new FolhaDaoManager()
                    .ExecutaCalculoFolha(dtPeriodo, userLogado, IndexTipoFechamento(),
                    grupoSelect, chkConsGrpFunc.Checked, new System.Threading.CancellationTokenSource()));


                var tempo = TaskWatch.StartTaskWatch(myTask);

                var message = "Geração da folha de pagamento. -> " + DateTime.Now +
                    "\n Tempo gasto: 0" + tempo.Hours + ":0" + tempo.Minutes + ":" + tempo.Seconds + ":" + tempo.Milliseconds;

                LoggerUtilIts.WriteOnEventViewer(message);

                if (myTask.Result)
                {
                    XMessageIts.Mensagem("Competencia criada com sucesso");
                    this.Dispose();
                }
            }
            else
            {
                XMessageIts.Advertencia("Selecione um grupo de eventos para efetuar o cálculo da folha.");
            }
        }

        private void ucFechFolhaParams_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                FillCbGrupoEventos();
                this.userLogado = UnitWork.Usuario;
                cbPeriodo.Properties.Items.AddRange(CalendarMonth.Calendar.CalendarMonths);
                cbPeriodo.SelectedItem = DateTime.Now;
            }
        }
        public override TaskIts IndexScheduleJob()
        {
            try
            {
                List<TaskParamIts> parameters = new List<TaskParamIts>();

                var dtPeriodo = (cbPeriodo.SelectedItem as CalendarMonth).DateTime;
                dtPeriodo = DataUtil.GetDataFinalDoMes(dtPeriodo);
                var grupoSelect = cbGrupoEvento.SelectedItem as GrupoEvento;
                var tpFechamento = IndexTipoFechamento();
                var consGrpEvtFunc = chkConsGrpFunc.Checked;
                var cts = new CancellationTokenSource();
                var usuario = new Usuario()
                {
                    IdUsuario = userLogado.IdUsuario,
                    NomeUsuario = userLogado.NomeUsuario,
                    NomeUtilizador = userLogado.NomeUtilizador
                };

                var classe = "ITE.Entidades.DaoManager.RHDaoManager.FolhaDaoManager, ITE.Entidades, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null";
                var descricaoTarefa = "Calculo Folha Pagamento";
                var metodo = "ExecutaCalculoFolha";
                var idProcess = "{BA501F85-6216-466F-8534-C650F6E57A94}";


                var p_periodo = new TaskParamIts(dtPeriodo.GetType(), "periodo", dtPeriodo);
                var p_usuario = new TaskParamIts(usuario.GetType(), "usuario", usuario);
                var p_tipoFech = new TaskParamIts(tpFechamento.GetType(), "tipoFechamento", tpFechamento);
                var p_grpEvento = new TaskParamIts(grupoSelect.GetType(), "grupoEvento", grupoSelect);
                var p_cnsGf = new TaskParamIts(consGrpEvtFunc.GetType(), "considerGrpFunc", consGrpEvtFunc);
                var p_cancel = new TaskParamIts(typeof(CancellationTokenSource), "cts", cts.ToString());

                parameters.Add(p_periodo);
                parameters.Add(p_usuario);
                parameters.Add(p_tipoFech);
                parameters.Add(p_grpEvento);
                parameters.Add(p_cnsGf);
                parameters.Add(p_cancel);

                var bytes = SerializeIts.SerializeObject(parameters);

                base.SchedulerJob = new TaskIts(Guid.NewGuid().ToString(), 1, 1, userLogado.IdUsuario, classe, metodo,
                                descricaoTarefa, idProcess, bytes);

                
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Por favor preencha todos os parametros");
            }

            return base.SchedulerJob;
        }
        private  void OnLeave2(EventArgs e)
        {
            try
            {
                List<TaskParamIts> parameters = new List<TaskParamIts>();

                var dtPeriodo = (cbPeriodo.SelectedItem as CalendarMonth).DateTime;
                dtPeriodo = DataUtil.GetDataFinalDoMes(dtPeriodo);
                var grupoSelect = cbGrupoEvento.SelectedItem as GrupoEvento;
                var tpFechamento = IndexTipoFechamento();
                var consGrpEvtFunc = chkConsGrpFunc.Checked;
                var cts = new CancellationTokenSource();
                var usuario = new Usuario()
                {
                    IdUsuario = userLogado.IdUsuario,
                    NomeUsuario = userLogado.NomeUsuario,
                    NomeUtilizador = userLogado.NomeUtilizador
                };

                var classe = "ITE.Entidades.DaoManager.RHDaoManager.FolhaDaoManager, ITE.Entidades, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null";
                var descricaoTarefa = "Calculo Folha Pagamento";
                var metodo = "ExecutaCalculoFolha";
                var idProcess = "{BA501F85-6216-466F-8534-C650F6E57A94}";


                var p_periodo = new TaskParamIts(dtPeriodo.GetType(), "periodo", dtPeriodo);
                var p_usuario = new TaskParamIts(usuario.GetType(), "usuario", usuario);
                var p_tipoFech = new TaskParamIts(tpFechamento.GetType(), "tipoFechamento", tpFechamento);
                var p_grpEvento = new TaskParamIts(grupoSelect.GetType(), "grupoEvento", grupoSelect);
                var p_cnsGf = new TaskParamIts(consGrpEvtFunc.GetType(), "considerGrpFunc", consGrpEvtFunc);
                var p_cancel = new TaskParamIts(typeof(CancellationTokenSource), "cts", cts.ToString());

                parameters.Add(p_periodo);
                parameters.Add(p_usuario);
                parameters.Add(p_tipoFech);
                parameters.Add(p_grpEvento);
                parameters.Add(p_cnsGf);
                parameters.Add(p_cancel);

                var bytes = SerializeIts.SerializeObject(parameters);

                base.SchedulerJob = new TaskIts(Guid.NewGuid().ToString(), 1, 1, userLogado.IdUsuario, classe, metodo,
                                descricaoTarefa, idProcess, bytes);
                //ITSolution.Framework.Arquivos.FileManagerIts.WriteBytesToFile(ITSolution.Framework.Arquivos.FileManagerIts.DeskTopPath + "\\Task", bytes);

            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Por favor preencha todos os parametros");
            }
        }
    }
}
