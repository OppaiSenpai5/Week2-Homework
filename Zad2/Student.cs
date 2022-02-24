using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    public class Student : Human, IComparable<Student>
    {
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            Grade = grade;
        }

        public int CompareTo(Student student)
        {
            int result = Grade.CompareTo(student.Grade);
            return result;
        }
    }
}
