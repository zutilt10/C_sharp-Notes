using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Abstract_Classes
{
    // Other than overriding virtual methods, we can also override abstract methods
    // We do this when we want to provide some common behaviours while following a certain design
    // When we want to use an abstract method, we need the class that contains it to be abstract as well
    // The abstract method has no implementation ie. there is no code within it
    // This will force subclasses to implement something in place of the superclass
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public abstract void Draw();
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle drawn");   
        }
    }
    // When we have an abstract class, we cannot create an instance of it
    class Abstract_Classes
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();
        }
    }
}
