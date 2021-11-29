using System;

namespace Lesson67_OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(10, 20, 30, 40, 50);
        }

        public static void AddNumbers(int firstNumber, int secondNumber, params object[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if(restOfNumbers != null)
            {
                foreach(int i in restOfNumbers)
                {
                    result += i;
                } 
            }

            Console.WriteLine("Sum = {0}", result);
        }
    }
}
