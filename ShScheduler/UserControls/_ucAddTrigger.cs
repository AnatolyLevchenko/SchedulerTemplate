using System;
using System.Linq;
using System.Windows.Forms;
using Quartz;
using ShScheduler.Helpers;
using ShScheduler.Scheduler;
using ShScheduler.ViewModels;

namespace ShScheduler.UserControls
{
    public partial class _ucAddTrigger : UserControl
    {
        public _ucAddTrigger()
        {
            InitializeComponent();
            cmbJobName.DataSource = Singleton.Instance.Scheduler.GetJobs().Select(j => new JobModel(j.Key)).ToList();
            cmbJobName.DisplayMember = "Key";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtCronValue.Text = cronControl1.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
          this.TryCloseFrom();
        }

        private void btnAddTrigger_Click(object sender, EventArgs e)
        {
            try
            {
                var job = cmbJobName.SelectedItem as JobModel;

                if(job==null)
                    throw new Exception(Translation.General.JobIsRequired);


                var trigger = TriggerBuilder.Create()
                    .WithIdentity(txtTriggerName.Text, "triggers")
                    .WithCronSchedule(txtCronValue.Text)
                    .ForJob(job.Key, job.Group);

                if (cbStartNow.Checked)
                {
                    trigger = trigger.StartNow();
                }

                var result = trigger.Build();

                Singleton.Instance.Scheduler.ScheduleJob(result);

                this.TryCloseFrom();
            }
            catch (Exception ex)
            {
                MessageHelper.DisplayError(ex.Message);
            }
          
            
        }

    }
}
