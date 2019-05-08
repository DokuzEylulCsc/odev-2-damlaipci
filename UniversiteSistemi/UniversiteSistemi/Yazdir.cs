using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UniversiteSistemi
{
    class Yazdir
    {
        public static void Yazma(Exception e)
        {
            string dosya_yolu = @"LİSTE.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(e.Message);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }

}
