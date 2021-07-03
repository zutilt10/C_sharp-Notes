using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Properties
{
    public class Person
    {
        // Within classes, there are also things called properties
        // They function like attributes but may not be accessible by an instance of the class
        // Instead, we may have to use a method to do so
        // One advantage that we have with properties over simple attributes is that we can add logic to how the properties are derived

        // Below is a quick way to set a property
        // The Name property can be accessed by instances of the class easily
        // This means that we can change the property in the Main method with an instance of the class(Setting the property)
        // We can also access it's current value with an instance(Getting the property) 
        public string Name { get; set; }
        // If we want to we can set the property to be "un-setable" by any instance of the class
        // Simply add private to the set
        public DateTime Birthdate { get; private set; }

        // When we make a property private like that, we have to find another way to set it
        // Like with a constructor
        public Person(DateTime birthDate)
        {
            Birthdate = birthDate;
        }


        // This is an example of a property with logic integrated
        // It will automatically calculate it's own value without needing input from the user or programmer
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }

    class Properties
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(2012, 1, 1));
            person.Name = "John";

        }
    }
}
