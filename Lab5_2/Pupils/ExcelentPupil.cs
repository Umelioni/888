using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2.Pupils
{
    public class ExcelentPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Учень дуже уважно читає, все перечитує по 10 разiв");
        }

        public override void Relax()
        {
            Console.WriteLine("Учень навiть коли вiдпочiває вчиться");
        }

        public override void Study()
        {
            Console.WriteLine("Учень переходить в астральний стан, та вчить все про все");
        }

        public override void Write()
        {
            Console.WriteLine("Учень пише 1 листок А4 за 1 секунду");
        }
    }
}
