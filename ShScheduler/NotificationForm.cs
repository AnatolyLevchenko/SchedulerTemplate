using System;
using System.Windows.Forms;
using Quartz;
using ShData;
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
    }
}
