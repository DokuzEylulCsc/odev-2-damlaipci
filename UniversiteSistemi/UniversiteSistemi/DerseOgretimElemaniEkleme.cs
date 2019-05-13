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
    public partial class DerseOgretimElemaniEkleme : Form
    {
        public DerseOgretimElemaniEkleme()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                bolumogretimelemanlari.Items.Clear();
                foreach (OgretimElemani ogrele in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].OgretimElemaniList.Values)
                {
                    bolumogretimelemanlari.Items.Add("OgrEleBolum:" + ogrele.ogretimelemaniBolum + "-OgrEleNo:" + ogrele.ogretimElemaniNo + "-OgrEleAdi:" + ogrele.ogretimElemaniAd + "-OgrEleSoyadi:" + ogrele.ogretimElemaniSoyad);
                }
                if (bolumogretimelemanlari == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ogretim Elemani Kayıt Etmediniz");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { try
            {


                foreach (OgretimElemani ogr in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].OgretimElemaniList.Values)
                {
                    if (Convert.ToInt32(textBox1.Text) == ogr.ogretimElemaniNo)
                    {
                        Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].DersList[DersEkle.DersNo].OgretimElemaniAtama(ogr.ogretimElemaniNo, ogr);
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ogretim Elemani No Girin ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DersEkle de = new DersEkle();
            this.Hide();
            de.Show();
        }

        private void DerseOgretimElemaniEkleme_Load(object sender, EventArgs e)
        {

        }
    }
}
