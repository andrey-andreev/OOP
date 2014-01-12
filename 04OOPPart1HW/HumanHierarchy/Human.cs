using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanHierarchy
{
    public abstract class Human
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }

        protected Human(string firstname, string lastName)
        {
            this.FirstName = firstname;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
