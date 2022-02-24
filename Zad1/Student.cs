using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class Student : Person
    {
        int Uuid { get; set; }

        public Student(string name, int uuid)
            : base(name)
        {
            Uuid = uuid;
        }
    }
}
