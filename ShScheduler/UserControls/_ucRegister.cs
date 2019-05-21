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
                    throw new Exception(Translation.General.EmailInvalid);
                if(string.IsNullOrEmpty(txtLogin.Text))
                    throw new Exception(Translation.General.LoginRequired);
                if(string.IsNullOrEmpty(txtPassword.Text))
                    throw new Exception(Translation.General.PasswordRequired);

                bool done = DataAccess.Register(model);

                if(!done)
                    throw  new Exception(Translation.General.CantRegister);


                MessageHelper.DisplayDone(Translation.General.Registered);
                this.TryCloseFrom();
            }
            catch (Exception exception)
            {
                MessageHelper.DisplayError(exception.Message);
            }

        }
    }
}
