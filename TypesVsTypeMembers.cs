using System;

namespace Lesson48_TypesVsTypeMembers
{
    public class Customer
    {
        #region fields
        private int _id;
        private string _firstName;
        private string _lastName;
        #endregion

        #region Properties
        public int Id 
        {
            get { return _id; }
            set { _id = value; } 
        }
        public string FirstName 
        { 
            get {return _firstName; }
            set { _firstName = value; } 
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        #endregion

        public string GetFullName()
        {
            return this._firstName + " " + this._lastName;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
