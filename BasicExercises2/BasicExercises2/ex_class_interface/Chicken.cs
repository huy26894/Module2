using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.ex_class_interface
{
    class Chicken : Animal, IEdible
    {
        public override string MakeSound()
        {
            return "chip chip";
        }

        public string HowToEat()
        {
            return "rice";
        }
    }
}
