using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterApp
{
    internal class PrinterNTH03 : IPrinterNTH01, IPrinterNTH02, IPrinterNTH03
    {
        public void Fax()
        {
            Console.WriteLine("NTH03 Fax prosesi ugurla isleyir");
        }


        public void PrintOneSide()
        {
            Console.WriteLine("NTH03 Tek uzlu cap isleyir");
        }

        public void Scan()
        {
            Console.WriteLine("NTH03 Scan prosesi ugurla isleyir");
        }

        public void PrintTwoSide()
        {
            Console.WriteLine("NTH03 Iki uzlu cap isleyir");
        }
    }
}
