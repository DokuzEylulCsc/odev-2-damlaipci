using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversiteSistemi
{
    class Fakulte
    {
        public Dictionary<int, Bolum> BolumList = new Dictionary<int, Bolum>();//bolum açacağım için bolum listesi yaptım
        private int FakulteNo;
        private string FakulteAdi;

        public int fakulteNo//kapsülledim
        {
            get { return FakulteNo; }
            set { FakulteNo = value; }
        }
        public string fakulteAdi//kapsülledim
        {
            get { return FakulteAdi; }
            set { FakulteAdi = value; }
        }

        public Fakulte(int No, string Ad)//constructor
        {
            FakulteNo = No;
            FakulteAdi = Ad;
        }

        public void BolumEkle(int BolumNo, string BolumAdi)//fakulteye bolum ekleme
        {
            //bool flag;
            try
            {
                Bolum bolum= new Bolum(BolumNo, BolumAdi);
                BolumList.Add(BolumNo,bolum);
            }
            catch(FormatException)
            {
                MessageBox.Show("format hatası");
            }
           
            catch(Exception)
            {
               MessageBox.Show("Bolum Mevcut!");
            }
        }

        public void BolumSil(int BolumID,string BolumAdi)//fakulteden bolum silme
        {
            try
            {
                BolumList.Remove(BolumID);
            }
            
            catch (Exception)
            {
                MessageBox.Show("Bolum Yok!");
            }
        }
    }
}
