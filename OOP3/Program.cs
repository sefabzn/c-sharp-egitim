using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            KonutKrediManager konutKrediManager = new KonutKrediManager();
         

            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
           

            //BAŞTAKİ İSMİ BASE İSİM İLE DEGİŞTİREBİLİRİZ

            IKrediManager tasitKrediManager = new TasitKrediManager();


            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();

            //    basvuruManager.BasvuruYap(tasitKrediManager,fileLoggerService); //Tek bir log türü  yazdırmak için

            List<ILoggerService> loggerServices = new List<ILoggerService>()
            {
                databaseloggerService,fileLoggerService   //Birden Çok log türü yazdırmak için
            };

            basvuruManager.BasvuruYap(tasitKrediManager, loggerServices);

            List<IKrediManager> krediler = new List<IKrediManager>()
            {
              konutKrediManager,ihtiyacKrediManager
            };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);





           
        }
    }
}
