using System;

namespace MetotlarDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Urunler urun1 = new Urunler();
            urun1.Adi = "Elma";
            urun1.Fiyati = 12;
            urun1.Aciklama = "Yeşil Elma";
            urun1.Stok = 432;

            Urunler urun2 = new Urunler();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 25;
            urun2.Aciklama = "Kelek Olmayan Garpuz";
            urun2.Stok = 4421;

            Urunler urun3 = new Urunler();
            urun3.Adi = "Erik";
            urun3.Fiyati = 88;
            urun3.Aciklama = "Yengeniz gibi KÜTÜR KÜTÜR!";
            urun3.Stok = 42232;

            Urunler[] urunler = new Urunler[] {urun1,urun2,urun3 };

            foreach (Urunler a in urunler)
            {
                Console.WriteLine(a.Adi);
                Console.WriteLine(a.Fiyati+ " TL");
                Console.WriteLine(a.Aciklama);
                Console.WriteLine(a.Stok+" Tane mevcut");
                Console.WriteLine("------------------------------");
            }

            Console.WriteLine("---------------Methot----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
        }
    }
}
