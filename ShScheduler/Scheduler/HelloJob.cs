using System.Windows.Forms;
using Quartz;

namespace ShScheduler.Scheduler
{
    class HelloJob:IJob
    {
        public  void Execute(IJobExecutionContext context)
        {
//          /  MessageBox.Show("1");
        }
    }
}
