using System;

namespace dojodachi.Models
{
    public class Pet
    {
        public int Happiness {set;get;}
        public int Fullness {set;get;}
        public int Energy {set;get;}
        public int Meals {set;get;}

        public Pet ()
        {
            Happiness = 20;
            Fullness = 20;
            Energy = 50;
            Meals = 3;
        }
        public Pet (int ha, int fu, int en, int me)
        {
            Happiness = ha;
            Fullness = fu;
            Energy = en;
            Meals = me;
        }
    }
}