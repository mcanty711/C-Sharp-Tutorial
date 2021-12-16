using System;
using System.Threading;

namespace ThreadStartDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            Thread T1 = new Thread(new ThreadStart(number.PrintNumber));
            T1.Start();
        }
    }

    class Number
    {
        public void PrintNumber()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
