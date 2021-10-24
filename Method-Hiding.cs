using System;

namespace Method-Hiding
{
    
    public class Employee
    {
        public string FirstName;
        public string LastName;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Contractor");
        }
    }

    public class FullTimeEmployee : Employee
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Marcus";
            FTE.LastName = "Canty";
            FTE.PrintFullName();

            Employee PTE = new PartTimeEmployee();
            PTE.FirstName = "Marcus";
            PTE.LastName = "Canty";
            PTE.PrintFullName();
        }
    }
}
