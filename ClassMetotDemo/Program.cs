using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteriler musteri1 = new Musteriler();
            musteri1.Adi = "Mahmut";
            musteri1.Soyadi = "Şeker";
            musteri1.Id = 2019030;

            Musteriler musteri2 = new Musteriler();
            musteri2.Adi = "Talha Enes";
            musteri2.Soyadi = "Şerbet";
            musteri2.Id = 2020030;

            Musteriler[] musteriler = new Musteriler[] { musteri1, musteri2};

            foreach (var musterii in musteriler)
            {
                Console.WriteLine(musterii.Id + " : " + musterii.Adi + " " + musterii.Soyadi);
                

            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);

            
        }
    }
}
