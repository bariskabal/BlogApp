using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.Tools.LogTool
{
    public interface ICustomLogger
    {
        void LogError(string message);
    }
}
