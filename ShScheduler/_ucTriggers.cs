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
                if (e.Column == olvColumnAction)
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

                if (e.Column == olvDelete)
                {
                    try
                    {
                        Singleton.Instance.Scheduler.RemoveTrigger(tr.TriggerKey);
                        Logger.LogInfo(tr.TriggerKey +" deleted");

                        FillOlv();
                    }
                    catch (Exception exception)
                    {
                        Logger.LogException(System.Reflection.MethodBase.GetCurrentMethod().Name, exception);
                        MessageBox.Show(exception.Message);
                    }
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
                df.Text = Translation.General.AddTrigger;
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

    }
}
