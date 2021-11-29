using System;

namespace Lesson68_MethodParametersOptionalMethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(10, 20, new int[] { 30, 40 });
        }

        public static void AddNumbers(int firstNumber, int secondNumber)
        {
            AddNumbers(firstNumber, secondNumber, null);
        }
        public static void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumber)
        {
            int result = firstNumber + secondNumber;
            if(restOfNumber != null)
            {
                foreach (int i in restOfNumber)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum = {0}", result);
        }
    }
}
