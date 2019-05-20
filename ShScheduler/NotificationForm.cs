using System;
using System.Windows.Forms;
using Quartz;
using ShData;
using ShData.Models;
using ShScheduler.Helpers;
using ShScheduler.Smtp;
using ShScheduler.ViewModels;

namespace ShScheduler
{
    public partial class NotificationForm : Form
    {
        private IJobDetail _jobDetail;
        private ITrigger _trigger;

        public NotificationForm()
        {
            InitializeComponent();
        }

        public NotificationForm(IJobDetail jobDetail, ITrigger trigger):this()
        {
            this._jobDetail = jobDetail;
            this._trigger = trigger;
            this.txtJobName.Text = jobDetail.Key.Name;
        }

        private void btnSend_Click(object sender, System.EventArgs e)
        {
            try
            {
                DataAccess.AddFeedback(new FeedbackModel()
                {
                    Text = this.txtFeedback.Text,
                    JobName = this._jobDetail.Key.Name,
                    TriggerName = this._trigger.Key.Name,
                    User = User.Name
                });
                Mailer.SendEmail(new EmailMessage()
                {
                    Subject = $"Job {_jobDetail.Key.Name}",
                    Body = txtFeedback.Text,
                    To = User.Email,
                    ToEmail= User.Email
                });
                this.Dispose();
            }
            catch (Exception exception)
            {
               MessageHelper.DisplayError(exception.Message);
            }
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            PInvoker.SetForegroundWindow(this.Handle);
        }
    }
}
