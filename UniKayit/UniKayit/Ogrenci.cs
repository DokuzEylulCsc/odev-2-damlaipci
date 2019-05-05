using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniKayit
{
    abstract class Ogrenci
    {
        private string adsoyad;
        private int id;
        private string fakulte;
        private string bolum;
        private string []Ders;

        abstract public void DersEkle();


        string AdSoyad
        {
            get { return adsoyad; }
            set { adsoyad = value; }
        }

        int Id
        {
            get { return id;}
            set { id = value;}
        }
        string Fakulte  
        {
            get { return fakulte; }
            set { fakulte = value; }
        }


        string Bolum
        {
            get { return bolum; }
            set {bolum = value; }
        }



    }
}
