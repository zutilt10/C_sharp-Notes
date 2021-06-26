using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Methods
{
    class Methods
    {
        // When we want to use methods/functions, we must define them and then call them
        // Methods/Functions are like machines we create that automatically excutes a collection of code that we define when we call it
        // The line of code directly below this line is an example of a method/function, called the Main method/function
        static void Main(string[] args)
        {
            GenerateMoney();

            Console.WriteLine("-----------------------------");

            Multiply(3, 9);

            Console.WriteLine("-----------------------------");

            int Result = Add(3, 12);
            Console.WriteLine("The result is " + Result);

            Console.ReadKey();
        }
        // When we create a new method/function we must do it outside of the Main method/function.
        // It does not matter if the new method is before or after Main.
        // Once it has been created, we must call it in Main in order for it to be excuted
        // The syntax for creating a methos/function is: static void <name of method>()
        //                                               {
        //                                                  <code to be excuted>
        //                                               }
        static void GenerateMoney()
        {
            Random numberGen = new Random();

            string money = "$" + numberGen.Next(1, 100);
            int savings = numberGen.Next(100, 2000);

            Console.WriteLine("Your have " + savings + " saved");
            Console.WriteLine("You are depositing " + money);
            Console.WriteLine("Thank you! Have a nice day.");
        }

        // We can also create methods/functions that takes in inputs and outputs the result
        // We do this by adding parameters and return values
        // To allow for the addition of an input, we simply write the type and name of the variable that will serve as the parameter in the brackets of the method/function
        // There can be more than one variable if more than one type
        // We add the parameters in the Main method when we call the method/function and place them in the brackets

        static void Multiply(int num01, int num02)
        {
            int result = num01 * num02;
            Console.WriteLine("The result is: " + result);
        }

        // In order for the output created by a method/function to be stored in another variable, we must add a return value
        // We do this by replacing the usual "void" in front of the method's name, which will make the function return nothing, we write the type of data we want to return  
        static int Add(int num01, int num02)
        {
            int result = num01 + num02;
            // Finally, we type out which result we wish to return which can now be stored in another variable
            return result;
        }
    }
}