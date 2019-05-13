using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversiteSistemi
{
    class Bolum
    {
       
        public Dictionary<int,OgretimElemani> OgretimElemaniList = new Dictionary<int, OgretimElemani>();
        public Dictionary<int, Ogrenci> BolumdekiOgrencilerList = new Dictionary<int, Ogrenci>();
        public Dictionary<int, Ders> DersList = new Dictionary<int, Ders>();
        public Dictionary<int, Sube> SubeList = new Dictionary<int, Sube>();//Bolum içinde tutacağım listeleri oluşturdum
        private int BolumNo;
        private string BolumAdi;

        public int bolumNo//kapsülleme
        {
            get { return BolumNo ; }
            set { BolumNo = value; }
        }
        public string bolumAdi//kapsülledim
        {
            get { return BolumAdi; }
            set { BolumAdi = value; }
        }

        public Bolum(int No, string Ad)//constructor
        {
            BolumNo = No;
            BolumAdi = Ad;
        }

        public void OgrenciEkle(int OgrenciNo, string OgrenciAdi,string OgrenciSoyadi,int OgrenciBolum,string OgrenciDuzey)//ogrenci ekleme metodu
        {
            try
            {
                Ogrenci ogrenci=new Lisans(0,"0","0",0); //boş oluşturuldu bi anlamı yok sadece aşağıda hata vermesin diye
                //Ogrenci ogrenci = new Ogrenci(OgrenciNo, OgrenciAdi, OgrenciSoyadi,OgrenciBolum);
                switch (OgrenciDuzey)//Ogrencilerin düzeylerini almak için oluşturdum
                {
                    case "Lisans": ogrenci = new Lisans(OgrenciNo, OgrenciAdi, OgrenciSoyadi, OgrenciBolum);
                        break;
                    case "YuksekLisans": ogrenci = new YuksekLisans(OgrenciNo, OgrenciAdi, OgrenciSoyadi, OgrenciBolum);
                        break;
                    case "Doktora": ogrenci = new Doktora(OgrenciNo, OgrenciAdi, OgrenciSoyadi, OgrenciBolum);
                        break;
                }

                BolumdekiOgrencilerList.Add(OgrenciNo,ogrenci); //aşağısı//listeye ekledi
            }
            catch(FormatException)//format hatası olduğu zaman hatayı yakalar
            {
                MessageBox.Show("Hatali Giris");
            }
            catch (Exception fe)//Hatayı yakalar
            {
                MessageBox.Show("Ogrenci bulunmakta");
            }
        }
        public void OgrenciSil(int id)//ogrenciyi silme metodu
        {
            BolumdekiOgrencilerList.Remove(id);
        }
        public void DersEkle(int DersKodu, string DersAdi)//Ders ekleme metodu
        {
            try
            {
                Ders derskayit = new Ders(DersKodu, DersAdi);
                DersList.Add(DersKodu, derskayit);//ders kodu ve adi alınarak listeye eklendi

            }
            catch (Exception e)//Hatayı yakalar
            {
                throw new Exception("Ders Bulunmakta");
            }

           
        }

        public void DersSil(int DersKodu, string DersAdi)//ders silme metodu
        {
            try
            {
                DersList.Remove(DersKodu);//Listeden derskoduna bağlı olarak ders siler
            }
            catch (Exception fe)
            {
                MessageBox.Show("Hatali Giriş");
            }
           
        }

        public void OgretimElemaniEkle(int No, string Ad, string Soyad,int bolum)//ogretim Elemani ekleme
        {
            try
            {
                OgretimElemani ogrele = new OgretimElemani(No, Ad, Soyad,bolum);//ogretim elemanının no ,ad,soyad,bolumunu alır 
                OgretimElemaniList.Add(No,ogrele);//listeye ekler
            }
           
            catch(Exception e)
            {
                MessageBox.Show("Ogretim Elemani Bulunmakta!!");
            }
        }

        

        public void OgretimElemaniSil(int No)//Ogretim Elemanını silme metodu
        {
            try
            {
                
                OgretimElemaniList.Remove(No); //Ogretmenelemanilistesinden no ya bağlı olarak siliyor.
            }
            catch (FormatException)
            {

                throw new FormatException("Hatali Giriş");
            }
            catch(Exception e)
            {
                throw new Exception("Ogretim Elemani Bulunmamaktadir!");
            }
        }
        
        
        
    }
}
