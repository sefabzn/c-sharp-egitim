using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Fındık";
            urun1.Fiyati = 12;
            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 6;

            Product[] urunler = new Product[]
            {
                urun1,urun2
            };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
            }
            Console.WriteLine("---------------------");

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);




        }
    }
}
