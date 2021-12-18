using System;
using System.Threading;

namespace PassingDataToThreadFunctionTypeSafely
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your target number: ");
            int target = Convert.ToInt32(Console.ReadLine());

            Number number = new Number(target);
            Thread T1 = new Thread(number.PrintNumbers);
            T1.Start();
        }
    }

    class Number
    {
        private int _target;
        public Number(int target)
        {
            this._target = target;
        }
        public void PrintNumbers()
        {
            for (int i = 1; i <= _target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
