using System;

namespace Lesson63_PartialMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SamplePartialClass SPC = new SamplePartialClass();
            SPC.PublicMethod();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson63_PartialMethods
{
    public partial class SamplePartialClass
    {
        partial void SamplePartialMethod();
        partial void SamplePartialMethod()
        {
            Console.WriteLine("SamplePartialMethod Invoked");
        }

        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod Invoked");
            SamplePartialMethod();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson63_PartialMethods
{
    public partial class SamplePartialClass
    {
        
    }
}
