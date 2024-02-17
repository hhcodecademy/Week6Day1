using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    internal class Car : Vehicle
    {
        public override void bust()
        {
            Console.WriteLine("bust gelisdirilidi");
        }
    }
}
