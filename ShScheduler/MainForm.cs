using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quartz;
using Quartz.Impl;
using ShScheduler.Scheduler;

namespace ShScheduler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillGrids();
            _ucJobs1.BringToFront();
            _ucTriggers1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            new AddJob().ShowDialog();
            FillGrids();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
        
            FillGrids();
        }

        void FillGrids()
        {
            var jobs = Singleton.Instance.Scheduler.GetJobs();
            //olvJobs.SetObjects(jobs);

            var triggers = Singleton.Instance.Scheduler.GetAllTriggers();
            //triggers[0].
           // olvTriggers.SetObjects(triggers);

        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Singleton.Instance.Scheduler.Shutdown();
            }
           
            base.Dispose(disposing);
        }

        private void btnAddTrigger_Click(object sender, EventArgs e)
        {
            new AddTrigger().ShowDialog();
        }

       

        

        private void btnShowJobs_Click(object sender, EventArgs e)
        {
            _ucJobs1.Visible = true;
            _ucJobs1.BringToFront();
            _ucTriggers1.Visible = false;
        }

        private void btnShowTriggers_Click(object sender, EventArgs e)
        {
            _ucTriggers1.BringToFront();
            _ucJobs1.Visible = false;
            _ucTriggers1.Visible = true;
        }
    }
}
