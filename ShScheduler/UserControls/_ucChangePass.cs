using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quartz;
using ShData;
using ShData.Models;
using ShScheduler.Helpers;
using ShScheduler.Scheduler;
using ShScheduler.ViewModels;

namespace ShScheduler.UserControls
{
    public partial class _ucChangePass : UserControl
    {
        private readonly string _user;

        public _ucChangePass(string user)
        {
            _user = user;
            InitializeComponent();

            lbUser.Text = _user;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.TryCloseFrom();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            try
            {
                LoginModel model = new LoginModel
                {
                    Login = _user,
                    Password = txtPassword.Text
                };

                if (model.IsValid)
                {
                  bool res = DataAccess.ChangePassword(model);
                    if (res)
                    {
                        this.TryCloseFrom();
                    }
                    else MessageHelper.DisplayError("Something wrong");
                }
               
            }
            catch (Exception ex)
            {
                MessageHelper.DisplayError(ex.Message);
            }
        }
    }
}
