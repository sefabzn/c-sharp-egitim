using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar1 = new int[]
            {
                12,3,4
            };
            int[] sayilar2 = new int[]
            {
                27,6,9
            };
            sayilar1 = sayilar2;
            sayilar2[0] = 31;
            Console.WriteLine(sayilar1[0]);
        }
    }
}
