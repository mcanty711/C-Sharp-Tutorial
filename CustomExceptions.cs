using System;
using System.IO;
using System.Runtime.Serialization;

namespace Lesson42_CustomExceptions
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedinException("User is already logged in - no duplicate session allowed");
            }
            catch (UserAlreadyLoggedinException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    [Serializable]
    public class UserAlreadyLoggedinException : Exception
    {
        public UserAlreadyLoggedinException() : 
            base()
        {

        }
        public UserAlreadyLoggedinException(string message) : 
            base(message)
        {

        }
        public UserAlreadyLoggedinException(string message, Exception innerException) : 
            base(message, innerException)
        {

        }
        public UserAlreadyLoggedinException(SerializationInfo info, StreamingContext context) : 
            base (info, context)
        {

        }
    }
}
