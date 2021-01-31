using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            //sorun olmuyor 
            IKrediManager taşıtKrediManager = new TaşıtKrediManager();
            taşıtKrediManager.Hesapla();


            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla(); 
        }
    }
}
