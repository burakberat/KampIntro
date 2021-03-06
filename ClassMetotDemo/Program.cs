﻿using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Burak";
            musteri1.Soyad = "Orucoglu";
            musteri1.Cinsiyet = "Erkek";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ahmet";
            musteri2.Soyad = "Ünlü";
            musteri2.Cinsiyet = "Erkek";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı: " + musteri.Ad);
                Console.WriteLine("Müşteri Soyadı: "+ musteri.Soyad);
                Console.WriteLine("Müşteri Cinsiyeti: " + musteri.Cinsiyet);
                Console.WriteLine("--------------");
            }


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);

            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager1.Listele(musteri1);

            MusteriManager musteriManager2 = new MusteriManager();
            musteriManager2.Sil(musteri2);
        }
    }
}
