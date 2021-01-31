using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GerçekMusteri musteri1 = new GerçekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "21312";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.TcNo = "32222121231";
            //Tuzel kişi
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "41512";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "432232";
            //Gerçek - Tüzel
            //SOLİD

            Musteri musteri3 = new GerçekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
        }
    }
}
