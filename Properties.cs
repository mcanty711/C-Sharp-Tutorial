using System;

namespace Lesson27
{
    public class Student
    {
        private int _id;
        private string _Name;
        private int _passMark = 35;

        public string City { get; set; }
        public string Email { get; set; }
        
        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }
        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student Id cannot be negative");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Student name cannot be null or empty");
                }
                this._Name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student C1 = new Student();
            C1.Id = 101;
            C1.Name = "Mark";
            C1.City = "Detroit";
            C1.Email = "marcusjcanty@gmail.com";

            Console.WriteLine("Student Id = {0}", C1.Id);
            Console.WriteLine("Student Name = {0}", C1.Name);
            Console.WriteLine("Student PassMark = {0}", C1.PassMark);
            Console.WriteLine(C1.City);
            Console.WriteLine(C1.Email);
        } 
    }
}
