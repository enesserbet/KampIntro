using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("müşteri Adı Giriniz");
            Musteri musteri1 = new Musteri();
            musteri1.Adi = Console.ReadLine();
            Console.WriteLine("Müşteri Soyadı giriniz");
            musteri1.Soyadi = Console.ReadLine();
            musteri1.Id = 12345;
            Console.WriteLine("---------------------------");



            Console.WriteLine("müşteri Adı Giriniz");
            Musteri musteri2 = new Musteri();
            musteri2.Adi = Console.ReadLine();
            Console.WriteLine("Müşteri Soyadı giriniz");
            musteri2.Soyadi = Console.ReadLine();
            musteri2.Id = 6789;
            Console.WriteLine("---------------------------");

        }
    }
}
