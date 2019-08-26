using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.Class4
{
    class Circle : Shape
    {
        private double radius;
        private const double pi = Math.PI;

        public double Radius { get => radius; set => radius = value; }

        public void setRadius()
        {
            c.X = Radius;
        }

        public override double Area()
        {
            return pi * radius * radius;
        }
        public override double Perimeter()
        {
            return 2 * radius * pi;
        }
    }
}
