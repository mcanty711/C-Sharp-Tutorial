using System;

namespace AssemblyOne
{
    public class AssemblyOneClass
    {
        public void Print()
        {
            Console.WriteLine("Hello");
        }
    }
}

using System;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClass
    {
        public void Test()
        {
            AssemblyOneClass instance = new AssemblyOneClass();
            instance.Print();
        }
    }
}
