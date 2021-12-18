using System;
using System.Threading;

namespace ParameterizedThreadStartDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your target number: ");
            object target = Console.ReadLine();

            Number number = new Number();
            Thread T1 = new Thread(number.PrintNumbers);
            T1.Start(target);

        }
    }

    class Number
    {
        public void PrintNumbers(object target)
        {
            int number = 0;
            if (int.TryParse(target.ToString(), out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                } 
            }

        }
    }
}
