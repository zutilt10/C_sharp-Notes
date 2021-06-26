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
}