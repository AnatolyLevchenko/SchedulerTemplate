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

namespace ShScheduler
{
    public partial class _ucUsers : UserControl
    {
        public _ucUsers()
        {
            InitializeComponent();
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
    }
}
