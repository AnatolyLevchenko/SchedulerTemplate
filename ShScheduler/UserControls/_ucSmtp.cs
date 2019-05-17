using System;
using System.Windows.Forms;
using ShData;
using ShScheduler.Scheduler;

namespace ShScheduler.UserControls
{
    public partial class _ucSmtp : UserControl
    {
        public _ucSmtp()
        {
            InitializeComponent();
        }

        private void _ucSmtp_Load(object sender, EventArgs e)
        {
           var smtp= DataAccess.ReadSmtp();

            if (smtp != null)
            {
                txtSmtp.Text = smtp.Smtp;
                txtEmail.Text = smtp.Email;
                txtPass.Text = smtp.Password;
                nupPort.Value = smtp.Port;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.TryCloseFrom();
        }

        private void btnSaveSmtp_Click(object sender, EventArgs e)
        {

        }

        
    }
}
