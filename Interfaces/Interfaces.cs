using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Interfaces
{
    // Interfaces are similar to classes in syntax but are functionally different
    // To declare an interface we use the interface keyword instead of class
    public interface ILogger
    {
        // An interface does not have any implementation, it's members do not have any code attached
        // Interfaces are used when we want a loosly coupled application
        // This means that in the application, when we want to change something we can do so by simply creating a new class and implementing that instead of the older classes
        // This is possible because interfaces are used to give certain classes the same type of methods but allowing for different implementation between classes
        // This design thinking is called extensibility
        void LogError(string message);
        void LogInfo(string message);
    }
    public class DbMigrator
    {
        // To use an interface with a class, we must create it as a field 
        private readonly ILogger _logger;

        // Then, in a constructor of the class we have to set it as a parameter
        // This means that the class will be dependent on that interface
        // This is called dependency injection
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            // What's going on here is that, when we have a concrete class that has the interface implemented, that class will have code attached to the methods in the interface
            // Then we pass an instance of that class in as a parameter which will have it's own unique implementation of a method in the interface
            // If we use the method here( Migrate() in this case), the unique code of that class for the method of the interface called will be run
            // This means that any class with the interface implemented can be used as a parameter
            _logger.LogInfo("Logged in");
        }
    }

    // When we are creating a class that implements the interface, we do so as though it were being inherited
    // Any class that implements the interface must implement the methods within the interface
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class FileLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine(message + " inside file");
        }

        public void LogInfo(string message)
        {
            Console.WriteLine(message + " inside file");
        }
    }
    class Interfaces
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();
        }
    }
}
