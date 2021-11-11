using System;

namespace Lesson49_AccessModifiers
{
    public class Customer
    {
        protected int ID;
    }

    public class CorporateCustomer : Customer
    {
        public void PrintID()
        {
            CorporateCustomer CC = new CorporateCustomer();
            CC.ID = 101;
        }
    }

    public class Program  
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            Console.WriteLine(C1.ID);
        }
    }
}
