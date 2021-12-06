using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LoggerToFile_
{
    public static class Logger
    {
        
        public static void WriteLog(string message)
        {
            string path = $"C:\\Log";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"{DateTime.Now} :{message}");
            }
        }
    }
}
