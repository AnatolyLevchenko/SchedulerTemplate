using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShData;
using ShData.Models;
using ShScheduler.Properties;
using ShScheduler.UserControls;
using ShScheduler.Utils;

namespace ShScheduler
{
    public partial class _ucUsers : UserControl
    {
        public _ucUsers()
        {
            InitializeComponent();
            olvLogin.ImageGetter+=ImageGetter;
        }

        private object ImageGetter(object rowobject)
        {
            return Resources.user;
        }

        public void FillOlv()
        {
           var users= DataAccess.ReadAllUsers();
           this.olvUsers.SetObjects(users);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillOlv();
        }

        private void olvUsers_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (e.Column.AspectName == "Admin")
            {
                var model=e.RowObject as LoginModel;
                
                bool result = (bool) e.NewValue;
                DataAccess.ChangeAdmin(model.Login,result);
                FillOlv();
            }
            if (e.Column.AspectName == "Email")
            {
                if (!RegexUtilities.IsValidEmail(e.NewValue.ToString()))
                {
                    MessageBox.Show(Translation.General.EmailInvalid);
                    e.Cancel = true;
                }
                else
                {
                    var model = e.RowObject as LoginModel;
                    DataAccess.ChangeEmail(model.Login, e.NewValue.ToString());
                    FillOlv();
                }
            }
        }

        private void olvUsers_ButtonClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            using (DialogForm df = new DialogForm())
            {
                df.Text = Translation.General.ChangePassword;
                df.Text = string.Empty;
                LoginModel model=e.Model as LoginModel;
                using (var pass = new _ucChangePass(model.Login))
                {
                    df.mainPanel.Controls.Add(pass);
                    df.ShowDialog();
                }

            }
        }
    }
}
