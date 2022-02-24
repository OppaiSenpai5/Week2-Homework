using System;
using System.Linq;
using Zad2;

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers =
            {
                new Worker("Bob", "Bob", 10000, 34),
                new Worker("Tom", "Tom", 34000, 27),
                new Worker("Tim", "Tim", 99999, 99),
                new Worker("Joe", "Joe", 12000, 57),
                new Worker("John", "John", 64000, 56),
                new Worker("Doe", "Doe", 4000, 20),
                new Worker("Luke", "Luke", 1200000, 100),
                new Worker("Sam", "Sam", 50000, 60),
                new Worker("Rick", "Rick", 4500, 34),
                new Worker("Moe", "Moe", 6700, 13)
            };

            var sortedWorkers = workers.OrderByDescending(x => x.Salary);
            foreach (Worker worker in sortedWorkers)
            {
                Console.WriteLine($"{worker.FirstName} - {worker.Salary}");
            }
        }
    }
}
