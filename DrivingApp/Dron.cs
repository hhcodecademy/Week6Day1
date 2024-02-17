using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingApp
{
    internal class Dron : IFlyible
    {
        public void Fly()
        {
            Console.WriteLine("Dronun ucus qabiliyyeti aktivdir");
        }
    }
}
