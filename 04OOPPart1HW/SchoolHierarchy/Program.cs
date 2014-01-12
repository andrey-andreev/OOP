using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            //students
            Student firstStudent = new Student("Ivan Ivanov");
            Student secondStudent = new Student("Petko Petkov");
            Student thirdStudent = new Student("Georgi Georgiev");
            thirdStudent.AddComment("Excelent student.");
            Console.WriteLine(firstStudent.ToString());
            Console.WriteLine(secondStudent.ToString());
            Console.WriteLine(thirdStudent.Comment);
            Console.WriteLine();
            
            //disciplines
            Discipline math = new Discipline("Math", 13, 11);
            Discipline biology = new Discipline("Biology", 12, 10);
            Discipline geography = new Discipline("Geography", 15, 12);
            
            //teachers
            Teacher firstTeacher = new Teacher("Gramatikov");
            firstTeacher.DisciplineSet.Add(math);
            firstTeacher.DisciplineSet.Add(biology);
            firstTeacher.DisciplineSet.Add(geography);
            Console.WriteLine(firstTeacher.ToString());
            Console.WriteLine();

            //classes
            SchoolClass firstTestClass = new SchoolClass();
            firstTestClass.TeachersSet.Add(firstTeacher);
            firstTestClass.Students.Add(firstStudent);
            firstTestClass.Students.Add(secondStudent);
            firstTestClass.Students.Add(thirdStudent);
            firstTestClass.DisciplinesSet.Add(math);
            firstTestClass.DisciplinesSet.Add(biology);
            firstTestClass.DisciplinesSet.Add(geography);
            Console.WriteLine(firstTestClass.ToString());

            SchoolClass secondTestClass = new SchoolClass();

            //school
            School testSchool = new School();
            testSchool.SchoolClasses.Add(firstTestClass);
        }
    }
}

