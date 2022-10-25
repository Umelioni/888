using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Base printer, Print(\"example text\"): \n\t");
            new Printer().Print("example text");

            Console.Write("Printer HP, Print(\"example text\"): \n\t");
            new HP().Print("example text");

            Console.Write("Printer Canon, Print(\"example text\"): \n\t");
            new Canon().Print("example text");

            Console.ReadKey();
        }
    }
}
