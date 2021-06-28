using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Strings
{
    class Strings
    {
        static void Main(string[] args)
        {
            string fullName = "Jonathan Woo ";

            // The .Trim method for strings gets rid of any blank space within the string
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            // The .ToUpper method turns all characters within the string into uppercase letters
            Console.WriteLine("UPPERCASE: '{0}'", fullName.Trim().ToUpper());

            // Strings are immutable so it isn't possible to simply seperate individual characters or edit the string
            // However, there are some ways to get around this with methods
            var index = fullName.IndexOf(' ');
            // The .Substring method returns the characters in between two indexes
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + lastName);

            // The .Split method seperates strings by the index where a given character(input in parathesis) is
            // It returns an array containing substrings that were created because of the split 
            var names = fullName.Split(' ');
            Console.WriteLine("First name: " + names[0]);
            Console.WriteLine("Last name: " + names[1]);

            // .Replace replaces certain characters within a string with another set of characters
            Console.WriteLine(fullName.Replace("Jonathan", "J"));

            // Another useful method is .IsNullOrWhiteSpace what checks if a certain string is empty
            // Particularly useful for inputs by users
            if (!String.IsNullOrWhiteSpace(fullName))
            {
                Console.WriteLine("Valid");
            }

            // To convert a string into an integer we can use the Convert.ToInt32() method
            // We can also convert to other types like bytes
            var str = "25";
            var age = Convert.ToInt32(str);
            Console.WriteLine(age);

            // We can also do the opposite with .ToString
            // Additionally, we can format the string to display the number certain ways
            // We can find the full documentation online
            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
        }
    }
}