using System;
using System.Collections.Generic;
using System.Linq;

namespace ListCollection2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer customer2 = new Customer()
            {
                ID = 110,
                Name = "Pam",
                Salary = 7000
            };

            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 5500
            };


            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            Dictionary<int, Customer> dictionary = listCustomers.ToDictionary(x => x.ID);

            foreach (KeyValuePair<int, Customer> kvp in dictionary)
            {
                Console.WriteLine("Key = " + kvp.Key);
                Customer c = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
