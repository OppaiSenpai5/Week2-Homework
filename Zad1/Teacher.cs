using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class Teacher : Person
    {
        List<Subject> Subjects { get; set; }

        public Teacher(string name, List<Subject> subjects)
            : base (name)
        {
            Subjects = subjects;
        }
    }
}
