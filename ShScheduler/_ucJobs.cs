using System;
using System.Windows.Forms;
using ShScheduler.Properties;
using ShScheduler.Scheduler;
using ShScheduler.UserControls;

namespace ShScheduler
{
    public partial class _ucJobs : UserControl
    {
        public _ucJobs()
        {
            InitializeComponent();
            olvName.ImageGetter+=ImageGetter;
        }

        private object ImageGetter(object rowobject)
        {
            return Resources.task;
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            using (DialogForm df = new DialogForm())
            {
                using (var trigger = new _ucAddJob())
                {
                    df.mainPanel.Controls.Add(trigger);
                    df.ShowDialog();
                }

            }

            FillOlv();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillOlv();
        }

        public void FillOlv()
        {
            olvJobs.SetObjects(Singleton.Instance.Scheduler.GetJobs());
        }

        private void olvJobs_CellEditValidating(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (e.Column == olvDescription)
            {
                string newValue = ((TextBox)e.Control).Text.ToLowerInvariant();
                if (string.IsNullOrEmpty(newValue))
                {
                    e.Cancel = true;
                    MessageBox.Show(this, "Empty name is not allowed!", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}
