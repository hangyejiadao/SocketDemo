using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtpClient
{
    public class Log
    {
        private static readonly string Path = AppDomain.CurrentDomain.BaseDirectory + "Log/";
        private static readonly string FilePath = Path + "/Log.txt";
        public static void Write(string msg)
        {
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath);
            }
            using (StreamWriter writer = new StreamWriter(FilePath,true))
            {
                writer.WriteLine(DateTime.Now+":   "+msg);
                writer.Flush();
                writer.Dispose();
            }
        }
    }
}
