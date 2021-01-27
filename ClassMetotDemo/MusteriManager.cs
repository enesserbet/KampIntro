using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteriler abc)
        {
            Console.WriteLine("Tebrikler Müşteri Eklendi : "+abc.Adi+" " +abc.Soyadi);
            Console.WriteLine("Eklenen Müşteri ID'si : " + abc.Id);
            Console.WriteLine("------------------------------------------");
        }
        public void Sil(Musteriler acx)
        {
            Console.WriteLine("Musteri Sistemden Silindi : " + acx.Adi + " " + acx.Soyadi);
            Console.WriteLine("Silinen Müşteri ID'si : "+ acx.Id);
            Console.WriteLine("------------------------------------------");
        }
        public void Listele(Musteriler acv)
        {
            
        }
    }
}
