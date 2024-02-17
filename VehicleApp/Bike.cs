using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    internal class Bike :Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int WheelCount { get; set; }

      
        public override void bust()
        {
            Console.WriteLine("bust ozleliyiin bike uygun  gelisdirilidi");
        }

        public override void drive(string text)
        {
           
            Console.WriteLine("bu bike class deyisdi");
        }
      
    }
}
