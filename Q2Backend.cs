using System;
using System.Collections.Generic;
using System.Text;

namespace BackEndQ1
{
    public class Animal
    {
        public string Eat()
        {
            return "Yummy";
        }
        public virtual string MakeNoise()
        {
            return "Durrr";
        }
    }

    class Horse : Animal
    {
        public override string MakeNoise()
        {
            return "Neigh";
        }
    }

    class Sheep : Animal
    {
        public override string MakeNoise()
        {
            return "Baaah";
        }
    }
}
