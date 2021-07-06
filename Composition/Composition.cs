using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Composition
{
    // Inheritance is not the only way to reuse code
    // Another method is with composition
    // Composition is a kind of relationship that allows one class to contain another 
    // Compared to inheritance, composition is more flexible
    public class Logger
    {
        public void Log (string message)
        {
            Console.WriteLine(message);
        }
    }

    public class DbMigrator
    {
        // Unlike inheritance, there is no special syntax for composition
        // We simply create a private field for the class
        private readonly Logger _logger;

        // Then in a constructor, we insert the class we want to be contained and initialise the field
        // This means that every time we create an instance of the DbMigrator class, we also create an instance of the Logger class
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        // While we can't use the methods within the Logger class with an instance of the DbMigrator class, we access them through methods of the DbMigrator class
        public void Migrate()
        {
            _logger.Log("Migration start");
        }
    }
    class Composition
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());
            dbMigrator.Migrate();
        }
    }
}
