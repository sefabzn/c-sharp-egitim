using System;
using System.Collections.Generic;
using System.Text;

namespace OrtalamaHesaplama
{
    class IzometrikOrtalama : OrtalamaManager
    {
        public void hesapla(int sayi1, int sayi2)
        {
            Console.WriteLine((sayi1-sayi2)/2);
        }
    }
}
