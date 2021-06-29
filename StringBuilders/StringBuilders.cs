using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.StringBuilders
{
    class StringBuilders
    {
        static void Main(string[] args)
        {
            // While strings are immutable, there is a way to create a string that can be edited
            // That is with the StringBuilder class
            var builder = new StringBuilder();

            // .Append adds certain characters a certain amount of time to a string
            builder.Append('a', 10);
            builder.AppendLine();
            builder.Append("Hi");

            Console.WriteLine(builder);

            // .Replace replaces a certain character with another in a string
            builder.Replace('a', 'b');

            Console.WriteLine(builder);

            // .Remove gets rid of a certain number of characters from an index
            builder.Remove(0, 10);

            Console.WriteLine(builder);

            // .Insert adds characters at a certain index of a string
            builder.Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            // One disadvantage to this class is that we can't search for the index of certain characters
            // Though we can look at the characters in certain indexes

            Console.WriteLine(builder[0]);
        }
    }
}