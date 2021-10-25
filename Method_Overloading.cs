using System;

namespace Lesson25
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(3.15F, 4.35F, 5.67F);
        }

        public static void Add(int FN, int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }
        
        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN + TN);
        }

        public static void Add(float FN, float SN, float TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN + TN);
            
        }

    }
}
