using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteSistemi
{
    class OgretimElemani
    {
        private int OgretimElemaniNo;
        private string OgretimElemaniAdi;
        private string OgretimElemaniSoyadi;
        private int OgretimElemaniBolum;

        public int ogretimElemaniNo//kapsülleme
        {
            get { return OgretimElemaniNo; }
            set { OgretimElemaniNo = value; }
        }
        public string ogretimElemaniAd//kapsülleme
        {
            get { return OgretimElemaniAdi; }
            set { OgretimElemaniAdi = value; }
        }
        public string ogretimElemaniSoyad//kaspülleme
        {
            get { return OgretimElemaniSoyadi; }
            set { OgretimElemaniSoyadi = value; }
        }
        public int ogretimelemaniBolum//kapsülleme
        {
            get { return OgretimElemaniBolum; }
            set { OgretimElemaniBolum = value; }
        }

        public OgretimElemani(int No, string Ad, string Soyad,int bolum)//constructor
        {
            OgretimElemaniNo = No;
            OgretimElemaniAdi = Ad;
            OgretimElemaniSoyadi = Soyad;
            OgretimElemaniBolum = bolum;


        }
    }
}
