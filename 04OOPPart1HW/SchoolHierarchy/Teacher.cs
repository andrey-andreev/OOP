using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolHierarchy
{
    public class Teacher : Person
    {
        public List<Discipline> DisciplineSet { get; set; }

        public Teacher(string name) 
            : base(name)
        {
            this.DisciplineSet = new List<Discipline>();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.Append("; Disciplines = ");
            for (int i = 0; i < this.DisciplineSet.Count; i++)
            {
                result.Append(this.DisciplineSet[i].Name);
                if (i != this.DisciplineSet.Count - 1)
                {
                    result.Append(", ");   
                }
            }

            return result.ToString();
        }
    }
}
