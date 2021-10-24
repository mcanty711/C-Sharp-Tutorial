using System;

namespace Lesson24
{
    public class BaseClass
    {
        public  virtual void Print()
        {
            Console.WriteLine("I am a Base Class Print method");
        }
    }

    public class DerivedClass : BaseClass
    {
        public  new void Print()
        {
            Console.WriteLine("I am a Derived Class Printmethod");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass B = new DerivedClass();
            B.Print();

            DerivedClass D = new DerivedClass();
            D.Print();
        }
    }
}
