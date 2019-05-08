using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteSistemi
{
    class Bolum
    {
       
        public Dictionary<int,OgretimElemani> OgretimElemaniList = new Dictionary<int, OgretimElemani>();
        public Dictionary<int, Ogrenci> BolumdekiOgrencilerList = new Dictionary<int, Ogrenci>();
        public Dictionary<int, Ders> KayıtlıDersler = new Dictionary<int, Ders>();

        private int BolumNo;
        private string BolumAdi;

        public int bolumNo
        {
            get { return BolumNo ; }
            set { BolumNo = value; }
        }
        public string bolumAdi
        {
            get { return BolumAdi; }
            set { BolumAdi = value; }
        }

        public Bolum(int No, string Ad)
        {
            BolumNo = No;
            BolumNo = Ad;
        }

        public void OgretimGorevlisiEkle(int ID, string Ad, string Soyad)
        {
            try
            {
                KayitliOgretimUyeleri.Add(ID, new OgretimElemani(ID, Ad, Soyad));
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("Eklemek istediginiz ogretim gorevlisi zaten eklenmis !!");

            }
        }

        public void OgretimGorevlisiSil(int ID)
        {
            try
            {
                KayitliOgretimUyeleri.Remove(ID);
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("Silmek istediginiz ogretim uyesi kayıtlı degil !!");
            }
        }

        public void DersEkle(int DersID, string DersAdi, string HocaAdi)
        {
            try
            {
                KayıtlıDersler.Add(DersID, new Ders(DersID, DersAdi));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
