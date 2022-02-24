using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    public class Worker : Human
    {
        public double Salary { get; set; }
        public double HoursWorked { get; set; }

        public Worker(string firstName, string lastName, double salary, double hoursWorked)
            : base(firstName, lastName)
        {
            Salary = salary;
            HoursWorked = hoursWorked;
        }

        public double CalculatePayPerHour() => Salary / HoursWorked;
    }
}
