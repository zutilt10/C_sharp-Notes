using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Construction_Robot bot = new Construction_Robot("100-324");
            // Now, an instance of the subclass will be able to use all the methods in the superclass
            bot.Activate();

            bot.BuildWall();

            Console.ReadKey();
        }
    }
}