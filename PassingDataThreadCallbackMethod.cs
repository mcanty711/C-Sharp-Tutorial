using System;
using System.Threading;

namespace PassingDataThreadCallbackMethod
{
    public delegate void SumOfNumbersCallback(int SumOfNumbers);
    class Program
    {
        public static void PrintSum(int sum)
        {
            Console.WriteLine("Sum of number = " + sum);
        }
        public static void Main()
        {
            Console.WriteLine("Please enter the target number");
            int target = Convert.ToInt32(Console.ReadLine());

            SumOfNumbersCallback callback = new SumOfNumbersCallback(PrintSum);

            Number number = new Number(target, callback);
            Thread T1 = new Thread(new ThreadStart(number.PrintSumOfNumbers));
            T1.Start();
        }
    }
    class Number
    {
        int _target;
        SumOfNumbersCallback _callBackMethod;

        public Number(int target, SumOfNumbersCallback callBackMethod)
        {
            this._target = target;
            this._callBackMethod = callBackMethod;
        }
        public void PrintSumOfNumbers()
        {
            int sum = 0;
            for (int i = 0; i < _target; i++)
            {
                sum = sum + i;
            }

            if (_callBackMethod != null)
                _callBackMethod(sum);
        }
    }
}
