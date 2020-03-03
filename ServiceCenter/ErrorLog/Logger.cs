using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.ErrorLog
{
    public static class Logger
    {
        private static string sLogFormat;
        private static string sErrorTime;

        static Logger()
        {
            sLogFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + "\n \n";
            string sYear = DateTime.Now.Year.ToString();
            string sMonth = DateTime.Now.Month.ToString();
            string sDay = DateTime.Now.Day.ToString();
            sErrorTime = "-" + sYear + "-" + sMonth + "-" + sDay;
        }

        public static void LoggError(Exception ex, string MethodName)
        {
            sLogFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + "\n \n";
            DirectoryInfo di;
            if (!(Directory.Exists(ConfigurationSettings.AppSettings.Get("LogPath").ToString())))
                di = Directory.CreateDirectory(ConfigurationSettings.AppSettings.Get("LogPath").ToString());

            StreamWriter sw = new StreamWriter(ConfigurationSettings.AppSettings.Get("LogPath") + "/ErrorLog " + sErrorTime + ".txt", true);
            sw.WriteLine("------------" + sLogFormat + "-------------");
            sw.WriteLine(" " + ex.ToString());
            sw.WriteLine(" " + MethodName);
            sw.WriteLine("-------------------------------------------");
            sw.WriteLine("");
            sw.Flush();
            sw.Close();
        }
    }
}
