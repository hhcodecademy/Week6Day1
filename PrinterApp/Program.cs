namespace PrinterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************NTH01************");
            PrinterNTH01 nth01 = new PrinterNTH01();
            nth01.PrintOneSide();
            nth01.Scan();

         

            Console.WriteLine("*********************NTH02************");
            PrinterNTH02 nth02 = new PrinterNTH02();
            nth02.PrintOneSide();
            nth02.Scan();
            nth02.PrintTwoSide();

            Console.WriteLine("*********************NTH03************");

            PrinterNTH03 nth03 = new PrinterNTH03();
            nth03.PrintOneSide();
            nth03.Scan();
            nth03.PrintTwoSide();
            nth03.Fax();
        }
    }
}
