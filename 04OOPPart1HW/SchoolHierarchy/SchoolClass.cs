using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolHierarchy
{
    public class SchoolClass : IAnnotation
    {
        private static char curentIdentifier = 'A';

        public char Identifier { get; private set; }

        public List<Student> Students { get; set; }
        public List<Teacher> TeachersSet { get; set; }
        public List<Discipline> DisciplinesSet { get; set; }

        public SchoolClass() 
        {
            this.Identifier = curentIdentifier;
            this.Students = new List<Student>();
            this.TeachersSet = new List<Teacher>();
            this.DisciplinesSet = new List<Discipline>();
            IdentifierGrow();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Class = ");
            result.Append(this.Identifier.ToString());
            result.Append("; Number of students = ");
            result.Append(this.Students.Count);
            result.Append("; Number of disciplines = ");
            result.Append(this.DisciplinesSet.Count);

            return  result.ToString();
        }

        private void IdentifierGrow()
        {
            curentIdentifier = (char)(curentIdentifier + 1);
        }
    }
}
