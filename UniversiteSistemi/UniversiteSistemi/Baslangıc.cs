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
    public partial class Baslangıc : Form
    {
        public Baslangıc()
        {
            InitializeComponent();
        }
        Universite universite = Universite.GetInstance();
       
        public static int FakulteNo;
        bool flag;
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {


                if (textBox1.Text != "" && NameTxtBox.Text != "")
                {


                    universite.FakulteEkle(Convert.ToInt32(textBox1.Text), NameTxtBox.Text);
                    textBox1.Clear();
                    NameTxtBox.Clear();
                }

                else
                {
                    throw new Exception();
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Girişte Format Hatası");
            }
            catch(Exception)
            {
                MessageBox.Show("Birşey giriniz");
            }
         }   
    




        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int maxdeger = Universite.FakulteList.Count, i = 0;
                if (maxdeger == 0)
                    throw new Exception();
                FakulteNo = Convert.ToInt32(NoTxtBox.Text);
                foreach (Fakulte f in Universite.FakulteList.Values)
                {
                    i++;
                    if (f.fakulteNo == FakulteNo)
                    {
                        this.Hide();
                        BolumEkran be = new BolumEkran();
                        be.Show();
                        break;
                    }
                    if (i == maxdeger)
                    {
                        throw new Exception();
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Fakulte No Giriniz");
            }
            
            
        }

        private void Baslangıc_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FakülteListesi.Items.Clear();
            try
            {
                foreach (Fakulte f in Universite.FakulteList.Values)
                {
                    FakülteListesi.Items.Add(f.fakulteNo + " - " + f.fakulteAdi);
                    if(FakülteListesi==null)
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            try {
                FakulteNo = Convert.ToInt32(textBox2.Text);
                int i = 0;
                int maxdeger = Universite.FakulteList.Count;
                if (maxdeger == 0)
                    throw new Exception();
                foreach (Fakulte f in Universite.FakulteList.Values)
                {
                    i++;
                    if (f.fakulteNo == FakulteNo)
                    {
                        universite.FakulteSil(f.fakulteNo, f.fakulteAdi);
                        FakülteListesi.Items.Remove(f.fakulteNo + " - " + f.fakulteAdi);
                        break;
                    }
                    if (i == maxdeger)
                    {
                        throw new Exception();
                    }
                   
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Silmek istediğiniz fakülte bulunmamaktadır");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
