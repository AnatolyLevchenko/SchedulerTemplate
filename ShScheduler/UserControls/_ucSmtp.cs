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
            if (string.IsNullOrEmpty(txtSmtp.Text))
            {
                txtSmtp.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                txtPass.Focus();
                return;
            }

            try
            {
                SmtpModel model = new SmtpModel();
                if (cbSsl.Checked)
                    model.EnableSsl = 1;
                model.Email = txtEmail.Text;
                model.Password = txtPass.Text;
                model.Port = (int)nupPort.Value;
                model.Smtp = txtSmtp.Text;

                bool result = DataAccess.WriteSmtp(model);

                if(result)
                    MessageHelper.DisplayDone("Succesfully saved");
                else MessageHelper.DisplayError("Can't save settings");
                
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btnTestSettings_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTextEmail.Text))
            {
                MessageHelper.DisplayError("Fill e-mail address");
                txtTextEmail.Focus();
                return;
            }

            try
            {
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
            catch (Exception exception)
            {
               MessageHelper.DisplayError(exception.Message);
            }
            
        }
    }
}
