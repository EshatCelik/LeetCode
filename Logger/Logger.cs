using LoggerToFile;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logger
{
    public static class Logger
    {
        public static string path = "";
        public static void WriteLog(string message)
        {
            //path = "C:/Log/log.txt";


            //dosya boyutu kontrolu 
            path = CheckFileLength();


            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"{DateTime.Now} :{message}");
            }



        }

        public static string CheckFileLength()
        {
            try
            {
                //dosya boyutuna göre aşım olursa yeni bir log dosyası oluşturur
                path = "C:/Log/log.txt";
                FileInfo file = new FileInfo(path);
                if (file.Length > 10)//100 kb ise
                {
                    path = "C:/Log/log" + DateTime.Now.ToString().Substring(0, 10).ToString() + ".txt";
                }
            }
            catch (Exception)
            {
               
                StreamWriter writer = new StreamWriter(path, true);
            }
            return path;
        }

       
    }
}
