﻿using System;
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
    public partial class DerseOgrenciEkleme : Form
    {
        public DerseOgrenciEkleme()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                bolumogrenciler.Items.Clear();
                foreach (Ogrenci ogre in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].BolumdekiOgrencilerList.Values)
                {
                    bolumogrenciler.Items.Add("OgrenciBolum:" + ogre.ogrenciBolum + "-Ogrenci NO:" + ogre.ogrenciNo + "-Ogrenci Adı:" + ogre.ogrenciAdi + "-Ogrenci Soyadi:" + ogre.ogrenciSoyadi + "-Duzeyi:" + ogre.GetType().ToString());
                }
                if (bolumogrenciler == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ogrenci Kayıt Etmediniz");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

                foreach (Ogrenci o in Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].BolumdekiOgrencilerList.Values)
                {
                    if (Convert.ToInt32(textBox1.Text) == o.ogrenciNo)
                    {
                        Universite.FakulteList[Baslangıc.FakulteNo].BolumList[BolumEkran.BolumNo].DersList[DersEkle.DersNo].OgrenciAta(o.ogrenciNo, o);
                    }
                }
                
        }
    }
}