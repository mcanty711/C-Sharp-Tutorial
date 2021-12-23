using System;

namespace PerformanceMultithreadedProgram
{
    class Program
    {
        public static void EvenNumbersSum()
        {
            double sum = 0;
            for (int i = 0; i <= 50000000; i++)
            {
                if(i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of even numbers = {0}", sum);
        }
        public static void OddNumbersSum()
        {
            double sum = 0;
            for(int i = 0; i <= 50000000; i++)
            {
                if(i % 2 == 1)
                {
                    sum = sum + 1;
                }
            }
            Console.WriteLine("Sum of odd numbers = {0}", sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Processor Count = " + Environment.ProcessorCount);
        }
    }
}
