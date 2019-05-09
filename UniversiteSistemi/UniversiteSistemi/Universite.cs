using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversiteSistemi
{
    class Universite
    {
        public static Dictionary<int, Fakulte> FakulteList = new Dictionary<int, Fakulte>();
        

        public void FakulteEkle(int FakulteNo, string FakulteAdi)// Fakulte Ekleme metodu.
        {
            try
            {
                Fakulte fakulte = new Fakulte(FakulteNo, FakulteAdi);
                FakulteList.Add(FakulteNo,fakulte);
            }
           
            catch (Exception)
            {
                MessageBox.Show("Fakulte Bulunmaktadır");
            }
        }
        public void FakulteSil(int FakulteNo,string FakulteAdi)
        {
            try
            {
                FakulteList.Remove(FakulteNo);
            }
            
            catch(Exception e)
            {
                MessageBox.Show("Fakulte Bulunmamaktadır!!");

            }
        }
    }
}
