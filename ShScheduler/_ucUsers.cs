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
                    MessageBox.Show("Not valid Email Address");
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
            MessageBox.Show("not implemented yet");
        }
    }
}
