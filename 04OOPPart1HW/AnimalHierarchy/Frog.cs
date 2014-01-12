using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, bool male)
            : base(name, age, male)
        {
        }

        public override string Sound()
        {
            return "Kvaaak !!!";
        }
    }
}
