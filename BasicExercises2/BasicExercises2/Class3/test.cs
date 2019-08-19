using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.Class3
{
    abstract class Shape1
    {
        private int x;
        private int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Shape1()
        {

        }
        public Shape1(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public abstract int Area();    // abstract chỉ khai báo phthuc còn cụ thể thì để override ở class kế thừa.

        public abstract int Perimeter();
        
    }
    class Rectangle : Shape1
    {
        public Rectangle()
        {

        }
        public Rectangle(int X, int Y) : base(X, Y)
        {

        }
        public override int Area()
        {
            return X * Y; 
        }

        public override int Perimeter()
        {
            return (X + Y) * 2;
        }

    }
    /*class Circle : Shape1
    {

    }*/
    class TestShape
    {
        static void Main()
        {
            Rectangle myRectangle = new Rectangle();
            Console.WriteLine(myRectangle.Area());
            Console.WriteLine(myRectangle.Perimeter());

            Rectangle myRectangle1 = new Rectangle(20, 10);
            Console.WriteLine(myRectangle1.Area());
            Console.WriteLine(myRectangle1.Perimeter());

        }
    }
}
