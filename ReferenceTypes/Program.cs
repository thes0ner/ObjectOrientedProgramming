using System;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Person person = new Person();
            person.Name = "Jason";
            
            Person person1 = new Person();
            person = person1;
            person1.Name = "Rock";

            Console.WriteLine(person.Name);


            Customer customer = new Customer();
            customer.Name = "Silvester";
            Employee employee = new Employee();

            Person person2 = new Person();
            person2 = customer;

            ((Customer)person2).CreditCardNumber = "234567453";
            Console.WriteLine(((Customer)person2).CreditCardNumber);



            PersonManager manager = new PersonManager();
            manager.Add(person);
            manager.Add(person1);
            manager.Add(person2);
            manager.Add(customer);



        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }

    }

    class Employee : Person
    {
        public double Salary { get; set; }
    }


    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine("Added.");
        }
    }



}
