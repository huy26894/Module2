using System;
using System.Collections.Generic;
using System.Text;
using BasicExercises2.Class4;

namespace BasicExercises2.Class4
{
    public class Rectangle : Shape
    {
        private double side1;
        private double side2;

        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }

        public void setSide()
        {
            c.X = Side1;
            c.Y = Side2;
           // SetLocation(side1, side2);
        }
  
    }
}
