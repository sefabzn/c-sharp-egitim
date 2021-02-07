using System;

namespace OrtalamaHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {



            OrtalamaManager ortalama1 = new AritmetikOrtalama();
            OrtalamaManager ortalama2 = new GeometrikOrtalama();
            OrtalamaManager ortalama3 = new IzometrikOrtalama();

            ortalama1.hesapla(8, 4);
            ortalama2.hesapla(8, 4);
            ortalama3.hesapla(8, 4);






        }
    }
}
