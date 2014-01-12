using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, bool male)
            : base(name, age, male)
        {
        }

        public override string Sound()
        {
            return "Myauuu !!!";
        }
    }
}
