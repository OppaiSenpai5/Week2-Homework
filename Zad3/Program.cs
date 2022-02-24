using System;
using Zad2;
using System.Linq;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student("Bob", "Bob", 5.67),
                new Student("Tom", "Tom", 4.44),
                new Student("Tim", "Tim", 2.67),
                new Student("Joe", "Joe", 3.01),
                new Student("John", "John", 5.00),
                new Student("Doe", "Doe", 5.87),
                new Student("Luke", "Luke", 4.34),
                new Student("Sam", "Sam", 4.88),
                new Student("Rick", "Rick", 4.50),
                new Student("Moe", "Moe", 3.97)
            };

            var sortedStudents = students.OrderBy(x => x);
            foreach (Student student in sortedStudents)
            {
                Console.WriteLine($"{student.FirstName} - {student.Grade:.00}");
            }
        }
    }
}
