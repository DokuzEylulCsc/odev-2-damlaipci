using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteSistemi
{
    class Universite
    {
        public static Dictionary<int, Fakulte> Fakulteler = new Dictionary<int, Fakulte>();
        public void FakulteEkle(int FakulteId, string FakulteAd)// Fakulte Ekleme metodu.
        {
            try
            {
                Fakulteler.Add(FakulteId, new Fakulte(FakulteId, FakulteAd));
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("Eklemek istenen fakulte mevcut");
            }
        }
    }
}
