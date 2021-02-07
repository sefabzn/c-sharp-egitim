using System;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci();
            Ogrenci ogr2 = new Ogrenci();
            Ogrenci ogr3 = new Ogrenci();

            ogr1.ograd = "Muharrem";
            ogr1.ogrsoy = "Gül";
            ogr1.ogryas = 32;

            ogr2.ograd = "Melih Can";
            ogr2.ogrsoy = "Bazan";
            ogr2.ogryas = 18;

            ogr3.ograd = "Mert";
            ogr3.ogrsoy = "ikidörtiki";
            ogr3.ogryas = 22;


            OgrenciManager ogrencimanager = new OgrenciManager();

            ogrencimanager.OgrEkleme(ogr1);
            ogrencimanager.OgrEkleme(ogr2);
            ogrencimanager.OgrEkleme(ogr3);


        }
    }
}
