using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    internal class Dog : Animal
    {
        public override void animalSound(string name)
        {
            Console.WriteLine($"The {name} says: ham ham");
        }
    }
}
