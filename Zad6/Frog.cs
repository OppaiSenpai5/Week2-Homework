using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Frog : Animal
    {
        public Frog(int age, string name, string gender)
            : base(age, name, gender)
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{this.Name}: Ribbit ribbit!");
        }
    }
}
