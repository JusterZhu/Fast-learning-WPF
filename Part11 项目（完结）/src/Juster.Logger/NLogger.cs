using NLog;
using System;

namespace Juster.Logger
{
    public class NLogger
    {
        private static NLog.ILogger _logger = LogManager.GetCurrentClassLogger();

        static NLogger() 
        {
            
        }

        public static void Debug(string msg) 
        {
            _logger.Debug(msg);
        }

        public static void Info(string msg) 
        {
            _logger.Info(msg);
        }

        public static void Error(string msg,Exception ex) 
        {
            _logger.Error(ex,msg);
        }
    }
}
