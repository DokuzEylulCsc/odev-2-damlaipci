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
        
        public static void Yazma(Ders de)
        {
            
            StreamWriter sw = File.AppendText(@"LİSTE.txt");
            sw.WriteLine(de.dersKodu+" "+de.dersAdi+" "+DateTime.Today);
            sw.WriteLine("Ogrenci Listesi:");
            foreach(Ogrenci o in de.DersteKayitliOgrenciList.Values)
            {
                sw.WriteLine(o.ogrenciBolum + " " + o.ogrenciNo + " " + o.ogrenciAdi + " " + o.ogrenciSoyadi);
            }
            sw.Flush();
            sw.Close();
           
        }
    }

}
