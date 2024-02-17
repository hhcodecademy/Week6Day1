using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingApp
{
    internal class Airplane : IDrivible,IFlyible
    {
        public void Drive()
        {
            Console.WriteLine("Teyyarenin surulme ozelliyi aktivdir");
        }

        public void Fly()
        {
            Console.WriteLine("Teyyarenin ucma ozelliyi aktivdir");
        }
    }
}
