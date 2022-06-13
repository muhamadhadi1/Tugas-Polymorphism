using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hadi_Gunawan
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;

            Console.WriteLine("Pilih Printer:");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3.LasetJet\n");

            Console.Write("Nomor Printer [1..3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (nomorPrinter == 1)
                printer = new Epson();
            else if (nomorPrinter == 2)
                printer = new Canon();
            else
                printer = new LaserJet();

            printer.show();
            printer.Print();

            Console.ReadKey();
        }
    }
    public class PrinterWindows
    {
        public virtual void show()
        {

        }
        public virtual void Print()
        {

        }
    }
    public class Epson : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }
        public override void Print()
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
    public class Canon : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }
        public override void Print()
        {
            Console.WriteLine("Canon printer printing....");
        }
    }
    public class LaserJet : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("Lasetjet display dimension : 12*12");
        }
        public override void Print()
        {
            Console.WriteLine("Lasetjet printer printing....");
        }
    }

}
