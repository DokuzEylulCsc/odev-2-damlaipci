using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UniKayit
{
    class Ders
    {
        ArrayList KapsamlıListe = new ArrayList();//Hem Ogrenci Hemde Ogretim Elemanı içinde tutan liste
        

        public void OgrEleAta(OgrElemani ogretimElemani)
        {
            KapsamlıListe.Add(ogretimElemani);
        }
        public void OgrEleDegistir(OgrElemani ogretimElemanicik,OgrElemani ogrElemanigir)
        {

        }
        public void OgrenciEkle(Ogrenci ogrenci)
        {
            KapsamlıListe.Add(ogrenci);//ogrenci aldı ogr listesine attı

        }
        public void OgrenciSil(Ogrenci ogrenci)
        {
            foreach(Ogrenci ogr in KapsamlıListe)
            {
                if(ogr==ogrenci)
                {
                    KapsamlıListe.Remove(ogrenci);

                }
            }
        }
    }
}
