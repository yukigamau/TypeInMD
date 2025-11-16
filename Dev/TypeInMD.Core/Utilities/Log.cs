using System;
using System.Threading.Tasks;
using TypeInMD.Core.Controls;

namespace TypeInMD.Core.Utilities
{
    public static class Log
    {
        public static Task Report(string type, string content)
        {
            return Task.Run(() => Common.Post("https://TypeInMD.ownbox.cn/report", new
            {
                version = AboutApp.GetAppVersion(),
                system = Environment.OSVersion.VersionString,
                type,
                content,
            }));
        }
    }
}
