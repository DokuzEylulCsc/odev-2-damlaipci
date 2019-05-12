using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Windows.Forms;
namespace UniversiteSistemi
{
    class Ders
    {
        public Dictionary<int, Ogrenci> DersteKayitliOgrenciList = new Dictionary<int, Ogrenci>();
        public Dictionary<int, Sube> SubeList = new Dictionary<int, Sube>();
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
            DersAdi = Ad;
        }
        public void OgrenciAta(int OgrenciNo, Ogrenci ogr)
        {
            try
            {
                DersteKayitliOgrenciList.Add(OgrenciNo, ogr);

            }
            catch(Exception)
            {
                MessageBox.Show("Derste Ogrenci Bulunmakta!!");
            }
        }
        
        

    }
}
