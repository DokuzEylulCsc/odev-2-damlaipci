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
    public partial class OgrIslemleri : Form
    {
        public OgrIslemleri()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string duzey = "";
            
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text!= "")
                {
                    if (radioButton1.Checked)
                        duzey = "Lisans";
                    else if (radioButton2.Checked)
                        duzey = "YuksekLisans";
                    else if (radioButton3.Checked)
                        duzey = "Doktora";
                    Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].OgrenciEkle(Convert.ToInt32(textBox1.Text), textBox2.Text,textBox3.Text,BolumEkran.BolumNo,duzey);
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
                MessageBox.Show("Ogrenci Giriniz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                int maxdeger = Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].BolumdekiOgrencilerList.Count;
                if (maxdeger == 0)
                    throw new Exception();
                foreach (Ogrenci ogrenci in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].BolumdekiOgrencilerList.Values)
                {
                    i++;
                    if (ogrenci.ogrenciNo == Convert.ToInt32(textBox4.Text))
                    {
                        Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].OgrenciSil(ogrenci.ogrenciNo);
                        
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
                MessageBox.Show("Silmek istediğiniz Ogrenci bulunmamaktadır");
            }
        }

        private void OgrIslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
