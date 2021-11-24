using System;

namespace WhyOverrideToStringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 10;
            Console.WriteLine(Number.ToString());

            Customer C1 = new Customer();
            C1.FirstName = "Marcus";
            C1.LastName = "Canty";

            Console.WriteLine(C1.ToString());
        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.FirstName + ", " + this.LastName;
        }
    }
}
