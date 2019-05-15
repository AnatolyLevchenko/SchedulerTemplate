using System;
using System.IO;
using System.Windows.Forms;
using ShData;

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

            Application.Run(new Form1());
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
