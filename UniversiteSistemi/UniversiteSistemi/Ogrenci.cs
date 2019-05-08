using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteSistemi
{
    abstract class Ogrenci
    {
        private int OgrenciNo;
        private string OgrenciAdi;
        private string OgrenciSoyadi;
        private string Ogrencibolumu;

        public int ogrenciNo
        {
            get { return OgrenciNo; }
            set { OgrenciNo = value; }
        }
        public string ogrenciAdi
        {
            get { return OgrenciAdi; }
            set { OgrenciAdi = value; }
        }
        public string ogrenciSoyadi
        {
            get { return OgrenciSoyadi; }
            set { OgrenciSoyadi = value; }
        }
        public string ogrenciBolum
        {
            get { return Ogrencibolumu; }
            set { Ogrencibolumu = value; }
        }


        public Ogrenci(int ID, string ad, string soyad, string bolum)
        {
            ogrid = ID;
            ogradi = ad;
            ogrsoyadi = soyad;
            ogrbolumu = bolum;
        }
    }
}
