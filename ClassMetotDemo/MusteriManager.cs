﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Yeni Müşteri Eklendi: " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Listele(Musteri musteri)
        {
            Musteri[] musteriler = new Musteri[] { };
            foreach (Musteri musteri1 in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Cinsiyet);
            }
            
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi: " + musteri.Ad + " " + musteri.Soyad);
        }
    }
}
