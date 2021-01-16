using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi: " + urun.Adi);

        }

        public void Ekle2 (string urunAdi, string aciklama, double fiyat) //bu kullanım ilkine göre hatalı bir kullanım!!!
        {
            Console.WriteLine("Sepete Eklendi: " + urunAdi + " " + aciklama + " " + fiyat);
        }
    }
}
