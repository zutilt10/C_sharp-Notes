using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exceptions
{
    class Exceptions
    {
        static void Main(string[] args)
        {
            // When writing programs, certain things can go wrong and when that happens, an exception will get thrown and the program crashes
            // Most of the times , however, we want the program to keep running when an exception is thrown
            // To do this we need to use a try and catch block or exception handling
            // Any code that we think will throw out an error we place inside the try block 
            // If an error is thrown out, instead of just crashing, the code in the catch block will be excuted instead
            try
            {
                Console.WriteLine("Enter a number: ");
                int num01 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                int num02 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num01 / num02);
            }
            // If we want to, we can get more information about the exception
            // By writing Exception, we are putting in a parameter that we can use to get information about the exception that gets thrown
            // We do not have to do this and can simply leave the brackets blank
            catch (Exception e)
            {
                // Using .Message, the program will tell us exactly what the error was without closing down the program
                Console.WriteLine(e.Message);
            }
            // If we want to get more specific about what kind of error we want to catch we can
            // We simply have to write the error name in the brackets
            // This will allow us to specify what message is written out when a specific error is thrown
            // For example, the code in the try block will throw an error if a 0 is entered in
            // This will thorw out a DivideByZeroException exception
            // So, to catch it, we write out:
            // catch(DivideByZeroException e)
            // {
            //     Console.WriteLine(e.Message);
            // }
            // Note that we can't do this if we already have an Exception catch block

            // Code in the finally block will be excuted no matter what
            // The block of code is purely optional 
            finally
            {
                Console.WriteLine("Please try again");
            }

            // Generally, these try and catch blocks make our programs more durable and prevents frequent crashing

            Console.ReadKey();
        }
    }
}