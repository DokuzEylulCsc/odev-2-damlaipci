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
        public Dictionary<int, Ogrenci> DersteKayitliOgrenciList = new Dictionary<int, Ogrenci>();//derse atadığım öğrencilerin listesi 
        public Dictionary<int, OgretimElemani> DerseKayitliOgretimElemani = new Dictionary<int, OgretimElemani>();//derse atadığım ogretim elemani
        public Dictionary<int, Sube> SubeList = new Dictionary<int, Sube>();//sube listem var fakat kullanılmadı.Odevde istenmiyor.
        private int DersKodu;
        private string DersAdi;


        public int dersKodu//kapsülleme
        {
            get { return DersKodu; }
            set { DersKodu = value; }
        }
        public string dersAdi//kapsülleme
        {
            get { return DersAdi; }
            set { DersAdi = value; }
        }


        public Ders(int Kod, string Ad)//constructor
        {
            DersKodu = Kod;
            DersAdi = Ad;
        }
        public void OgrenciAta(int OgrenciNo, Ogrenci ogr)//Derse öğrenci ekleme
        {
            try
            {
                DersteKayitliOgrenciList.Add(OgrenciNo, ogr);//listeye ekliyor

            }
            catch(FormatException)
            {
                MessageBox.Show("Format Hatasi");
            }
            catch(Exception)
            {
                MessageBox.Show("Derste Ogrenci Bulunmakta!!");
            }
        }
        
        public void OgrenciSilme(int ogrenciNo)//dersten öğrencii silme
        {
            try
            {
                DersteKayitliOgrenciList.Remove(ogrenciNo);
            }
            catch(Exception)
            {
                MessageBox.Show("Silinmek istenen ogrenci bulunamamktadır");
            }
        }
        public void OgretimElemaniAtama(int OgretimElemaniNo, OgretimElemani ogr)//derse var olan öğretim elemanını ekleme(form kodlarınada bakmak lazım)
        {
            try
            {
                DerseKayitliOgretimElemani.Add(OgretimElemaniNo, ogr);

            }
            catch (Exception)
            {
                MessageBox.Show("Derste Ogrenci Bulunmakta!!");
            }
        }

        public void OgretimElemaniSilme(int OgretimElemaniNo)//ogretim elemani silme
        {
            try
            {
                DerseKayitliOgretimElemani.Remove(OgretimElemaniNo);
            }
            catch
            {
                MessageBox.Show("Silinmek istenen ogrenci bulunamamktadır");
            }
        }
    }
}
