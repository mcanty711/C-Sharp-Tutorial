using System;
using System.Collections.Generic;

namespace SortListComplexTypesComparisonDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000,
            };

            Customer customer2 = new Customer()
            {
                ID = 103,
                Name = "Pam",
                Salary = 7000,
            };

            Customer customer3 = new Customer()
            {
                ID = 102,
                Name = "John",
                Salary = 5500,
            };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            //Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer);

            Console.WriteLine("Before Sorting");
            foreach(Customer c in listCustomers)
            {
                Console.WriteLine(c.ID);
            }

            //listCustomers.Sort(customerComparer);
            //listCustomers.Sort(delegate(Customer c1, Customer c2) { return c1.ID.CompareTo(c2.ID });
            listCustomers.Sort((c1, c2) => c1.ID.CompareTo(c2.ID));

            Console.WriteLine("After Sorting");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.ID);
            }
        }

        //private static int CompareCustomer(Customer x, Customer y)
        //{
        //    return x.ID.CompareTo(y.ID);
        //}
    }
    public class Customer 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
