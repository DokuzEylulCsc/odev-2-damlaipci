using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UniKayit
{
    class Bolum:Fakulte
    {
        ArrayList List = new ArrayList();
        public void OgrenciKayit()
        {

        }
        public void OgrenciSil()
        {

        }
        public void OgrEleKayit(OgrElemani ogretimEleman)
        {
            List.Add(ogretimEleman);
        }
        public void OgrEleSil(OgrElemani ogretimEleman)
        {
            foreach (OgrElemani ogretimE in List)
            {
                if (ogretimE == ogretimEleman)
                {
                    List.Remove(ogretimEleman);

                }
            }
        }
        public void DersAc()
        {
            Ders ders = new Ders();
        }
        public void DersSil()
        {

        }
    }
}
