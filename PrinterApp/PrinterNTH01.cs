using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterApp
{
    internal class PrinterNTH01 : IPrinterNTH01
    {
        public void PrintOneSide()
        {
            Console.WriteLine("NTH01 Tek uzlu cap isleyir");
        }

        public void Scan()
        {
            Console.WriteLine("NTH01 Scan prosesi ugurla isleyir");
        }
    }
}
