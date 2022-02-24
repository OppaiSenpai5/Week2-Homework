using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public abstract class Person
    {
        string Name { get; set; }

        protected Person(string name)
        {
            Name = name;
        }
    }
}
