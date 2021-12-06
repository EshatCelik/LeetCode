using LoggerToFile;
using System;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.WriteLog("Besir kontrol eder !!");

            ILogger _logger=new FileLog();
            
        }
    }
}
