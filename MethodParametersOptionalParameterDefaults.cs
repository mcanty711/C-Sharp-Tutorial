using System;

namespace MethodParametersOptionalParameterDefaults
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(10, 20, new int[] { 30, 40 });
        }

        public static void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers = null)
        {
            int result = firstNumber + secondNumber;
            if(restOfNumbers != null)
            {
                foreach(int i in restOfNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum = {0}", result.ToString());
        }
    }
}

using System;

namespace MethodParametersOptionalParameterDefaults
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(1, c : 2);
        }

        public static void Test(int a, int b = 10, int c = 20)
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
        }
    }
}
