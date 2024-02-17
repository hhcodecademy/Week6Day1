using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    internal class Cow : Animal
    {
        public override void animalSound(string name)
        {
            Console.WriteLine($"The {name} says: mou mou");
        }
        public override void eat()
        {
            Console.WriteLine("cow can be eat ot");
        }
    }
}
