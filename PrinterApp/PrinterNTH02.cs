using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterApp
{
    internal class PrinterNTH02 : PrinterNTH01,IPrinterNTH02
    {
        //public void PrintOneSide()
        //{
        //    Console.WriteLine("NTH02 Tek uzlu cap isleyir");
        //}

        //public void Scan()
        //{
        //    Console.WriteLine("NTH02 Scan prosesi ugurla isleyir");
        //}

        public void PrintTwoSide()
        {
            Console.WriteLine("NTH02 Iki uzlu cap isleyir");
        }

    }
}
