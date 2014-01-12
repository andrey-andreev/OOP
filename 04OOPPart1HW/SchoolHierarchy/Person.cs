using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolHierarchy
{
    public abstract class Person : IAnnotation
    {
        public string Name {  get; protected set; }

        public Person(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return "Name = " + this.Name;
        }
    }
}
