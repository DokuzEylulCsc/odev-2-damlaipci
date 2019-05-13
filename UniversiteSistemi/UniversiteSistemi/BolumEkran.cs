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
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Baslangıc bas = new Baslangıc();
            bas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    Universite.FakulteList[Baslangıc.FakulteNo].BolumEkle(Convert.ToInt32(textBox1.Text), textBox2.Text);
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
                foreach (Bolum b in Universite.FakulteList[Baslangıc.FakulteNo].BolumList.Values)
                {
                    BolumListesi.Items.Add(b.bolumNo + " - " + b.bolumAdi);
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
            try
            {
                BolumNo = Convert.ToInt32(textBox3.Text);
                int i = 0;
                int maxdeger = Universite.FakulteList[Baslangıc.FakulteNo].BolumList.Count;
                if (maxdeger == 0)
                    throw new Exception();
                foreach (Bolum b in Universite.FakulteList[Baslangıc.FakulteNo].BolumList.Values)
                {
                    i++;
                    if (b.bolumNo == BolumNo)
                    {
                        Universite.FakulteList[Baslangıc.FakulteNo].BolumSil(b.bolumNo, b.bolumAdi);
                        BolumListesi.Items.Remove(b.bolumNo + " - " + b.bolumAdi);
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
                BolumEkran.BolumNo = Convert.ToInt32(textBox5.Text);
                OgrIslemleri ogrislemleri = new OgrIslemleri();
                ogrislemleri.Show();
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
                foreach (Ogrenci ogre in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].BolumdekiOgrencilerList.Values)
                {
                    OgrenciListesi.Items.Add("OgrenciBolum:" + ogre.ogrenciBolum+ "--Ogrenci NO:"+ogre.ogrenciNo + "--Ogrenci Adı:" + ogre.ogrenciAdi + "--Ogrenci Soyadi:" + ogre.ogrenciSoyadi + "-Duzeyi:" + ogre.GetType().ToString());
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
                BolumEkran.BolumNo = Convert.ToInt32(textBox5.Text);
                OgrEleIslemi ogreleislemleri = new OgrEleIslemi();
                ogreleislemleri.Show();
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
                foreach (OgretimElemani ogrele in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].OgretimElemaniList.Values)
                {
                    OgretimElemanlari.Items.Add("OgrEleBolum:" +ogrele.ogretimelemaniBolum + "-OgrEleNo:" + ogrele.ogretimElemaniNo + "-OgrEleAdi:" + ogrele.ogretimElemaniAd+ "-OgrEleSoyadi:" + ogrele.ogretimElemaniSoyad);
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
                int maxdeger = Universite.FakulteList[Baslangıc.FakulteNo].BolumList.Count, i = 0;
                if (maxdeger == 0)
                    throw new Exception();
                BolumNo = Convert.ToInt32(textBox4.Text);
                foreach (Bolum b in Universite.FakulteList[Baslangıc.FakulteNo].BolumList.Values)
                {
                    i++;
                    if (b.bolumNo == BolumNo)
                    {
                        this.Hide();
                        DersEkle de = new DersEkle();
                        de.Show();
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
