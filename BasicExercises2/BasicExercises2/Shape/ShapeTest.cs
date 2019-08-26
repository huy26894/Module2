using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.Class4
{
    public class ShapeTest
    {
        public static void Main()
        {
            Console.WriteLine("****Rectangle****");
            var rect = new Rectangle();
            rect.Side1 = 5;
            rect.Side2 = 5;
            rect.setSide();
            Console.WriteLine(rect.toString(true));
            Console.WriteLine(rect.toString(false));

            Console.WriteLine("\n****Circle****");
            var circle = new Circle();
            circle.Radius = 6;
            circle.setRadius();
            Console.WriteLine(circle.toString(true));
            Console.WriteLine(circle.toString(false));

        }
    }
}
