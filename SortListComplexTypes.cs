using System;
using System.Collections.Generic;

namespace SortListComplexTypes
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
                ID = 102,
                Name = "Pam",
                Salary = 7000,
            };

            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 5500,
            };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            Console.WriteLine("Before Sorting");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Salary);
            }
            listCustomers.Sort();
            Console.WriteLine("After Sorting");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Salary);
            }
            listCustomers.Reverse();
            Console.WriteLine("Descending Order");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Salary);
            }
            SortByName sortByName = new SortByName();
            listCustomers.Sort(sortByName);
            Console.WriteLine("Sorting by Name");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Name);
            }
        }
    }

    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    public class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Customer other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
    }
}
