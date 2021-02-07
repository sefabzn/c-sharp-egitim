using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {


            Product product1 = new Product();
            product1.CategoryId = 1;
            product1.Id = 1;
            product1.ProductName = "Koltuk Takımı";
            product1.UnitPrice = 3500;
            product1.UnitsInStock = 200;

            //Böyle de kullanılabilir
            Product product2 = new Product
            {
                Id = 2, CategoryId = 1, ProductName = "Sandalye", UnitPrice = 60, UnitsInStock = 400
            };













        }
    }
}
