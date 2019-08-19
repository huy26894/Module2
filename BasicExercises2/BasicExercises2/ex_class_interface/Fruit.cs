using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.ex_class_interface
{
    abstract class Fruit : IEdible
    {
        public abstract string HowToEat();
    }
}
