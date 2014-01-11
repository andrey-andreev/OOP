using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 6.Write a program that prints from given array of integers all numbers 
             * that are divisible by 7 and 3. Use the built-in extension methods and 
             * lambda expressions. Rewrite the same with LINQ.
             */
            int[] ints = new int[] { 243, -63, 15, -52, 21, 42, -21, 142, 345 };

            // Lambda
            Console.WriteLine("Lambda");
            //var studentsSortedByNameLambda = students.OrderBy(x => (x.FirstName)).ThenBy(x => (x.LastName));
            var divisibleBySevenAndThreeLambda = Array.FindAll(ints, x => ((x % 7 == 0) && (x % 3 == 0)));
            foreach (var item in divisibleBySevenAndThreeLambda)
            {
                Console.WriteLine(item);
            }

            //LINQ
            Console.WriteLine("\nLINQ");
            var divisibleBySevenAndThreeLINQ =
                from n in ints
                where (n % 3 == 0) && (n % 7 == 0)
                select n;

            foreach (var item in divisibleBySevenAndThreeLINQ)
            {
                Console.WriteLine(item);
            }
        }
    }
}
