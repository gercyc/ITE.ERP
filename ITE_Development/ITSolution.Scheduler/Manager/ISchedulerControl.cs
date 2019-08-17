using ITSolution.Scheduler.EntidadesBd;
using System.Threading;
using System.Threading.Tasks;

namespace ITSolution.Scheduler.Manager
{
    public interface ISchedulerControl
    {

        string CreateTask(TaskIts task, CancellationTokenSource cts);

        void StartTask(string idTask, CancellationTokenSource cts);

        Task DoWorkTask(string idTask);

        void SuspendTask(string idTask);

        Task InsertLogTask(LogIts log);

        Task Execute(TaskIts task, CancellationTokenSource cancellationToken);
    }
}
