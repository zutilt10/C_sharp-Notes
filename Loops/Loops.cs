using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Loops
{
    class Loops
    {
        static void Main(string[] args)
        {
            // There are two main types of loops
            // For loops and while loops 
            // For loops are used when we want to repeat code a certain number of times
            // The syntax for the for loop is:
            // for (<variable type> <variable name> = <vlaue of variable before the loop begins>; <condition to be met for the loop to keep running>; <what happens to the variable after each loop>;)
            // {
            //      <Code that is excuted every loop>; 
            // }
            Console.WriteLine("How mant cool numbers do you want: ");

            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }

            Console.WriteLine("----------");

            // While loops aare used when we want to repeat code for as long as a certain condition is met. 
            // We often do not know beforehand how many times it will repeat
            // The syntax for the while loop is:
            // while (<condition to be met>)
            // {
            //      <code to be repeated every loop>
            // }

            Random numberGen = new Random();

            int roll = 0;
            int attempts = 0;

            Console.WriteLine("Press enter to roll the die.");

            while (roll != 6)
            {
                Console.ReadKey();
                roll = numberGen.Next(1, 7);
                Console.WriteLine("You rolled: " + roll);
                attempts++;
            }

            Console.WriteLine("It took you " + attempts + " attempt(s) to roll a six");

            Console.ReadKey();
        }
    }
}