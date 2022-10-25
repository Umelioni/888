using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2.Pupils
{
    public class BadPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Учень робить вид, що читає");
        }

        public override void Relax()
        {
            Console.WriteLine("Учень тiльки i робить, що вiдпочiває");
        }

        public override void Study()
        {
            Console.WriteLine("Учень не вчить ничого");
        }

        public override void Write()
        {
            Console.WriteLine("Учень не пише ничого");
        }
    }
}
