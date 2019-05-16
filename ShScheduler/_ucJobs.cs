using System;
using System.Windows.Forms;
using ShScheduler.Scheduler;

namespace ShScheduler
{
    public partial class _ucJobs : UserControl
    {
        public _ucJobs()
        {
            InitializeComponent();
            this.VisibleChanged += _ucJobs_VisibleChanged1;
        }

        private void _ucJobs_VisibleChanged1(object sender, EventArgs e)
        {
           FillOlv();
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            new AddJob().ShowDialog();
            FillOlv();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillOlv();
        }

        private void FillOlv()
        {
            olvJobs.SetObjects(Singleton.Instance.Scheduler.GetJobs());
        }
    }
}
