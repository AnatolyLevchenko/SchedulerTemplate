using System.Windows.Forms;
using ShData;

namespace ShScheduler
{
    public partial class _ucFeedbacks : UserControl
    {
        public _ucFeedbacks()
        {
            InitializeComponent();
        }

        public void FillOlv()
        {
            olvFeedback.SetObjects(DataAccess.GetFeedbacks());
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            FillOlv();
        }
    }
}
