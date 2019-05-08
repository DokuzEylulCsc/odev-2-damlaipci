using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteSistemi
{
    class Ders
    {
        private int DersKodu;
        private string DersAdi;


        public int dersKodu
        {
            get { return DersKodu; }
            set { DersKodu = value; }
        }
        public string dersAdi
        {
            get { return DersAdi; }
            set { DersAdi = value; }
        }


        public Ders(int Kod, string Ad)
        {
            DersKodu = Kod;
            DersAdi  = Ad;
        }
    }
}
