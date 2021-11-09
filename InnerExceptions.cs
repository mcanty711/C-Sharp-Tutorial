using System;
using System.IO;

namespace Lesson41_InnerException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter First Number: ");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second Number: ");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int quotient = FN / SN;

                    Console.Write("Quotient = {0}", quotient);
                }
                catch (Exception ex)
                {
                    string filePath = @"C:\Users\mcanty\Documents\Marcus Canty\C#Examples\Lesson41_InnerException\Log.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.Write(ex.GetType().Name);
                        sw.WriteLine();
                        sw.Write(ex.Message);
                        sw.Close();
                        Console.WriteLine("There is a problem, please try again.");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not present", ex);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Current Exception = {0}", exception.GetType().Name);
                if (exception.InnerException != null)
                {
                    Console.WriteLine("Inner Excpetion = {0}", exception.InnerException.GetType().Name);
                }                
            }
        }
    }
}
