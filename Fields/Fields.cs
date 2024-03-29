﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Fields
{
    public class Customer
    {
        // This shows a method for overloading constructors
        // All have different parameters for different attributes
        // We can only call one of them for one instance of the class
        // We can also initialise lists/arrays or set certain values of certain variables no matter what constructor is used
        public int Id;
        public string Name;
        // With the readonly modifier, we can set a certain field to be initiated only once
        // This will help to improve the robustness of our code
        // A field can be initialised in a constructor or in the class
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

        // By adding the this keyword underneath the constructor's statement, we pass control from one constructor to another
        // The value in the parathesis helps dictate which constructor is having it's control passed on
        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }
    }

    public class Order
    {

    }

    class Fields
    {

    }
}