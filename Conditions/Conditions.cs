using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Conditions
{
    class Conditions
    {
        static void Main(string[] args)
        {
            // The syntax for conditions in C# is: if(<condition>)
            //                                     {
            //                                      <Code that will be excuted if condition is met>;
            //                                     }
            //                                     else
            //                                     { 
            //                                      <Code that will be excuted if condition is not met>;
            //                                     }
            // There are many symbols that can be used to make codtions
            // They are: ==(equal to), !=(not equal to), >(greater than), <(less than), &&(adds another condtion that needs to also be met), ||(only one of the conditions needs to be met in order for the code to be excuted)

            int age;
            int height;

            Console.WriteLine("Please enter age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter height(cm): ");
            height = Convert.ToInt32(Console.ReadLine());

            if (age >= 18 && height >= 160)
            {
                Console.WriteLine("Go in");
            }
            else
            {
                Console.WriteLine("You may not enter");
            }

            // Whenever we are dealing with a single variable that can have many different values, we can instead use a switch statement
            Console.WriteLine("Please enter in a number from 1 to 3");

            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                // The cases dictate what code gets excuted based on what the value of the variable is
                // This makes it cleaer what conditions are needed 
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                // The code under "default" is excuted when none of the expected values are entered in
                default:
                    Console.WriteLine("That is not between 1 and 3");
                    break;
            }


            Console.ReadKey();
        }
    }
}
