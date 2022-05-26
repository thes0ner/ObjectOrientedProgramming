using System;
using System.Collections.Generic;

namespace GenericLists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Intro to List
            //var productList = new List<string>()
            //{
            //    "product 001",
            //    "product 002",
            //    "product 003"
            //};

            //var productList2 = new List<string>()
            //{
            //    "product 1001",
            //    "product 1002",
            //    "product 1003",
            //    "product 1004",
            //};

            ////Inserts all data to the list.
            //productList.AddRange(productList2);

            ////Inserts data at specific index.
            //productList.Insert(0, "product 000");

            ////Deletes data at specific object
            //productList.Remove("product 1001");

            //for (int i = 0; i < productList.Count; i++)
            //{
            //    var productName = productList[i];
            //    Console.WriteLine(productName);
            //}
            #endregion


            var  productList = new List<Product>()
            {
                new Product()
                {
                    ProductCode = "1001",
                    ProductName = "Product 1001",
                    ProductPrice = 100,
                },
                new Product()
                {
                    ProductCode = "1002",
                    ProductName = "Product 1002",
                    ProductPrice = 200,
                },
                new Product()
                {
                    ProductCode = "1003",
                    ProductName = "Product 1003",
                    ProductPrice = 300,
                }

            };

            var result = productList.Exists(a => a.ProductCode == "1001");
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }


    class Product
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }


}
