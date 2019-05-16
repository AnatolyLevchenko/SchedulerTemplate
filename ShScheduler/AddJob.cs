using System;
using System.Windows.Forms;
using Quartz;
using ShScheduler.Scheduler;

namespace ShScheduler
{
    public partial class AddJob : Form
    {
        public AddJob()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private  void button1_Click(object sender, EventArgs e)
        {

            IJobDetail helloJob = JobBuilder.Create<HelloJob>()
                .WithIdentity(txtJobName.Text)
                .WithDescription(txtJobDescription.Text)
                .RequestRecovery(true)
                .StoreDurably(true)
                .Build();

            Singleton.Instance.Scheduler.AddJob(helloJob,false);
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtJobName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJobDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
