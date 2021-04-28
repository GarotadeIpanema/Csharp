using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    class DataManager
    {
        public static void printlog(string contents, string name="LogHistory")
        {
            DirectoryInfo di = new DirectoryInfo("LogHistory");
            if (!di.Exists)
            {
                di.Create();
            }
            using(StreamWriter writer = new StreamWriter(@"LogHistory\" +name+".txt", true))
            {
                writer.WriteLine("[" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff") + " ]");
            }
        }

    }
}
