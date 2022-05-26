using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1'st type of setting values...
            Product product = new Product();
            product.Id = 1;
            product.CategoryId = 2;
            product.ProductName = "Desk";
            product.UnitPrice = 100;
            product.UnitsInStock = 10;


            // 2'nd type of setting values...
            Product product1 = new Product 
            {
                Id = 2,
                CategoryId = 3,
                ProductName = "Mouse",
                UnitPrice = 50,
                UnitsInStock = 5
            
            };

            // PascalCase   camelCase - SOLID
            ProductManager productManager1   = new ProductManager();
            productManager1.Add1(product);
           
            // Because it's ref type points same object ....and the value will be cahanged to camera.
            Console.WriteLine(product.ProductName); 
            

            ProductManager productManager2 = new ProductManager();
            productManager2.Add(product);



        }
    }
}
