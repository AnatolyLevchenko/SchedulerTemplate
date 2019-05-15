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

namespace ShScheduler
{
    public partial class Form1 : Form
    {
        private StdSchedulerFactory schedFact;
        private  IScheduler Scheduler;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            schedFact = new StdSchedulerFactory();
            Scheduler = schedFact.GetScheduler().Result;
        }
    }
}
