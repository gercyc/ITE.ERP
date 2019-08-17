using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITSolution.Scheduler.EntidadesBd;
using ITSolution.Scheduler.Enumeradores;
using ITSolution.Scheduler.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace ITSolution.Scheduler.Manager
{
    public class SchedulerControl : ISchedulerControl
    {
        
        public async Task Execute(TaskIts task, CancellationTokenSource cts)
        {
            if (task != null)
            {
                LogIts log;
                try
                {
                    //inicia
                    StartTask(task.IdTask, cts);

                    // Execute the task
                    var typeName = Type.GetType(task.Classe);
                    //var typeName2 = typeof(FolhaDaoManager);
                    
                    object instance = Activator.CreateInstance(typeName, null);
                    
                    var methodInfo = typeName.GetMethod(task.Metodo);
                    var param = methodInfo.GetParameters();
                    int i = 0;


                    List<TaskParamIts> parametrosTask = SerializeIts.DeserializeObject<List<TaskParamIts>>(task.Tarefa);
                    dynamic[] parmOrigs22 = new dynamic[parametrosTask.Count];
                    
                    log = new LogIts(task.IdTask, Thread.CurrentThread.ManagedThreadId.ToString(), "Parâmetros:", "");

                    //insere
                    await InsertLogTask(log);


                    foreach (var item in parametrosTask)
                    {

                        if (item.ParameterValue.ToString() == "System.Threading.CancellationTokenSource")
                        {
                            parmOrigs22[i] = cts;
                        }
                        else
                        {
                            log = new LogIts(task.IdTask, Thread.CurrentThread.ManagedThreadId.ToString(),
                                            item.ParameterName.ToString()
                                            + ": " + item.ParameterValue.ToString(), String.Empty);

                            //insere log
                            await InsertLogTask(log);
                            var stp = item.ParameterType.AssemblyQualifiedName;
                            var tp = Type.GetType(stp);
                            parmOrigs22[i] = item.ParameterValue;
                            //parmOrigs22[i] = Convert.ChangeType(item.ParameterValue,
                            //     tp);
                        }
                        i++;
                    }
                    //object[] parmOrigs = new object[] { 1000, task.IdTask, cts };
                    try
                    {
                        Task t1 = new Task(() =>
                        {
                            methodInfo.Invoke(instance, parmOrigs22);
                        });

                        await Task.Factory.StartNew(() => t1.Start());

                        Task ok = await Task.WhenAny(t1);
                        if ((ok.IsCompleted && ok.Exception == null) && !cts.IsCancellationRequested)
                        {
                            //Work task
                            await DoWorkTask(task.IdTask);
                        }
                        if (ok.Exception != null)
                        {
                            var msg = ok.Exception.InnerExceptions.First();
                            
                            throw new Exception(msg.InnerException.Message);
                        }

                        if (cts.IsCancellationRequested)
                            throw new OperationCanceledException("Operação cancelada.");
                    }
                    catch(OperationCanceledException exCancel)
                    {
                        log = new LogIts(task.IdTask,
                        Thread.CurrentThread.ManagedThreadId.ToString(),
                        exCancel.Message
                        , "Operacao cancelada");
                        await InsertLogTask(log);
                        SuspendTask(task.IdTask);

                    }
                    catch (TargetInvocationException tex)
                    {
                        log = new LogIts(task.IdTask,
                        Thread.CurrentThread.ManagedThreadId.ToString(),
                        tex.Message
                        , tex.Message);
                        await InsertLogTask(log);
                        await StoppedTaskException(task.IdTask);
                    }
                    catch (Exception ex)
                    {
                        log = new LogIts(task.IdTask,
                        Thread.CurrentThread.ManagedThreadId.ToString(),
                        ex.Message
                        , ex.Message);
                        await InsertLogTask(log);
                        await StoppedTaskException(task.IdTask);
                    }

                }//fim try
                catch (Exception ex)
                {
                    log = new LogIts(task.IdTask,
                        Thread.CurrentThread.ManagedThreadId.ToString(),
                        ex.Message
                        , ex.Message);
                    await InsertLogTask(log);
                    await StoppedTaskException(task.IdTask);
                }
            }
            
        }
       
        /// <summary>
        /// Cria uma tarefa no banco de dados.
        /// Retorna o guid da tarefa criada
        /// </summary>
        /// <returns>ID Tarefa</returns>
        public string CreateTask(TaskIts task, CancellationTokenSource cts)
        {
            try
            {
                var ctx = SchedulerContextGeneric<TaskIts>.Instance;
                ctx.Dao.Save(task);
                return task.IdTask;
            }
            catch (SerializationException se)
            {
                XMessageIts.ExceptionMessageDetails(se, "Erro");
                return "Ocorreu um erro!\n" + se.Message;

            }
            catch (Exception ex)
            {
                return "Ocorreu um erro!\n" + ex.Message;
            }
        }
   
        /// <summary>
        /// Conclui a tarefa selecionada
        /// </summary>
        /// <param name="idTask"></param>
        /// <returns></returns>
        public async Task DoWorkTask(string idTask)
        {
            try
            {
                var ctx = SchedulerContextGeneric<TaskIts>.Instance;
                var taskBd = ctx.Dao.Find(idTask);
                var msg = "Tarefa finalizada.";

                await InsertLogTask(new LogIts(idTask, Thread.CurrentThread.ManagedThreadId.ToString(), msg, string.Empty));
                //Muda o status da tarefa, data de execucao e salva
                taskBd.StatusTask = TaskStatusIts.Finalizada;
                taskBd.DtTermino = DateTime.Now;
                await ctx.Dao.UpdateAsync(taskBd);
            }
            catch (Exception ex)
            {
                await InsertLogTask(new LogIts(idTask, Thread.CurrentThread.ManagedThreadId.ToString(), string.Empty, ex.Message));
            }
        }

        /// <summary>
        /// Suspende a tarefa selecionada e lanca exception no log
        /// </summary>
        /// <param name="idTask"></param>
        /// <returns></returns>
        public async Task StoppedTaskException(string idTask)
        {
            try
            {
                var ctx = SchedulerContextGeneric<TaskIts>.Instance;
                var taskBd = ctx.Dao.Find(idTask);
                var msg = "Não foi possível concluír a tarefa escolhida. Verifique com o administrador!";

                await InsertLogTask(new LogIts(idTask, Thread.CurrentThread.ManagedThreadId.ToString(), msg, string.Empty));
                //Muda o status da tarefa, data de execucao e salva
                taskBd.StatusTask = TaskStatusIts.Erro;
                taskBd.DtTermino = DateTime.Now;
                await ctx.Dao.UpdateAsync(taskBd);
            }
            catch (Exception ex)
            {
                await InsertLogTask(new LogIts(idTask, Thread.CurrentThread.ManagedThreadId.ToString(), string.Empty, ex.Message));
            }
        }

        /// <summary>
        /// Insere uma linha de taskLog na tarefa
        /// </summary>
        /// <param name="idTask"></param>
        public Task InsertLogTask(LogIts taskLog)
        {
            var ctx = SchedulerContextGeneric<LogIts>.Instance;
            return ctx.Dao.SaveAsync(taskLog);
        }
        
        /// <summary>
        /// Iniciar uma determinada tarefa
        /// </summary>
        /// <param name="idTask"></param>
        /// <returns></returns>
        public async void  StartTask (string idTask, CancellationTokenSource cts)
        {
            try
            {
                var ctx = SchedulerContextGeneric<TaskIts>.Instance;
                var taskBd = ctx.Dao.Find(idTask);
                var msg = "Obtendo paramentros da tarefa, aguarde..";
                await InsertLogTask(new LogIts(idTask, Thread.CurrentThread.ManagedThreadId.ToString(), msg, String.Empty));
                await ScheduleTask(idTask);
                await ctx.Dao.UpdateAsync(taskBd);

                var result = Task.Delay(5000);
                if (result != null)
                {
                    msg = "Iniciando tarefa..";
                    await InsertLogTask(new LogIts(idTask, Thread.CurrentThread.ManagedThreadId.ToString(), msg, String.Empty));

                    //Muda o status da tarefa, data de execucao e salva
                    taskBd.StatusTask = TaskStatusIts.Executando;
                    taskBd.DtInicio = DateTime.Now;
                    taskBd.DtTermino = null;
                    await ctx.Dao.UpdateAsync(taskBd);                    
                }
            }
            catch (OperationCanceledException)
            {
                SuspendTask(idTask);
            }
            catch (Exception ex)
            {
                await InsertLogTask(new LogIts(idTask, "", string.Empty, ex.Message));
            }            
        }

        /// <summary>
        /// Suspender execução da tarefa
        /// </summary>
        /// <param name="idTask"></param>
        /// <returns></returns>
        public void SuspendTask(string idTask)
        {
            try
            {
                var ctx = SchedulerContextGeneric<TaskIts>.Instance;
                var taskBd = ctx.Dao.Find(idTask);
                var msgCancel = "Tarefa cancelada pelo usuário.";
                InsertLogTask(new LogIts(idTask, Task.CurrentId.ToString(), msgCancel, ""));
                
                //Muda o status da tarefa, data de execucao e salva
                taskBd.StatusTask = TaskStatusIts.Suspensa;
                taskBd.DtTermino = DateTime.Now;
                ctx.Dao.Update(taskBd);
            }
            catch (Exception ex)
            {
                InsertLogTask(new LogIts(idTask, Task.CurrentId.ToString(), string.Empty, ex.Message));
            }
        }

        public async Task ScheduleTask(string idTask)
        {
            try
            {
                var ctx = SchedulerContextGeneric<TaskIts>.Instance;
                var taskBd = ctx.Dao.Find(idTask);
                //Muda o status da tarefa, data de execucao e salva
                taskBd.StatusTask = TaskStatusIts.Agendada;
                await ctx.Dao.UpdateAsync(taskBd);
            }
            catch (Exception ex)
            {
                await InsertLogTask(new LogIts(idTask, Task.CurrentId.ToString(), "Ocorreu um erro na tentativa de agendar a tarefa!", ex.Message));
            }
        }

    }
}
