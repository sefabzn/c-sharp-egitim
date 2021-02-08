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

            HesaplamaManager hesaplamaManager = new HesaplamaManager();
            hesaplamaManager.Hesaplama(ortalama1, 8, 4);






        }
    }
}
