using System;
using System.Collections.Generic;

namespace GenericStackCollectionClass
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
            Stack<Customer> stackCustomer = new Stack<Customer>();
            stackCustomer.Push(customer1);
            stackCustomer.Push(customer2);
            stackCustomer.Push(customer3);
            stackCustomer.Push(customer4);
            stackCustomer.Push(customer5);

            Customer c1 = stackCustomer.Pop();
            Console.WriteLine(c1.ID + " " + c1.Name);
            Console.WriteLine("Items left in the stack = " + stackCustomer.Count);

            Customer c2 = stackCustomer.Peek();
            Console.WriteLine(c2.ID + " " + c2.Name);

            Console.WriteLine("Contains customer4? " + stackCustomer.Contains(customer4));
            Console.WriteLine("Contains customer5? " + stackCustomer.Contains(customer5));
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
