using System;
using  log4net;
namespace ShScheduler
{
    class Logger
    {
        private static ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().Name);

        public static void LogInfo(string message)
        {
            _log.Info(message);
        }

        public static void LogException(string message,Exception exc)
        {
            _log.Error(message,exc);
        }
    }
}
