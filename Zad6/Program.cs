using System;

namespace Zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals =
            {
                new Dog(4, "Sharo", "male"),
                new Frog(2, "George", "male"),
                new Cat(3, "Mittens", "female"),
                new Kitten(1, "Mila", "female"),
                new Tomcat(7, "Tomas", "male"),
            };

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal.Name} is {animal.Age}y/o and {animal.Gender}");
                animal.MakeNoise();
            }
        }
    }
}
