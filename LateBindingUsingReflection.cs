using System;
using System.Reflection;

namespace LateBindingUsingReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Type customerType = executingAssembly.GetType("Lesson55_LateBindingUsingReflection.Customer");

            object customerInstance = Activator.CreateInstance(customerType);

            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = "Marcus";
            parameters[1] = "Canty";

            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);
            Console.WriteLine("Full Name = {0}", fullName);

            //Customer C1 = new Customer();
            //string fullName = C1.GetFullName("Marcus", "Canty");
            //Console.WriteLine("Full Name = {0}", fullName);
        }
    }
    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}
