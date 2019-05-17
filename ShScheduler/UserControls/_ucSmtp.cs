using System;
using System.Windows.Forms;
using ShData;
using ShData.Models;
using ShScheduler.Helpers;
using ShScheduler.Scheduler;
using ShScheduler.Smtp;
using ShScheduler.ViewModels;

namespace ShScheduler.UserControls
{
    public partial class _ucSmtp : UserControl
    {
        private SmtpModel smtp;
        public _ucSmtp()
        {
            InitializeComponent();
        }

        private void _ucSmtp_Load(object sender, EventArgs e)
        {
            smtp= DataAccess.ReadSmtp();

            if (smtp != null)
            {
                txtSmtp.Text = smtp.Smtp;
                txtEmail.Text = smtp.Email;
                txtPass.Text = smtp.Password;
                nupPort.Value = smtp.Port;
                cbSsl.Checked = smtp.UseSsl;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.TryCloseFrom();
        }

        private void btnSaveSmtp_Click(object sender, EventArgs e)
        {

        }

        private void btnTestSettings_Click(object sender, EventArgs e)
        {
            SmtpModel model = new SmtpModel
            {
                Email = txtEmail.Text,
                Password = txtPass.Text,
                Port = Convert.ToInt32(nupPort.Value)
            };

            Mailer.SendEmail(new EmailMessage()
            {
                Body = "This is a test message",
                Subject = "Test",
                From = "Scheduler",
                FromEmail = smtp.Email,
                To = "You",
                ToEmail = txtTextEmail.Text
            });

            MessageHelper.DisplayDone("Sent");
        }
    }
}
