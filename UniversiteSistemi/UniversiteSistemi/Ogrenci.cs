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
        private int OgrenciSube;
        private string OgrenciAdi;
        private string OgrenciSoyadi;
        private int Ogrencibolumu;

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
        public int ogrenciBolum
        {
            get { return Ogrencibolumu; }
            set { Ogrencibolumu = value; }
        }
        public int Sube
        {
            get { return OgrenciSube; }
            set { OgrenciSube = value; }
        }



        public Ogrenci(int No, string Ad, string Soyad, int bolum)
        {
            OgrenciNo= No;
            OgrenciAdi = Ad;
            OgrenciSoyadi =Soyad;
            ogrenciBolum = bolum;
            
        }
    }
}
