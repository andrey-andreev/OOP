using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Test
    {
        static void Main(string[] args)
        {
            // creating an array of anonymous type for testing the LINQ queries
            var students = new[]
            {
                new {FirstName = "Pencho", LastName = "Ivanov", Age = 13},
                new {FirstName = "Ivan", LastName = "Petkov", Age = 26},
                new {FirstName = "Ivan", LastName = "Peikov", Age = 32},
                new {FirstName = "Jorko", LastName = "Petkov", Age = 15},
                new {FirstName = "Andreicho", LastName = "Kostov", Age = 19},
                new {FirstName = "Andrei", LastName = "Trifonov", Age = 21}
            };

            /* 3.Write a method that from a given array of students finds all students 
             * whose first name is before its last name alphabetically. Use LINQ query 
             * operators.
             */
            Console.WriteLine("3.");
            Console.WriteLine("LINQ:");
            var newStudentLINQ =
                from student in students
                where String.Compare(student.FirstName, student.LastName) < 0
                select student;
            foreach (var item in newStudentLINQ)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nLambda:");
            var newStudentsLambda = Array.FindAll(students, x => 
                String.Compare(x.FirstName, x.LastName) < 0);

            foreach (var item in newStudentsLambda)
            {
                Console.WriteLine(item);
            }

            /* 4.Write a LINQ query that finds the first name and last name of all 
             * students with age between 18 and 24.
             */
            Console.WriteLine("\n4.");
            Console.WriteLine("LINQ:");
            var newStudentLINQAge =
                from student in students
                where student.Age < 24 && student.Age > 18
                select student;

            foreach (var item in newStudentLINQAge)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nLambda:");
            var newStudentsLambdaAge = Array.FindAll(students, x => 
                x.Age < 24 && x.Age > 18);
            foreach (var item in newStudentsLambdaAge)
            {
                Console.WriteLine(item);
            }

            /* 5.Using the extension methods OrderBy() and ThenBy() with lambda expressions 
             * sort the students by first name and last name in descending order. Rewrite 
             * the same with LINQ.
             */
            Console.WriteLine("\n5.");
            // Lambda
            Console.WriteLine("Lambda :");
            var studentsSortedByNameLambda = students.OrderByDescending(x => (x.FirstName)).ThenByDescending(x => (x.LastName));
            foreach (var item in studentsSortedByNameLambda)
            {
                Console.WriteLine(item);
            }
                
            //LINQ
            Console.WriteLine("\nLINQ :");
            var studentsSortedByNameLINQ = 
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var item in studentsSortedByNameLINQ)
            {
                Console.WriteLine(item);
            }

            

            

        }
    }
}
