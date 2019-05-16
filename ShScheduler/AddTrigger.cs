using System;
using System.Linq;
using System.Windows.Forms;
using Quartz;
using ShScheduler.Scheduler;
using ShScheduler.ViewModels;

namespace ShScheduler
{
    public partial class AddTrigger : Form
    {
        public AddTrigger()
        {
            InitializeComponent();

            cmbJobName.DataSource = Singleton.Instance.Scheduler.GetJobs().Select(j=>new JobModel(j.Key)).ToList();
            cmbJobName.DisplayMember = "Key";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddTrigger_Click(object sender, EventArgs e)
        {
           var job = cmbJobName.SelectedItem as JobModel;
           var trigger = TriggerBuilder.Create()
                .WithIdentity(txtTriggerName.Text, "triggers")
                .WithCronSchedule(txtCronValue.Text)
                .ForJob(job.Key, job.Group)
                .StartNow()
                .Build();
            Singleton.Instance.Scheduler.ScheduleJob(trigger);
            this.Dispose();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtCronValue.Text = cronControl1.Value;
        }
    }
}
