using System;

namespace Inheritance
{
    
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine("Full name: {0} {1}", FirstName, LastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float HourlyRate;
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Marcus";
            FTE.LastName = "Canty";
            FTE.YearlySalary = 500000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Joe";
            PTE.LastName = "Nathan";
            PTE.HourlyRate = 250;
            PTE.PrintFullName();
        }
    }
}
