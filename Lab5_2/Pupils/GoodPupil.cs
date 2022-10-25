using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2.Pupils
{
    public class GoodPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Учень читає уважно");
        }

        public override void Relax()
        {
            Console.WriteLine("Учень вiдпочiває з користю");
        }

        public override void Study()
        {
            Console.WriteLine("Учень вчиться добре");
        }

        public override void Write()
        {
            Console.WriteLine("Учень пише добре");
        }
    }
}
