using System;

namespace MulticastDelegates
{
    public delegate void SampleDelegate(out int Integer);
    
    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;
            
            int DelegateOutputParameterValue = -1;

            del(out DelegateOutputParameterValue);
            Console.WriteLine("DelegateOutputParameterValue {0}", DelegateOutputParameterValue);
        }
        public static void SampleMethodOne(out int Number)
        {
            Number = 1;
        }
        public static void SampleMethodTwo(out int Number)
        {
            Number = 2;
        }
    }
}
