using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class Subject
    {
        string Name { get; set; }
        int HoursCount { get; set; }
        int LabsCount { get; set; }

        public Subject(string name, int hoursCount, int labsCount)
        {
            Name = name;
            HoursCount = hoursCount;
            LabsCount = labsCount;
        }
    }
}
