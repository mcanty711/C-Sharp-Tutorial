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
    //This code proves that you can 
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClass Constructor called");
        }
        public ParentClass(string Message)
        {
            Console.WriteLine(Message);
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass() : base("Derived class controlling Parent class")
        {
            Console.WriteLine("ChildClass Constructor called");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            ChildClass CC = new ChildClass();
        }
    }
}
