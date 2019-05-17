using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
           InitGrids();
           btnShowTriggers.PerformClick();
        }

        private void InitGrids()
        {
            _ucJobs1.FillOlv();
            _ucTriggers1.FillOlv();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Singleton.Instance.Scheduler.Shutdown();
            }
           
            base.Dispose(disposing);
        }

        private void btnShowJobs_Click(object sender, EventArgs e)
        {
            _ucJobs1.Visible = true;
            _ucJobs1.BringToFront();
            _ucTriggers1.Visible = false;
            ChangeBackColor(sender);
        }

        private void btnShowTriggers_Click(object sender, EventArgs e)
        {
            _ucTriggers1.BringToFront();
            _ucJobs1.Visible = false;
            _ucTriggers1.Visible = true;

            ChangeBackColor(sender);
        }

        void ChangeBackColor(object sender)
        {
            if (sender is Button bt)
            {
                var buttons = this.panel1.Controls.OfType<Button>();
                foreach (var button in buttons)
                {
                    button.BackColor = bt==button ? Color.DarkOrange : Color.Khaki;
                }
            }

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.Login = string.Empty;
            Properties.Settings.Default.Password = string.Empty;
            Properties.Settings.Default.RememberMe = false;
            Properties.Settings.Default.Save();

            Thread th = new Thread(() =>
            {
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
            }) {IsBackground = true};
            th.Start();
        }
    }
}
