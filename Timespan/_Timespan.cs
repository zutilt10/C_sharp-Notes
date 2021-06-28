using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._Timespan
{
    class _Timespan
    {
        static void Main(string[] args)
        {
            // TimeSpan is how we work with specific lengths of time
            var timespan = new TimeSpan(1, 2, 3);

            // We can specify a specific amount of time if we just want some hours, minutes and seconds
            var timespan2 = TimeSpan.FromHours(1);

            // The individual seconds, minutes and hours of a timespan instance can be accessed
            Console.WriteLine(timespan.Minutes);

            // Individual seconds, minutes and hours can also be added or subtracted
            Console.WriteLine(timespan.Add(TimeSpan.FromMinutes(2)));
            Console.WriteLine(timespan.Subtract(TimeSpan.FromMinutes(2)));

            // In order to print out the timespan, we have to use a ToString() method 
            Console.WriteLine(timespan.ToString());
        }
    }
}