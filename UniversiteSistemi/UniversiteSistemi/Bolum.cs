﻿using System;
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
        public Dictionary<int, Sube> SubeList = new Dictionary<int, Sube>();
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
            BolumAdi = Ad;
        }

        public void OgrenciEkle(int OgrenciNo, string OgrenciAdi,string OgrenciSoyadi,int OgrenciBolum,string OgrenciDuzey)
        {
            try
            {
                Ogrenci ogrenci=new Lisans(0,"0","0",0); //boş oluşturuldu bi anlamı yok sadece aşağıda hata vermesin diye
                //Ogrenci ogrenci = new Ogrenci(OgrenciNo, OgrenciAdi, OgrenciSoyadi,OgrenciBolum);
                switch (OgrenciDuzey)
                {
                    case "Lisans": ogrenci = new Lisans(OgrenciNo, OgrenciAdi, OgrenciSoyadi, OgrenciBolum);
                        break;
                    case "YuksekLisans": ogrenci = new YuksekLisans(OgrenciNo, OgrenciAdi, OgrenciSoyadi, OgrenciBolum);
                        break;
                    case "Doktora": ogrenci = new Doktora(OgrenciNo, OgrenciAdi, OgrenciSoyadi, OgrenciBolum);
                        break;
                }

                BolumdekiOgrencilerList.Add(OgrenciNo,ogrenci); //aşağısı
            }
            catch(FormatException)
            {
                MessageBox.Show("Hatali Giris");
            }
            catch (Exception fe)
            {
                MessageBox.Show("Ogrenci bulunmakta");
            }
        }
        public void OgrenciSil(int id)
        {
            BolumdekiOgrencilerList.Remove(id);
        }
        public void DersEkle(int DersKodu, string DersAdi)
        {
            try
            {
                Ders derskayit = new Ders(DersKodu, DersAdi);
                DersList.Add(DersKodu, derskayit);

            }
            catch (Exception e)
            {
                throw new Exception("Ders Bulunmakta");
            }

           
        }

        public void DersSil(int DersKodu, string DersAdi)
        {
            try
            {
                DersList.Remove(DersKodu);
            }
            catch (Exception fe)
            {
                MessageBox.Show("Hatali Giriş");
            }
           
        }

        public void OgretimElemaniEkle(int No, string Ad, string Soyad,int bolum)
        {
            try
            {
                OgretimElemani ogrele = new OgretimElemani(No, Ad, Soyad,bolum);
                OgretimElemaniList.Add(No,ogrele);
            }
           
            catch(Exception e)
            {
                MessageBox.Show("Ogretim Elemani Bulunmakta!!");
            }
        }

        

        public void OgretimElemaniSil(int No)
        {
            try
            {
                
                OgretimElemaniList.Remove(No);
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
