using System;
using System.IO;
using System.Windows.Forms;
using ShData;
using ShScheduler.Scheduler;

namespace ShScheduler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            log4net.Config.XmlConfigurator.Configure();

            InitDbIfRequired();

            DialogResult result;

            using (var authForm = new LoginForm())
            {
                result = authForm.ShowDialog();
            }

            if (result == DialogResult.OK)
            {
                var name = Singleton.Instance.Scheduler.SchedulerName;
                Logger.LogInfo($"Scheduler with name {name} was started");
                Application.Run(new MainForm());
            }
 
        }

        static void InitDbIfRequired()
        {
            if (!File.Exists("scheduler.db"))
            {
                DataAccess.CreateSchema(File.ReadAllText("Schema.sql"));
                Logger.LogInfo("Database was created");
            }
        }
    }
}
