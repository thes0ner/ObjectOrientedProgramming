using System;
using System.Collections.Generic;
using DenemeDemo;

namespace DenemeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //List<Customer> lists = new List<Customer>();
            //lists.Add(new Customer()
            //{
            //    Id = 1,
            //    FirstName = "Soner",
            //    LastName = "Abduramanov",
            //    City = "Skopje"
            //});
            //lists.Add(new Customer()
            //{
            //    Id = 2,
            //    FirstName = "Laura",
            //    LastName = "Iseni",
            //    City = "Albania"
            //});
            //foreach (var list in lists)
            //{
            //    Console.WriteLine(list.Id + " " + list.FirstName + " " + list.LastName + " " + list.City);
            //}


            Dictionary<Customer, Customer> dictionary = new Dictionary<Customer, Customer>();
            dictionary.Add(new Customer() {Id = 1,} , new Customer() { FirstName = "Soner",LastName = "Abduramanov"});
            dictionary.Add(new Customer() { Id = 2, }, new Customer() { FirstName = "Mehmet",LastName = "Dincer"});
            dictionary.Add(new Customer() { Id = 3, }, new Customer() { FirstName = "Murat", LastName = "Boz" });

            
            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine(dictionary.Keys);
                
            }

        }
    }



    class Customer 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }


}
