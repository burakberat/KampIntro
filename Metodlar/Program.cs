﻿using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");

            }

            Console.WriteLine("--------------Metodlar---------------");

            SepetManager sepetManager = new SepetManager();  //instance - örnek oluşturuldu.
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //encapsulation yeni bir parametre(stok adedi) atamamıza rağmen kodların hata vermemesi.

            //sepetManager.Ekle2("Armut", "Yeşil", 12);

        }
    }
}
