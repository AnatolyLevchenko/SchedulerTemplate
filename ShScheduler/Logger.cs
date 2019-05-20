using System;
using  log4net;
namespace ShScheduler
{
    class Logger
    {
        private static ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().Name);

        public static ILog GetLoggerInternal(Type type)
        {
            return LogManager.GetLogger(type);
        }

        public static void LogInfo(string message)
        {
            _log.Info(message);
        }

        public static void LogException(string message,Exception exc)
        {
            ILog logger = GetLoggerInternal(typeof(Logger));
            logger.Error(message, exc);
        }
    }
}
