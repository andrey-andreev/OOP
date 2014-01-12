using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolHierarchy
{
    public class Student : Person
    {
        private static int currentID = 1;

        public int ID { get; private set; }
        
        public Student(string name) 
            : base(name)
        {
            this.ID = currentID;
            IDGrow();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("; ID = ");
            sb.Append(this.ID);

            return sb.ToString();
        }

        private void IDGrow()
        {
            currentID++;
        }
    }
}
