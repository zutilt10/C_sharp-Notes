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
    // Note: It may seems that composition is inherently better than inheritance but composition is a little harder to understand than classes
    // One way to think of the relationship between classes for inheritance is; Class A is a Class B
    // While for composition it's more like: Class A has a Class B
    // For example, a Human and a Dog will be an Animal but it would be confusing to say that a Human and a Dog has an Animal
    // To best re-use code and ensure that none of the classes get broken as a result of a change to another one, we should use both at the same time
    // One way to use composition would be to contain singular methods that may conflict with other classes that should not have them if they had inherited from a supclass
    // For example, if we have an Animal class, we can't place a Walk method within in for inheritance if we want a Fish class to inherit as a fish cannot walk
}
