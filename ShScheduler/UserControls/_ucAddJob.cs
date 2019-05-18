using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quartz;
using ShScheduler.Scheduler;

namespace ShScheduler.UserControls
{
    public partial class _ucAddJob : UserControl
    {
        public _ucAddJob()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.TryCloseFrom();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            IJobDetail helloJob = JobBuilder.Create<HelloJob>()
                .WithIdentity(txtJobName.Text)
                .WithDescription(txtJobDescription.Text)
                .RequestRecovery(false)
                .StoreDurably(true)
                .Build();

            Singleton.Instance.Scheduler.AddJob(helloJob, false);

            this.TryCloseFrom();
        }
    }
}
