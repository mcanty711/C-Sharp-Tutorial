using System;
using System.Collections.Generic;

namespace AnonymousMethods
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
            Employee employee = listEmployees.Find(
                
                delegate (Employee emp)
                {
                    return emp.ID == 102;
                }
                );

            Console.WriteLine("Id = {0}, Name = {1},", employee.ID, employee.Name);
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson98_AnonymousMethods2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button Button1 = new Button();
            Button1.Text = "Click Me";
            Button1.Click += delegate
            {
                MessageBox.Show("Hello, you just click me");
            };
            this.Controls.Add(Button1);
        }
    }
}
