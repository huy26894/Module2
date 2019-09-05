using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.Class2
{
    class Shape
    {
        private int x;
        private int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Shape()
        {

        }
        public Shape(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public virtual int Area()
        {
            return x * y;   // dùng virtual ở pthuc of class cha để can thay đổi phương thức của lớp con.
        }
        public virtual int Perimeter()
        {
            return (x + y) * 2;
        }
    }
    class Rectangle : Shape
    {
        public Rectangle()
        {

        }
        public Rectangle(int X, int Y) : base( X,  Y)
        {

        }
        public override int Area()
        {
            return X * Y; // dùng virtual ở pthuc of class cha để can thay đổi phương thức của lớp con.
        }

        public override int Perimeter()
        {
            return base.Perimeter();
        }

    }
    class Circle : Shape
    {

    }
    class TestShape
    {
        static void Main()
        {
            Rectangle myRectangle = new Rectangle();
            Console.WriteLine(myRectangle.Area());
            Console.WriteLine(myRectangle.Perimeter());

            Rectangle myRectangle1 = new Rectangle( 20,  10);
            Console.WriteLine(myRectangle1.Area());
            Console.WriteLine(myRectangle1.Perimeter());

        }
    }


}
