using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteSistemi
{
    class Fakulte
    {
        public Dictionary<int, Bolum> Bolum = new Dictionary<int, Bolum>();
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

        public void BolumEkle(int BolumID, string BolumAd)
        {
            try
            {
                Bolum.Add(BolumID,BolumAd);
            }
            catch (FormatException)
            {

                throw new ArgumentException("Eklemek istediginiz bolum mevcut !!");
            }
        }

        public void BolumSil(int BolumID)
        {
            try
            {
                Bolumler.Remove(BolumID);
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("Silmek istediginiz bolum mecvut degil !!");
            }
        }
    }
}
