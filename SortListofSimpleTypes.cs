using System;
using System.Collections.Generic;
//using System.Linq;

namespace SortListofSimpleTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

            Console.WriteLine("Numbers before sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();
            Console.WriteLine("Numbers after sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Reverse();
            Console.WriteLine("Numbers in descending order");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };
            Console.WriteLine("Alphabets before sorting");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }
            alphabets.Sort();
            Console.WriteLine("Alphabets after sorting");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000,
                Type = "RetailCustomer"
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000,
                Type = "RetailCustomer"
            };

            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 5500,
                Type = "RetailCustomer"
            };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            //this will give an exeception error
            listCustomers.Sort(); 
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
    }
}
