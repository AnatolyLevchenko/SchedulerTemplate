using System.Threading.Tasks;
using Quartz;

namespace ShScheduler.Scheduler
{
    class HelloJob:IJob
    {
        public  void Execute(IJobExecutionContext context)
        {
          //Logger.LogInfo(context.);

            // Task.Delay(100);
        }
    }
}
