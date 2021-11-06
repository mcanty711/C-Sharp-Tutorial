using System;

namespace Delegates
{
    public delegate void HelloFunctionDelegate(string Message);
    
    class Program
    {
        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from Delegate");
            //delegate is a type-safe function pointer
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}
