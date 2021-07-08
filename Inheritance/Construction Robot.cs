using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Inheritance
{
    // Sometimes we want classes to have the exact functions and attributes that another class has
    // When this happens, we can simply use inheritance
    // To do this, we simply use a : next to the name of the class and write down the name of the class that we want to inherit stuff from
    // The inheritor is called the subclass while the one that is inherited from is called the superclass
    class Construction_Robot : Robot
    {
        // When we have a constructor in a superclass, that will cause a type of the class to be created as well
        // If we don't have an empty parameter-less constructor, then a constructor in the subclass can't be created
        // To solve this we use the base keyword and insert the parameter of the superclass constructor into it
        // This supplies a value to the property of the superclass
        public Construction_Robot(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Registration number detected");
        }
        public void BuildWall()
        {
            Console.WriteLine("Construction begins ");
        }

        // By adding an override to the method we change what that method does compared to the one in the original superclass
        // That means that instances of this subclass using this method will use the overridden version of the method instead
        public override void Move()
        {
            Console.WriteLine("VRRRRRRRRRRRRR");
        }
    }
    // Note: One problem with inheritance is that the hierarchies of classes could easily become too large
    // This means that once we change one class we could end up messing up a lot more classes
}