using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog testDog = new Dog("Spike", 7, true);
            Console.WriteLine(testDog);
            Console.WriteLine(testDog.Sound());

            Frog testFrog = new Frog("Greeny", 1, false);
            Console.WriteLine(testFrog);
            Console.WriteLine(testFrog.Sound());

            Cat testCat = new Cat("Jack", 4, true);
            Console.WriteLine(testCat);
            Console.WriteLine(testCat.Sound());

            Kitten testKitten = new Kitten("Kity", 3);
            Console.WriteLine(testKitten);
            Console.WriteLine(testKitten.Sound());

            Tomcat testTomcat = new Tomcat("Tom", 6);
            Console.WriteLine(testTomcat);
            Console.WriteLine(testTomcat.Sound());

            List<Animal> animals = new List<Animal>()
            {
                testCat, testDog, testFrog, testKitten, testTomcat
            };
            Console.WriteLine(Animal.CalculateAverageAge(animals));
        }
    }
}
