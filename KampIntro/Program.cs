using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Sisteme Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Sisteme Giriş Başarız");
            }
        }
    }
}
