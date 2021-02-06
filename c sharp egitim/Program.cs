using System;

namespace c_sharp_egitim
{
    class Ogrenci
    {
        public string OgrAd { get; set; }
        public string OgrSınıf { get; set; }
        public int    OgrNot { get; set; }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
        Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.OgrAd = "Yigit";
            ogrenci1.OgrSınıf = "5";
            ogrenci1.OgrNot = 45;
        Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.OgrAd = "Ali";
            ogrenci2.OgrSınıf = "1";
            ogrenci2.OgrNot = 60;
        Ogrenci ogrenci3 = new Ogrenci();
            ogrenci3.OgrAd = "Gülbahar";
            ogrenci3.OgrSınıf = "2";
            ogrenci3.OgrNot = 70;

            Ogrenci[] ogrenciler = new Ogrenci[]
            {
                ogrenci1,ogrenci2,ogrenci3,
            };


            foreach (var ogrencibilgi in ogrenciler)
            {
                Console.WriteLine(ogrencibilgi.OgrAd+" "+ogrencibilgi.OgrSınıf);
               
            }





        }
      
    }
}
