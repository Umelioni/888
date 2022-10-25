using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть ключ: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case ApplicationLicense.trialKey:
                    Console.Write("Версiя змiнена на ");
                    ApplicationLicense.AllowTrial();
                    break;
                case ApplicationLicense.proKey:
                    Console.Write("Версiя змiнена на ");
                    ApplicationLicense.AllowPro();
                    break;
                default:
                    if (input.Length > 1)
                        Console.WriteLine("Ключ недiйсний.");
                    ApplicationLicense.AllowCommon();
                    break;
            }
            do
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                Console.WriteLine();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.Q:
                        ApplicationLicense.PrintLicense();
                        Console.WriteLine("Ви нажали на Q");
                        break;
                    case ConsoleKey.W:
                    case ConsoleKey.E:
                        ApplicationLicense.PrintLicense();
                        if (ApplicationLicense.License == ApplicationLicense.LicenseTypes.Common)
                            Console.WriteLine("Купить лiцензiю, щоб нажимать бiльш нiж на 1 кнопку");
                        else
                            Console.WriteLine("Ви змогли нажать бiльш нiж на 1 кнопку, вiтаєм");
                        break;

                }
            } while (true);
        }
    }
}
