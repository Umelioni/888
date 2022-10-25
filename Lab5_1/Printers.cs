using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    public class Printer
    {
        public void Print(string value)
        {
            Type thisType = this.GetType();
            if (thisType.IsSubclassOf(typeof(Printer)))
            {
                if (thisType == typeof(HP))
                    Console.ForegroundColor = ConsoleColor.Cyan;
                else if (thisType == typeof(Canon))
                    Console.ForegroundColor = ConsoleColor.Magenta;
                else Console.ResetColor();
            }
            else Console.ResetColor();
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
    public class HP : Printer
    {

    }

    public class Canon : Printer
    {

    }


}

