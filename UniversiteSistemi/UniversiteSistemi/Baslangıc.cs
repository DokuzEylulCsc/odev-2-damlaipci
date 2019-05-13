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


                if (textBox1.Text != "" && NameTxtBox.Text != "")//textboxlar doluysa
                {


                    universite.FakulteEkle(Convert.ToInt32(textBox1.Text), NameTxtBox.Text);//textboxlardan no ve ad alıp ekliyor.
                    textBox1.Clear();
                    NameTxtBox.Clear();
                }

                else
                {
                    throw new Exception();
                }
            }
            catch(FormatException)//format hatasını yakalar mesaj verir
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
                int maxdeger = Universite.FakulteList.Count, i = 0;//max degeri fakultelist in sayısına eşitler
                if (maxdeger == 0)//max deger 0 sa hata verir
                    throw new Exception();
                FakulteNo = Convert.ToInt32(NoTxtBox.Text);
                foreach (Fakulte f in Universite.FakulteList.Values)
                {
                    i++;
                    if (f.fakulteNo == FakulteNo)// eger fakulte numaraları birbirlerini sağlıyolarsa
                    {
                        this.Hide();
                        BolumEkran be = new BolumEkran();
                        be.Show();//bolum ekranını açar
                        break;
                    }
                    if (i == maxdeger)
                    {
                        throw new Exception();
                    }
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Format hatası");
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
                foreach (Fakulte f in Universite.FakulteList.Values)//listoxda eklediğim fakulteleri göstermesi için goster butonu
                {
                    FakülteListesi.Items.Add(f.fakulteNo + " - " + f.fakulteAdi);//fakulte no ve fakulte adi ni yazdırıyor
                    if(FakülteListesi==null)//boşsa hata verdirir
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
                FakulteNo = Convert.ToInt32(textBox2.Text);//textboxa girileni fakulte no ya eşitler
                int i = 0;//sayac
                int maxdeger = Universite.FakulteList.Count;//fakulte listesindeki degerleri max olarak alır
                if (maxdeger == 0)
                    throw new Exception();//eger max deger 0 sa yani listede fakulte yoksa hata mesajı verdirir
                foreach (Fakulte f in Universite.FakulteList.Values)
                {
                    i++;//fakulte eklendiğinde sayac artar
                    if (f.fakulteNo == FakulteNo)//tutulan fakulte numarasına eşitse
                    {
                        universite.FakulteSil(f.fakulteNo, f.fakulteAdi);//fakulte silinir
                        FakülteListesi.Items.Remove(f.fakulteNo + " - " + f.fakulteAdi);// listeden silmesi için
                        break;
                    }
                    if (i == maxdeger)//sayac max deger eşitsede hata verir
                    {
                        throw new Exception();
                    }
                   
                }
            }
            catch(Exception )//hata mesajı
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

        private void FakülteListesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
