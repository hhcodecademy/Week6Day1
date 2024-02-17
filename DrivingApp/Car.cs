using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingApp
{
    internal class Car : IDrivible
    {
        public void Drive()
        {
            Console.WriteLine("Surulen masin deyisdi");
        }
    }
}
