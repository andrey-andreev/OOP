using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string PermanentAddress { get; set; }
        public int MobilePhone { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }

        private Specialty specialty;
        private University university;
        private Faculty faculty;

        public Specialty Specialty
        {
            get { return this.specialty; }
        }

        public University University
        {
            get { return this.university; }
        }

        public Faculty Faculty
        {
            get { return this.faculty; }
        }

        public Student()
        { }

        public Student(
            string firstName, 
            string middleName, 
            string lastName, 
            int ssn, 
            string permanentAddress, 
            int mobilePhone, 
            string email, 
            string course, 
            Specialty specialty, 
            University university,
            Faculty faculty) // TODO : WHY
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.specialty = specialty; // TODO : WHY
            this.university = university; // TODO : WHY
            this.faculty = faculty; // TODO : WHY
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.FirstName + ", ");
            sb.Append(this.MiddleName + ", ");
            sb.Append(this.LastName + ", ");
            sb.Append(this.SSN + ", ");
            sb.Append(this.PermanentAddress + ", ");
            sb.Append(this.MobilePhone + ", ");
            sb.Append(this.Email + ", ");
            sb.Append(this.Course + ", ");
            sb.Append(this.specialty + ", ");
            sb.Append(this.university + ", ");
            sb.Append(this.faculty);

            return sb.ToString();
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (this.SSN != (obj as Student).SSN)
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(Student.Equals(firstStudent, secondStudent));
        }

        public Student Clone() // TODO : WHY
        {
            Student newCloneOfStudent = new Student(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.SSN,
                this.PermanentAddress,
                this.MobilePhone,
                this.Email,
                this.Course,
                this.specialty,
                this.university,
                this.faculty
                );
                
            return newCloneOfStudent as Student; 
        }

        object ICloneable.Clone() // TODO : WHY
        {
            return this.Clone();
        }

        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            {
                return this.FirstName.CompareTo(student.FirstName);
            }
            if (this.LastName != student.LastName)
            {
                return this.LastName.CompareTo(student.LastName);
            }
            if (this.SSN != student.SSN)
            {
                return (this.SSN - student.SSN);
            }

            return 0;
        }
    }
}