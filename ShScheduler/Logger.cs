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
    }
}
