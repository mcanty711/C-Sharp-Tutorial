using System;
using System.Collections.Generic;

namespace GenericQueueCollectionClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Gender = "Male"
            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Gender = "Female"
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "John",
                Gender = "Male"
            };
            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "Ken",
                Gender = "Male"
            };
            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "Valarie",
                Gender = "Female"
            };
            Queue<Customer> queCustomers = new Queue<Customer>();
            queCustomers.Enqueue(customer1);
            queCustomers.Enqueue(customer2);
            queCustomers.Enqueue(customer3);
            queCustomers.Enqueue(customer4);
            queCustomers.Enqueue(customer5);

            Customer c = queCustomers.Peek();

            if (queCustomers.Contains(customer1))
            {
                Console.WriteLine("customer1 exists");
            }
            else
            {
                Console.WriteLine("customer1 does not exixt");
            }
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
