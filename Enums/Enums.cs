using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Enums
{
    // An enum is a set of name/value pairs, in other words constants
    // We use enums for when we have a number of related constants
    // This will turn the enum into a new type like a class
    // If we do not explicitly assign a value to all the constants, the default value will be 1 for the first constant
    // The value will increment by 1 for each subsequent value
    public enum ShippingMethod
    {
        RegularMail = 1,
        RegisteredMail = 2,
        Express = 3
    }
    class Enums
    {
        static void Main(string[] args)
        {
            // Like a type, we can access the constants without a need to create an instance of the enum like a static class
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            // Like how we can convert types into different ones, we can convert other variables into enums as long as they share the same value
            var methodID = 3;
            Console.WriteLine((ShippingMethod)methodID);

            // We can also convert strings
            var methodName = "Express";
            // We have to use a method for that however, called .Parse
            // The method returns an object so we need to cast it as the enum by inserting the name of the enum in parathesis at the start
            var ship = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
