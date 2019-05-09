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
        public Dictionary<int, Bolum> BolumList = new Dictionary<int, Bolum>();
        private int FakulteNo;
        private string FakulteAdi;

        public int fakulteNo
        {
            get { return FakulteNo; }
            set { FakulteNo = value; }
        }
        public string fakulteAdi
        {
            get { return FakulteAdi; }
            set { FakulteAdi = value; }
        }

        public Fakulte(int No, string Ad)
        {
            FakulteNo = No;
            FakulteAdi = Ad;
        }

        public void BolumEkle(int BolumNo, string BolumAdi)
        {
            bool flag;
            try
            {
                Bolum bolum= new Bolum(BolumNo, BolumAdi);
                BolumList.Add(BolumNo,bolum);
            }
           
            catch(Exception)
            {
               MessageBox.Show("Bolum Mevcut!");
            }
        }

        public void BolumSil(int BolumID,string BolumAdi)
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
