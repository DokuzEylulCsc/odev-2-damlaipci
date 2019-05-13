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
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].DersEkle(Convert.ToInt32(textBox1.Text),textBox2.Text);
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
                MessageBox.Show("Ders Giriniz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dersler.Items.Clear();
            try
            {
                foreach (Ders d in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].DersList.Values)
                {
                    Dersler.Items.Add(d.dersKodu + " - " + d.dersAdi);
                    if (Dersler == null)
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
                DersEkle.DersNo = Convert.ToInt32(textBox3.Text);
                DerseOgrenciEkleme doe = new DerseOgrenciEkleme();
                doe.Show();
                if (textBox3 == null)
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

        private void button3_Click_1(object sender, EventArgs e)
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

        private void button6_Click_1(object sender, EventArgs e)
        {
            foreach (Ders de in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].DersList.Values)
            {
                Yazdir.Yazma(de);
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
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
                DersEkle.DersNo = Convert.ToInt32(textBox6.Text);
                DerseOgretimElemaniEkleme doge = new DerseOgretimElemaniEkleme();
                doge.Show();
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

        private void button8_Click(object sender, EventArgs e)
        {
            try
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

        private void button9_Click(object sender, EventArgs e)
        {
            DerseEklenenOgretimElemanlari.Items.Clear();
            DersNo = Convert.ToInt32(textBox6.Text);
            foreach (OgretimElemani o in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].DersList[DersEkle.DersNo].DerseKayitliOgretimElemani.Values)
            {
                DerseEklenenOgrenciler.Items.Add("OgrEleBolum:"+o.ogretimelemaniBolum + "--OgrElemaniNo: " + o.ogretimElemaniNo + "--OgrEleAd: " + o.ogretimElemaniAd+ "--OgrEleSoyad: " + o.ogretimElemaniSoyad + " " + o.GetType());

            }
        }
    }
    }

