using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Mylist<string> liste1 = new Mylist<string>();
            liste1.Add("Sefa");

            Console.WriteLine(liste1.length);
            liste1.Add("Merve");

            Console.WriteLine(liste1.length);
            liste1.Add("Şuayip");

            Console.WriteLine(liste1.length);

            
        }
    }
}
