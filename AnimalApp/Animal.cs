using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    internal abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound(string name);
        // Regular method
        public void sleep()
        {
            Console.WriteLine("animal is sleeping");
        }
        public virtual void eat() {
            Console.WriteLine("animal can be eay meat");
        }
    }
}
