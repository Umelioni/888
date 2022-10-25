using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5_2.Pupils;

namespace Lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            new Classroom(new BadPupil(), new GoodPupil(), new GoodPupil(), new ExcelentPupil()).Greeting();
            Console.ReadKey();

        }
    }
}
