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
                MessageBox.Show("Hata");
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
    }
    }

