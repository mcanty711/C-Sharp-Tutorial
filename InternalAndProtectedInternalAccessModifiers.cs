using System;

namespace AssemblyOne
{
    public class AssemblyOneClassI
    {
        internal int ID = 101;
    }

    public class AssemblyOneClassII
    {
        public void SampleMethod()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            Console.WriteLine(A1.ID);
        }
    }
}

using System;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClassI
    {
        public void Print()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            A1.ID
        }
    }
}
