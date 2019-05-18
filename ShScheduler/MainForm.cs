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
using ShScheduler.Helpers;
using ShScheduler.Scheduler;
using ShScheduler.UserControls;

namespace ShScheduler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.notifyIcon1.Icon =this.Icon=Properties.Resources.timer;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           InitGrids();
           btnUsers.PerformClick();

            lbUser.Text = User.Name;
        }

        private void InitGrids()
        {
            _ucJobs1.FillOlv();
            _ucTriggers1.FillOlv();
            _ucUsers1.FillOlv();
            _ucFeedbacks1.FillOlv();
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        Singleton.Instance.Scheduler.Shutdown();
        //    }
           
        //    base.Dispose(disposing);
        //}

        private void btnShowJobs_Click(object sender, EventArgs e)
        {
            _ucJobs1.Visible = true;
            _ucJobs1.BringToFront();
            _ucTriggers1.Visible=_ucUsers1.Visible=_ucFeedbacks1.Visible = false;
            ChangeBackColor(sender);
        }

        private void btnShowTriggers_Click(object sender, EventArgs e)
        {
            _ucTriggers1.BringToFront();
            _ucJobs1.Visible =_ucUsers1.Visible=_ucFeedbacks1.Visible= false;
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
                Singleton.Instance.Scheduler.Standby();
                Singleton.Instance.Scheduler.Shutdown();
                System.Diagnostics.Process.Start(Application.ExecutablePath,"logout");
                Application.Exit();
            }) {IsBackground = true};
            th.Start();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (DialogForm df = new DialogForm())
            {
                using (var register = new _ucRegister())
                {
                    df.mainPanel.Controls.Add(register);
                    df.ShowDialog();
                }

            }

        }

        private void btnSmtp_Click(object sender, EventArgs e)
        {
            using (DialogForm df = new DialogForm())
            {
                using (var smtp = new _ucSmtp())
                {
                    df.mainPanel.Controls.Add(smtp);
                    df.ShowDialog();
                }

            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            _ucUsers1.BringToFront();
            _ucJobs1.Visible = false;
            _ucTriggers1.Visible = false;
            _ucUsers1.Visible = true;

            ChangeBackColor(sender);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.BalloonTipText = "Still works in background";
                notifyIcon1.ShowBalloonTip(300);
            }
        }

        private void toolStripMenuItemShow_Click(object sender, EventArgs e)
        {
            this.WindowState  = FormWindowState.Normal;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }

        }

        private void toolStripMenuIExit_Click(object sender, EventArgs e)
        {
            var count = Application.OpenForms.Cast<Form>().Count(x => x.Name != "MainForm");
            if (count > 0)
            {
                MessageHelper.DisplayError("Close feedback form(s) first");
                return;
            }
            Singleton.Instance.Scheduler.Standby();
            Singleton.Instance.Scheduler.Shutdown();
            this.Dispose();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            toolStripMenuIExit.PerformClick();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            _ucTriggers1.BringToFront();
            _ucJobs1.Visible = _ucUsers1.Visible = _ucTriggers1.Visible = false;
            _ucFeedbacks1.Visible = true;

            ChangeBackColor(sender);
        }
    }
}
