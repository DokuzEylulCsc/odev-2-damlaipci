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
    public partial class OgrEleIslemi : Form
    {
        public OgrEleIslemi()
        {
            InitializeComponent();
        }

        private void OgrEleIslemi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].OgretimElemaniEkle(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, BolumEkran.BolumNo);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
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
                MessageBox.Show("Hatalı Giris");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                int maxdeger = Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].OgretimElemaniList.Count;
                if (maxdeger == 0)
                    throw new Exception();
                foreach (OgretimElemani ogrele in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].OgretimElemaniList.Values)
                {
                    i++;
                    if (ogrele.ogretimElemaniNo == Convert.ToInt32(textBox4.Text))
                    {
                        Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].OgretimElemaniSil(ogrele.ogretimElemaniNo);

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
    }
}
   
