using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.baitap4
{
    public abstract class Phone
    {
        public abstract void insertPhone(string name, string phone);
        public abstract void removePhone(string name);
        public abstract void updatePhone(string name, string newphone);
        public abstract void searchPhone(string name);
        public abstract void sort();

    }
}
