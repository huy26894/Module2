using System;
using System.Collections.Generic;
using System.Text;
using BasicExercises2.Class4.Models;

namespace BasicExercises2.Class4
{
    public class Shape
    {
        protected Location c = new Location();
        
        /*public Location C { get => c; set => c = value; }*/

        public string toString(bool type)
        {
            return type ? "Area is: " + Area() : "Perimeter is: " + Perimeter();
        }

        //public void SetLocation(double s1, double s2)
        //{
          
        //    c.X(s1);
        //    c.SetY(s2);
        //}

        public virtual double Area()
        {
            return c.X * c.Y;
        }
        public virtual double Perimeter()
        {
            return (c.X + c.Y) * 2;
        }
    }
}
