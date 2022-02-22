using System;

namespace AbstractExample.Models
{
    public class Owl : Animal
    {
        public Owl(string name)
        {
            Name = name;
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} says hoo hoo");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{Name} is not asleep!");
        }
    }
}

