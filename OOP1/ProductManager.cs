using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{

    //ProductManager stores operations of that product... CRUD
    internal class ProductManager
    {

        public void Add1(Product product)
        {
            product.ProductName = "Camera";
        }

        //Simulation ....
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " added.");
        }

        public void Update(Product  product)
        {

            Console.WriteLine(product.ProductName + " updated.");

        }



    }
}
