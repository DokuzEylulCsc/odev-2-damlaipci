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
            catch (Exception )
            {
                MessageBox.Show("Hata");
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
            BolumEkran.BolumNo = Convert.ToInt32(textBox5.Text);
            OgrIslemleri ogrislemleri = new OgrIslemleri();
            ogrislemleri.Show();
        }

        private void OgrenciListesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {// try catch ekle
            OgrenciListesi.Items.Clear();
            foreach(Ogrenci ogre in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].BolumdekiOgrencilerList.Values)
            {
                OgrenciListesi.Items.Add(ogre.ogrenciNo + " " + ogre.ogrenciAdi + " " + ogre.ogrenciSoyadi + " " + ogre.ogrenciBolum + " " + ogre.GetType().ToString());
            }
        }

        private void BolumEkran_Load(object sender, EventArgs e)
        {
        }
    }
}
