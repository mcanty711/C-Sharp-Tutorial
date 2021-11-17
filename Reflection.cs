using System;
using System.Reflection;

namespace Reflection
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;
        }
        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        public void PrintID()
        {
            Console.WriteLine("ID = {0}", this.Id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //Type T = Type.GetType("Lesson53_Reflection.Customer");
            //Type T = typeof(Customer);
            Customer C1 = new Customer();
            Type T = C1.GetType();
            C1.GetType();
            Console.WriteLine("Full Name {0}", T.FullName);
            Console.WriteLine("Just the Name = {0}", T.Name);
            Console.WriteLine("Just the Namespace = {0}", T.Namespace);
            Console.WriteLine();
            Console.WriteLine("Properies in Customers:");
            PropertyInfo[] properties = T.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Methods in Customers class");
            MethodInfo[] methods = T.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Constructors in Customers class");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach(ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
