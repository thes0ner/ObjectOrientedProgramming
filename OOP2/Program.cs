using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.FirstName = "Soner";
            customer1.LastName = "Abduramanov";
            customer1.TcNo = "2222222222222";
            customer1.CustomerNo = "45673";


            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 1;
            customer2.CustomerNo = "1234567890";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";



            //This means Customer can point these Objects while Inherited....
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
