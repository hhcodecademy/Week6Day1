using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    internal abstract class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public void TurnOn()
        {
            Console.WriteLine("turn on ...");
        }
        public virtual void drive(string text) {

            Console.WriteLine(text);
        }
        public  void drive()
        {

            Console.WriteLine("default drive");
        }
        public abstract void bust();
    }
}
