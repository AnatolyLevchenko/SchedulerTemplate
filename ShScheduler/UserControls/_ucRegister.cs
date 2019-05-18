using System;
using System.Windows.Forms;
using ShData;
using ShData.Models;
using ShScheduler.Helpers;
using ShScheduler.Scheduler;
using ShScheduler.Utils;

namespace ShScheduler.UserControls
{
    public partial class _ucRegister : UserControl
    {
        public _ucRegister()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.TryCloseFrom();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoginModel model = new LoginModel(txtLogin.Text, txtPassword.Text, cbAdmin.Checked,txtEmail.Text);

            try
            {
                if(!RegexUtilities.IsValidEmail(txtEmail.Text))
                    throw new Exception("Email address is not valid");
                if(string.IsNullOrEmpty(txtLogin.Text))
                    throw new Exception("Login field is required");
                if(string.IsNullOrEmpty(txtPassword.Text))
                    throw new Exception("Password is required");

                bool done = DataAccess.Register(model);

                if(!done)
                    throw  new Exception("Can't add user.Something wrong");


                MessageHelper.DisplayDone("successfully registered");
                this.TryCloseFrom();
            }
            catch (Exception exception)
            {
                MessageHelper.DisplayError(exception.Message);
            }

        }
    }
}
