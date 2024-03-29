﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Inheritance
{
    class Robot
    {
        private readonly string _registrationNumber;
        // By adding a virtual to the methods in the superclass, we alow any subclass to override that method 
        public virtual void Move()
        {
            Console.WriteLine("Vrrrrrrrrrrr");
        }

        public void Activate()
        {
            Console.WriteLine("*Beep*....... 'Ready to serve' ");
        }

        public void ShutDown()
        {
            Console.WriteLine("*Boop*...... 'See you again' ");
        }

        public Robot(string registrationNumber)
        {
            Console.WriteLine("System booting up");
            _registrationNumber = registrationNumber;
        }
    }
}