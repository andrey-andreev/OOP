using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolHierarchy
{
    public class Discipline : IAnnotation
    {
        public string Name { get; set; }
        public int NumberOfLectures  { get; set; }
        public int NumberOfExercies { get; set; }

        public Discipline(string name, int numberOfLectures, int numberOfExercies)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercies = numberOfExercies;
        }
    }
}
