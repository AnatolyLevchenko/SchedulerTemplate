using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quartz;

namespace ShScheduler.Scheduler
{
    class HelloJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            var form = new NotificationForm(context.JobDetail,context.Trigger);
            form.ShowDialog();
        }
    }
}

