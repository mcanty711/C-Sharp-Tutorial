using System;

namespace PreventingExceptionHandlingAbuse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter Numerator");
                int Numerator;
                bool IsNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Numerator);

                Console.WriteLine("Please enter Denominator");
                int Denominator; 
                bool IsDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Denominator);

                if(IsDenominatorConversionSuccessful && Denominator != 0)
                {
                int Result = Numerator / Denominator;
                Console.WriteLine("Result = {0}", Result);
                }
                else
                {
                    if(Denominator == 0)
                    {
                        Console.WriteLine("Denominator cannot be zero");
                    }
               else
            {
                Console.WriteLine("Numerator should be a valid number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
            }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
