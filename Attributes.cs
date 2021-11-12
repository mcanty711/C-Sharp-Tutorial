using System;
using System.Collections.Generic;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(10, 20);
        }
    }

    public class Calculator
    {
        [Obsolete("Use Add(List<int> Numbers) Method")]
        public static int Add(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }

        public static int Add(List<int> Numbers)
        {
            int Sum = 0;
            foreach(int Number in Numbers)
            {
                Sum = Sum + Number;
            }
            return Sum;
        }
    }
}
