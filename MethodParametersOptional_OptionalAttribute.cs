using System;
using System.Runtime.InteropServices;

namespace Lesson70_MethodParametersOptional_OptionalAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(10, 20, new int[] { 30, 40, 50 });
        }

        public static void AddNumbers(int firstNumber, int secondNumber, [Optional] int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if(restOfNumbers != null)
            {
                foreach(int i in restOfNumbers)
                {
                    result += i;
                }
            }

            Console.WriteLine("Total = {0}", result.ToString());
        }
    }
}
