using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2
{
    class testinterface
    {
        static void Main(string[] args)
        {
            IRank obj = new UTC();
            Console.WriteLine(obj.Ranking(2.6f));

            IRank obj1 = new Apolo();
            Console.WriteLine(obj1.Ranking(60));

            Console.Read();
        }
    }
}
