using System;

namespace Lesson24
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a Base Class Print method");
        }
    }

    public class DerivedClass : BaseClass
    {
        public new void Print()
        {
            Console.WriteLine("I am a Derived Class Printmethod");
        }
    }
    public class DerivedClass2 : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("I am a Derived Class2 Printmethod");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass B = new BaseClass();
            B.Print();

            BaseClass B2 = new DerivedClass(); //Method Hiding
            B2.Print();

            BaseClass B3 = new DerivedClass2(); //Method Overriding 
            B3.Print();
        }
    }
}
