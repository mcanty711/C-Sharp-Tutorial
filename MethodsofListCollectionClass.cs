using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MethodsofListCollectionClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "John",
                Salary = 7000
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Ken",
                Salary = 5000
            };
            List<Customer> listCustomers = new List<Customer>(100);
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            bool paid = listCustomers.TrueForAll(x => x.Salary > 5000);
            Console.WriteLine("All salaries are greater than 5000 - " + paid);

            ReadOnlyCollection<Customer> readonlyCustomers = listCustomers.AsReadOnly();
            Console.WriteLine("Items in list: " + readonlyCustomers.Count);

            Console.WriteLine("Capacity before trimming = " + listCustomers.Capacity);
            listCustomers.TrimExcess();
            Console.WriteLine("Capacity after trimming = " + listCustomers.Capacity);
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
