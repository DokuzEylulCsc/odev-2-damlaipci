using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversiteSistemi
{
    public partial class BolumEkran : Form
    {

        public BolumEkran()
        {
            InitializeComponent();
        }
        public static int BolumNo;
        private void button5_Click(object sender, EventArgs e)//geri butonu
        {
            this.Hide();
            Baslangıc bas = new Baslangıc();
            bas.Show();//baslangıc ekranına dönme
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")//textboxlar boş işe
                {
                    Universite.FakulteList[Baslangıc.FakulteNo].BolumEkle(Convert.ToInt32(textBox1.Text), textBox2.Text);//Universitenin içinde bulunan fakultelistine bir nevi bölüm ekler
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Girişte Format Hatası");
            }
            catch (Exception)
            {
                MessageBox.Show("Bolum No Giriniz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BolumListesi.Items.Clear();
            try
            {
                foreach (Bolum b in Universite.FakulteList[Baslangıc.FakulteNo].BolumList.Values)//eklenen fakulteleri listboxda gösterir
                {
                    BolumListesi.Items.Add(b.bolumNo + " - " + b.bolumAdi);// bolum adı ve no olarak gösterir
                    if (BolumListesi == null)
                    {
                        throw new Exception();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Bolum Bulunmamaktadır.");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try//bolum silme butonu
            {
                BolumNo = Convert.ToInt32(textBox3.Text);//bolum no textboxdakine eşitlenir
                int i = 0;
                int maxdeger = Universite.FakulteList[Baslangıc.FakulteNo].BolumList.Count;//max deger listedekilerin sayısına eşitlenir
                if (maxdeger == 0)
                    throw new Exception();
                foreach (Bolum b in Universite.FakulteList[Baslangıc.FakulteNo].BolumList.Values)
                {
                    i++;
                    if (b.bolumNo == BolumNo)//listedeki boolum no textboxdan tuttuğum bolumnosuna eşitse
                    {
                        Universite.FakulteList[Baslangıc.FakulteNo].BolumSil(b.bolumNo, b.bolumAdi);//Silme metodu çağırılır
                        BolumListesi.Items.Remove(b.bolumNo + " - " + b.bolumAdi);//listeden siler
                        break;
                    }
                    if (i == maxdeger)
                    {
                        throw new Exception();
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silmek istediğiniz bölüm bulunmamaktadır");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            
            try
            {
                BolumEkran.BolumNo = Convert.ToInt32(textBox5.Text);//bolum no textboxdakiyle aynı olduğunda
                OgrIslemleri ogrislemleri = new OgrIslemleri();
                ogrislemleri.Show();//ogrenci eklemek için ogrenci ekleme formu açılır
                if (textBox5 == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bolum numarası girin");
            }
        }
    


        private void OgrenciListesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                OgrenciListesi.Items.Clear();
                foreach (Ogrenci ogre in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].BolumdekiOgrencilerList.Values)//fakulte içine eklenen bölüme eklenen öğrencileri listboxda gösterme 
                {
                    OgrenciListesi.Items.Add("OgrenciBolum:" + ogre.ogrenciBolum+ "--Ogrenci NO:"+ogre.ogrenciNo + "--Ogrenci Adı:" 
                        + ogre.ogrenciAdi + "--Ogrenci Soyadi:" + ogre.ogrenciSoyadi + "-Duzeyi:" + ogre.GetType().ToString());//Ogrencinin bölümü,no,ad,soyad,duzeyi gosterir
                }
                if(OgrenciListesi==null)
                {
                    throw new Exception();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ogrenci Kayıt Etmediniz");
            }
        }

        private void BolumEkran_Load(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                BolumEkran.BolumNo = Convert.ToInt32(textBox5.Text);//bolum no textboxdakiyle aynı olduğunda
                OgrEleIslemi ogreleislemleri = new OgrEleIslemi();
                ogreleislemleri.Show();//ogretim elemani ekleme formu açılır
                if(textBox5==null)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bolum numarası girin");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                OgretimElemanlari.Items.Clear();
                foreach (OgretimElemani ogrele in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].OgretimElemaniList.Values)//fakulte içine eklenen bölüme eklenen öğretimelemanlarını listboxda gösterme
                {
                    OgretimElemanlari.Items.Add("OgrEleBolum:" +ogrele.ogretimelemaniBolum + "-OgrEleNo:" + ogrele.ogretimElemaniNo + "-OgrEleAdi:"
                        + ogrele.ogretimElemaniAd+ "-OgrEleSoyadi:" + ogrele.ogretimElemaniSoyad);//ogretim elemanının bolumu ,no,ad,soyadını gösterir
                }
                if (OgretimElemanlari == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ogretim Elemani Kayıt Etmediniz");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int maxdeger = Universite.FakulteList[Baslangıc.FakulteNo].BolumList.Count, i = 0;//max deger listedekilerin sayısına eşitlenir
                if (maxdeger == 0)//liste boşsa hata
                    throw new Exception();
                BolumNo = Convert.ToInt32(textBox4.Text);// bolum no textboxdan girilene eşitlenir
                foreach (Bolum b in Universite.FakulteList[Baslangıc.FakulteNo].BolumList.Values)
                {
                    i++;
                    if (b.bolumNo == BolumNo)//eşitlerse
                    {
                        this.Hide();
                        DersEkle de = new DersEkle();
                        de.Show();//ders ekleme ekranı açılır
                        break;
                    }
                    if (i == maxdeger)
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("HATA!!");
            }
        }
    }
}
