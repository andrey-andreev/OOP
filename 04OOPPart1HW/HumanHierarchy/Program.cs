using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            //students
            List<Student> studentList = new List<Student>()
            {
                new Student("Ivan", "Petkov", 12),
                new Student("Petko", "Mihaylov", 9),
                new Student("Georgi", "Ivanov", 8),
                new Student("Ivo", "Ivanov", 4),
                new Student("Andrei", "Ivanov", 7),
                new Student("Stefan", "Ivaylov", 11),
                new Student("Misho", "Georgiev", 5),
                new Student("Joro", "Nikolaev", 12),
                new Student("Niki", "Andreev", 8),
                new Student("Stamat", "Stefanov", 6)
            };

            var newStudentList =
                from student in studentList
                orderby student.Grade
                select student;
            Console.WriteLine("Students sorted by grade:\n");
            foreach (var student in newStudentList)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            //workers
            List<Worker> workerList = new List<Worker>()
            {
                new Worker("Nikolay", "Stamatov", 150.5, 7.5),
                new Worker("Joro", "Nikolaev", 259.9, 5.5),
                new Worker("Ivaylo", "Stamatov", 190.8, 8),
                new Worker("Ivo", "Stamatov", 165.8, 3),
                new Worker("Ivan", "Georgiev", 90.15, 5),
                new Worker("Georgi", "Stamatov", 259.9, 9.5),
                new Worker("Joro", "Ivanov", 245.5, 12),
                new Worker("Stamat", "Andreev", 210.5, 7.5),
                new Worker("Niki", "Milaylov", 85.5, 4),
                new Worker("Andrei", "Ivaylov", 350.5, 5.5)
            };

            var newWorkerList =
                from worker in workerList
                orderby worker.MoneyPerHour() descending
                select worker;
            Console.WriteLine("Workers sorted by money per hour.\n");
            foreach (var worker in newWorkerList)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();

            
            var mergedList = studentList.Concat<Human>(workerList);
            var newMergedList =
                from human in mergedList
                orderby human.FirstName , human.LastName 
                select human;

            Console.WriteLine("Merged and sorted list of student and workers by first and last name.\n");
            foreach (var human in newMergedList)
            {
                Console.WriteLine(human);
            }
        }
    }
}
