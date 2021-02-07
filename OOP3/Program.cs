using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            KonutKrediManager konutKrediManager = new KonutKrediManager();
         

            IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
           

            //BAŞTAKİ İSMİ BASE İSİM İLE DEGİŞTİREBİLİRİZ

            IKrediManager tasitKrediManager = new TasitKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager);
           
        }
    }
}
