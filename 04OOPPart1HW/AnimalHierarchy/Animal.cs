using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public bool Male { get; protected set; }

        protected Animal(string name, int age, bool male)
        {
            this.Name = name;
            this.Age = age;
            this.Male = male;
        }

        public abstract string Sound();

        public static double CalculateAverageAge(ICollection<Animal> animals)
        {
            double averageAge = 0;
            averageAge = animals.Average((x) => x.Age);

            return averageAge;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name=" + this.Name + ", Age=" + this.Age + ", Male=" + this.Male);

            return sb.ToString();
        }
    }
}
