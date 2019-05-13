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
    public partial class DersEkle : Form
    {
        public DersEkle()
        {
            InitializeComponent();
        }
        public static int DersNo;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")//textboxlar boş değilse
                {
                    Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].DersEkle(Convert.ToInt32(textBox1.Text),textBox2.Text);//ders ekleme metodunun çağırılması
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    throw new Exception();//bossa hata verme
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Girişte Format Hatası");
            }
            catch (Exception)
            {
                MessageBox.Show("Ders Giriniz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dersler.Items.Clear();
            try
            {
                foreach (Ders d in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].DersList.Values)//fakultenin içinde olan bolume eklenen dersleri göstermek için
                {
                    Dersler.Items.Add(d.dersKodu + " - " + d.dersAdi);//ders kodu ve adını ekler 
                    if (Dersler == null)//bossa hata verme
                    {
                        throw new Exception();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Fakulte Bulunmamaktadır.");

            }
        }

        private void DersEkle_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            BolumEkran be = new BolumEkran();
            be.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DersEkle.DersNo = Convert.ToInt32(textBox3.Text);//Ders no yu textbox a eşitler
                DerseOgrenciEkleme doe = new DerseOgrenciEkleme();
                doe.Show();//derse ogrenci ekleme formumun açılması
                if (textBox3 == null)//bos olursa hata 
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ders numarası girin");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)//derse atanan öğrenciler listesini gösterme butonu
        {
            DerseEklenenOgrenciler.Items.Clear();
            DersNo = Convert.ToInt32(textBox3.Text);
            foreach (Ogrenci o in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].DersList[DersEkle.DersNo].DersteKayitliOgrenciList.Values)
            {
                DerseEklenenOgrenciler.Items.Add(o.ogrenciBolum + " " + o.ogrenciNo + " " + o.ogrenciAdi + " " + o.ogrenciSoyadi + " " + o.GetType()+" "+o.Sube);
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click_1(object sender, EventArgs e)//dosyaya yazdırma metodu
        {
            foreach (Ders de in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].DersList.Values)
            {
                Yazdir.Yazma(de);
            }
            MessageBox.Show("Yazdirildi");
        }

        private void button7_Click_1(object sender, EventArgs e)//derse atanan öğrenciyi dersten silme
        {
            try
            {
                int i = 0;
                int maxdeger = Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].BolumdekiOgrencilerList.Count;
                if (maxdeger == 0)
                    throw new Exception();
                foreach (Ogrenci ogr in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].DersList[DersEkle.DersNo].DersteKayitliOgrenciList.Values)
                {
                    i++;
                    if (ogr.ogrenciNo == Convert.ToInt32(textBox4.Text))
                    {
                        Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].DersList[DersEkle.DersNo].OgrenciSilme(ogr.ogrenciNo);

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
                MessageBox.Show("Silmek İstediğiniz Ogretim Elemani bulunmamaktadır.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                DersEkle.DersNo = Convert.ToInt32(textBox6.Text);//ders no yu textboxa eşitleme
                DerseOgretimElemaniEkleme doge = new DerseOgretimElemaniEkleme();
                doge.Show();//ogretim elemanı atama sayfasını gösterme
                if (textBox6 == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ders numarası girin");
            }
        }

        private void button8_Click(object sender, EventArgs e)//derse atanan öğretim elemanını silme
        {
            try//silme buttonlarının içleri birbirine benzemektedir 
            {
                int i = 0;
                int maxdeger = Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].OgretimElemaniList.Count;
                if (maxdeger == 0)
                    throw new Exception();
                foreach (OgretimElemani ogr in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].DersList[DersEkle.DersNo].DerseKayitliOgretimElemani.Values)
                {
                    i++;
                    if (ogr.ogretimElemaniNo == Convert.ToInt32(textBox5.Text))
                    {
                        Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].DersList[DersEkle.DersNo].OgretimElemaniSilme(ogr.ogretimElemaniNo);

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
                MessageBox.Show("Silmek İstediğiniz Ogretim Elemani bulunmamaktadır.");
            }
        }

        private void button9_Click(object sender, EventArgs e)//Derse atanan öğretim elemanını gösterme butonu
        {
            try
            {
                DerseEklenenOgretimElemanlari.Items.Clear();
                DersNo = Convert.ToInt32(textBox6.Text);
                foreach (OgretimElemani o in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].DersList[DersEkle.DersNo].DerseKayitliOgretimElemani.Values)
                {
                    DerseEklenenOgretimElemanlari.Items.Add("OgrEleBolum:" + o.ogretimelemaniBolum + "--OgrElemaniNo: " + o.ogretimElemaniNo + "--OgrEleAd: " + o.ogretimElemaniAd + "--OgrEleSoyad: " + o.ogretimElemaniSoyad + " " + o.GetType());

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ogretim Elemani Atamadınız");
            }
        }
    }
    }

