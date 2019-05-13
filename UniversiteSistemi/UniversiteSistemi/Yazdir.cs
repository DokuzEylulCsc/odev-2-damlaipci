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
            
            StreamWriter sw = File.AppendText(@"LİSTE.txt");//liste txt ine ekleniyor.
            sw.WriteLine(de.dersKodu+" "+de.dersAdi+" "+DateTime.Today);
            sw.WriteLine("Ogrenci Listesi:");
            foreach(Ogrenci o in de.DersteKayitliOgrenciList.Values)//Dersteki Ogrencileri Yazdirma
            {
                sw.WriteLine("Ogrenci Bolum:"+o.ogrenciBolum + "--Ogrenci No: " + o.ogrenciNo + "--Ogrenci Adi: " + o.ogrenciAdi + "--OgrenciSoyadi: " + o.ogrenciSoyadi);
            }
            foreach (OgretimElemani o in de.DerseKayitliOgretimElemani.Values)//Dersteki Ogretim Elemanlarini Yazdirma
            {
                sw.WriteLine("OgrEleBolum:"+o.ogretimelemaniBolum + "--OgrEleNo: " + o.ogretimElemaniNo + "--OgrEleAdi:" + o.ogretimElemaniAd + "--OgrEleSoyadi: " + o.ogretimElemaniSoyad);
            }
            sw.Flush();
            sw.Close();
           
        }
    }

}
