using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShScheduler.Scheduler;

namespace ShScheduler
{
    public partial class _ucTriggers : UserControl
    {
        public _ucTriggers()
        {
            InitializeComponent();

           // this.VisibleChanged += _ucTriggers_VisibleChanged;
        }

        private void _ucTriggers_VisibleChanged(object sender, EventArgs e)
        {
            FillOlv();
        }

        public void FillOlv()
        {
            olvTriggers.SetObjects(Singleton.Instance.Scheduler.GetAllTriggers());
        }

        private void btnAddTrigger_Click(object sender, EventArgs e)
        {
            new AddTrigger().ShowDialog();
            FillOlv();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillOlv();
        }
    }
}
