using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {


            RealCustomer musteri1 = new RealCustomer();

            musteri1.CustomerName = "Ahmet";
            musteri1.CustomerSurname = "Yalamayısever";
            musteri1.CustomerNumber =" 123";
            musteri1.Id = 1;
            musteri1.IdentityNumber = "23333333";


            CorparateCustomer musteri2 = new CorparateCustomer();

            musteri2.Id = 2;
            musteri2.CustomerNumber = "322";
            musteri2.CompanyName = "AmatistKonutları";
            musteri2.TaxId = "2351";

            Customer musteri3 = new CorparateCustomer();
            Customer musteri4 = new RealCustomer();
            //Customer her iki classı da tutar









        }
    }
}
