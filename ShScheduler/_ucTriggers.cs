using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Quartz;
using ShScheduler.Properties;
using ShScheduler.Scheduler;
using ShScheduler.UserControls;
using ShScheduler.ViewModels;

namespace ShScheduler
{
    public partial class _ucTriggers : UserControl
    {
        public _ucTriggers()
        {
            InitializeComponent();
            this.olvTriggerKey.ImageGetter+= ImageGetter;
            this.olvTriggers.ButtonClick += OlvTriggers_ButtonClick;
        }

        private void OlvTriggers_ButtonClick(object sender, CellClickEventArgs e)
        {
            if (e.Model is TriggerInfo tr)
            {
                try
                {
                    if (tr.State.Equals(TriggerState.Normal.ToString()))
                    {
                        Singleton.Instance.Scheduler.PauseTrigger(tr.TriggerKey);
                    }
                    else
                    {
                        Singleton.Instance.Scheduler.ResumeTrigger(tr.TriggerKey);
                    }

                }
                catch (Exception exception)
                {
                    Logger.LogException(System.Reflection.MethodBase.GetCurrentMethod().Name, exception);
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    FillOlv();
                }
            }

        }

        private object ImageGetter(object rowobject)
        {
            return Resources.planner;
        }

        public void FillOlv()
        {
            olvTriggers.SetObjects(Singleton.Instance.Scheduler.GetAllTriggers());
        }

        private void btnAddTrigger_Click(object sender, EventArgs e)
        {
            using (DialogForm df=new DialogForm())
            {
                using (var trigger= new _ucAddTrigger())
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

        private void SetupColumnWithButton()
        {

            // Tell the columns that it is going to show buttons.
            // The label that goes into the button is the Aspect that would have been
            // displayed in the cell.
            this.olvColumnAction.IsButton = true;

            // How will the button be sized? That can either be:
            //   - FixedBounds. Each button is ButtonSize in size
            //   - CellBounds. Each button is as wide as the cell, inset by CellPadding
            //   - TextBounds. Each button resizes to match the width of the text plus ButtonPadding
            this.olvColumnAction.ButtonSizing = OLVColumn.ButtonSizingMode.FixedBounds;
            this.olvColumnAction.ButtonSize = new Size(80, 26);

            // Make the buttons clickable even if the row itself is disabled
            this.olvColumnAction.EnableButtonWhenItemIsDisabled = true;
            this.olvColumnAction.AspectName = "NextAction";
            this.olvColumnAction.TextAlign = HorizontalAlignment.Center;

            // Listen for button clicks -- which for the purpose of the demo will cycle the state of the service task
            this.olvTriggers.ButtonClick += delegate (object sender, CellClickEventArgs e) {
//                Coordinator.ToolStripStatus1 = String.Format("Button clicked: ({0}, {1}, {2})", e.RowIndex, e.SubItem, e.Model);
//
//                // We only have one column with a button, but if there was more than one, you would have to check ColumnIndex to see which button was clicked
//                ServiceTask task = (ServiceTask)e.Model;
//                task.AdvanceToNextState();
//
//                // Just to show off disabled rows, make tasks that are frozen be disabled.
//                if (task.Status == ServiceTask.TaskStatus.Frozen)
//                    this.olvTasks.DisableObject(e.Model);
//                else
//                    this.olvTasks.EnableObject(e.Model);
//
//                this.olvTasks.RefreshObject(e.Model);
            };
        }
    }
}
