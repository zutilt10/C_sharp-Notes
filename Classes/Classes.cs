using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Classes
{
    class Classes
    {
        // We use classes to describe objects
        // They function by creating objects with custom attributes with variables and methods, essentially like a blueprint
        // We create different instances of the same class with different values for the same attributes
        class Mech
        {
            // The word in front of the data types of the variables are called access modifiers
            // It defines where we can access the variables and the methods from
            // There are two access modifiers: public and private
            // Public means we can access the variable or method outside of the class
            // Private means we can only access the variable or method within the class itself
            // If no access modifier is written, the variable or method defaults to private
            public string name;
            private string weapon;
            public int ammo;
            public float experience;

            // Another keyword that is used a lot is, static
            // It can be used in addition to the access modifiers
            // By adding static, it means that the variable will belong to the type itself and not to any specific instance
            // When we add static to a variable, that variable becomes shared by all instances of the class
            public static int Count;

            // In order to save lines when creating new instances of a class, we can use a constructor which are a special kind of method 
            // Constructors allow us to choose what happens when a class is created
            // The syntax for a constructor is: public <Class name>()
            //                                  {
            //                                   <attributes to be set>
            //                                  }
            // We can also create parameters for contructors like they were methods
            // It is also possible to create more than 1 constructor per class
            // We would do this because some instances will have existing values for certain attributes while others will not
            public Mech(string _name, string _weapon)
            {
                name = _name;
                Weapon = _weapon;
                ammo = 5;
                experience = 0f;

                Count++;
            }

            public void Fire()
            {
                if (ammo > 0)
                {
                    Console.WriteLine(name + " fires " + weapon);
                    ammo--;
                }
                else
                {
                    Console.WriteLine(name + " has no more ammo");
                }
            }

            public void Reload()
            {
                Console.WriteLine(name + " reloads " + weapon);
                ammo = 5;
            }

            // Getters and Setters are special methods called properties
            // We use them in order to allow private atributes to accessed and be have certain specific values set to it  
            // Essentially, we restrict the values that the attribute can be set to
            // This can only be used with attributes that are private
            public string Weapon
            {
                get
                {
                    return weapon;
                }
                set
                {
                    // In the set block, the input that we give when a new instance of the class is created is called the value
                    if (value == "The Decimator" || value == "The Rocket")
                    {
                        weapon = value;
                    }
                    else
                    {
                        weapon = "Unarmed";
                    }
                }
            }
        }
        // We can also add the static keyword to classes and methods
        // This means that the methods within the class will not require an instance of the class to be created in order for it to be used
        static class Communication
        {
            public static void Initiate(int number)
            {
                Console.WriteLine("Staring up number " + number);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                // To create an instance of a class, the syntax is: <Name of class> <Name of instance> = new <Name of class>()
                // An instance of an object is called an object
                Mech mech01 = new Mech("Eradicator", "The Decimator");
                // To access the methods created in the class, we simply need to write: <name of instance>.<name of method>
                mech01.Fire();

                Mech mech02 = new Mech("Shield", "The Rocket");

                Mech mech03 = new Mech("Undaunted", "Gun");

                mech02.Fire();

                Console.WriteLine(mech03.Weapon);

                Communication.Initiate(2);

                // When we want to access static variables that are part of a class, we do not need to create a new instance of it
                Console.WriteLine(Mech.Count);

                Console.ReadKey();
            }
        }
    }
}