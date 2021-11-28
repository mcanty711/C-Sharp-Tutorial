using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson65_Indexers
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    
    public class Company
    {
        private List<Employee> listEmployees;

        public Company()
        {
            listEmployees = new List<Employee>();
            listEmployees.Add(new Employee() { EmployeeId = 1, Name = "Mike", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 2, Name = "Pam", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 3, Name = "John", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 4, Name = "Maxine", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 5, Name = "Emily", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 6, Name = "Scott", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 7, Name = "Todd", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 8, Name = "Ben", Gender = "Male" });
        }

        public string this[int employeeId]
        {
            get
            {
                return listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson65_Indexers
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();

            Response.Write("Name of Employee With Id = 2:" + company[2]);
            Response.Write("<br/>");
            Response.Write("Name of Employee With Id = 5:" + company[5]);
            Response.Write("<br/>");
            Response.Write("Name of Employee With Id = 8:" + company[8]);
            Response.Write("<br/>");
            Response.Write("<br/>");

            Response.Write("Changing name of employees with Id = 2, 5 & 8");
            Response.Write("<br/>");
            Response.Write("<br/>");

            company[2] = "2nd Employee Name Changed";
            company[5] = "5th Employee Name Changed";
            company[8] = "8th Employee Name Changed";

            Response.Write("Name of Employee With Id = 2:" + company[2]);
            Response.Write("<br/>");
            Response.Write("Name of Employee With Id = 5:" + company[5]);
            Response.Write("<br/>");
            Response.Write("Name of Employee With Id = 8:" + company[8]);
        }
    }
}
