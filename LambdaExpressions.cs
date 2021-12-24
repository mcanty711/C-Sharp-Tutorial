using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
            new Employee { ID = 101, Name = "Mark" },
            new Employee { ID = 102, Name = "John" },
            new Employee { ID = 103, Name = "Mary" },
            };

            //step 2 create an instance of a delegate which points to function FindEmployee.
            //Predicate<Employee> employeePredicate = new Predicate<Employee>(FindEmployee);

            //step 3 pass the delegate instance as a parameter to this Find method.
            Employee employee = listEmployees.Find(Emp => Emp.ID == 102);
            Console.WriteLine("Id = {0}, Name = {1},", employee.ID, employee.Name);

            int count = listEmployees.Count(x => x.Name.StartsWith("M"));
            Console.WriteLine("Count = " + count);
        }

        //step 1 create this function.
        //public static bool FindEmployee(Employee Emp)
        //{
        //    return Emp.ID == 102;
        //}
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}
