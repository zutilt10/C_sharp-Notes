using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._DateTime
{
    class _DateTime
    {
        static void Main(string[] args)
        {
            // The DateTime class allows us to work with the date and time
            var dateTime = new DateTime(2015, 1, 1);

            // With the .Now method we get the date and time returned
            var now = DateTime.Now;
            // With the .Today, we only get the date
            var today = DateTime.Today;

            Console.WriteLine(now);
            Console.WriteLine(today);

            // The .AddDays method allows us to edit the dates by the day  
            var tommorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(tommorrow);
            Console.WriteLine(yesterday);

            // The following methods return only either the date or time in different formats
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());
            // With .ToString we can print both the date and time
            // By inseting certain things into the parathesis we can set a specific format for the date and time
            Console.WriteLine(now.ToString());
        }
    }
}