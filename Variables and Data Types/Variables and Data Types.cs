using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Variables_and_Data_Types
{
    class Variables_and_Data_Types
    {
        static void Main(string[] args)
        {
            // There are 4 fundamental data types: Int(Whole numbers), Float(Decimal numbers), String(Text), Bool(True or False)
            // Double is part of Float. It allows the program to store a larger number of decimal points
            // To make a variable, the syntax is: <Data type> <Variable name> = <Value>
            // Eg. int myAge = 22;
            // Sometimes a "var" can be written in place of the data type. This usually occurs if we do not know the variable type beforehand
            // It is good practice to write the exact data type as this will make the code easier to read
            Console.WriteLine("Who are you?");

            string userName = Console.ReadLine();

            Console.WriteLine("Greetings, " + userName);

            string phrase = "I am a house";

            int age = 30;

            Console.WriteLine(age);

            // When we use a float, we need to add a "f" at the end of the decimal number
            float cash = 22.3f;

            Console.WriteLine(cash);

            // If we use a double instead, we do not need to do so
            double cash02 = 24.44;

            Console.WriteLine(cash02);

            // Strings have their own set of parameters and methods that can be used with the strings
            // .Length measures the number of characters in the string
            Console.WriteLine(phrase.Length);
            // .ToUpper() turns all characters in the string into uppercase letters while .ToLower() does the opposite
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());

            // .Contains return either True or False based on whether a string variable contains a certain length of text  
            Console.WriteLine(phrase.Contains("I"));

            // .IndexOf returns the index postion , within the string, of the text that's within the method 
            // If the text is not within the string, a -1 will be returned instead
            Console.WriteLine(phrase.IndexOf("house"));

            // Char, as a data type, is used when we want just one single character
            // We also use a '' instead of a "" like in a string
            char alphabet = 'A';

            Console.ReadKey();
        }
    }
}