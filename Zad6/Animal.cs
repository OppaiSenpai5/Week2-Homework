using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    public abstract class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public Animal(int age, string name, string gender)
        {
            Age = age;
            Name = name;
            Gender = gender;
        }

        public virtual void MakeNoise()
        {
            Console.WriteLine($"{this.Name}:");
        }
    }
}
