using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Method_overriding
{
    // When we inherit from other classes, we can override certain methods in the superclass
    // We do this by creating a method with the same name as the method we wish to override
    // The original method must have the keyword virtual and the new method must have the keyword override
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drew a Rectangle");
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual void Draw()
        {

        }
    }

    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            // Here when the Draw method is called, instead of the Draw method in the Shape class being used, the overriden Draw in Rectangle is used
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
    class Method_overriding
    {
        static void Main(string[] args)
        {
            var list = new List<Shape>();
            var rectangle = new Rectangle();
            var canvas = new Canvas();

            list.Add(rectangle);
            canvas.DrawShapes(list);
        }
    }
}
