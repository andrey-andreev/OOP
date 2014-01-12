using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanHierarchy
{
    public class Student : Human
    {
        public int Grade { get; set; }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString() + ", ");
            sb.Append("grade = " + this.Grade);

            return sb.ToString();
        }
    }
}
