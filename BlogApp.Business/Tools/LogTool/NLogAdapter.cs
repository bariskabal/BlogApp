using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.Tools.LogTool
{
    public class NLogAdapter : ICustomLogger
    {
        public void LogError(string message)
        {
            var logger = LogManager.GetLogger("fileLogger");
            logger.Log(LogLevel.Error, message);
        }
    }
}
