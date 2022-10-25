using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    public class Classroom
    {
        Pupil[] currentPupils;
        public Classroom(params Pupil[] pupils)
        {
            if (pupils.Length > 4)
            {
                throw new ArgumentOutOfRangeException("Забагато учнiв, максимум 4 учня в классi");
                return;
            }
            currentPupils = pupils;
        }
        public void Greeting()
        {
            for (int i = 1; i <= currentPupils.Length; i++)
            {
                var pupil = currentPupils[i-1];
                Console.WriteLine($"Учень №{i}: ");
                Console.Write("\t• ");
                pupil.Study();
                Console.Write("\t• ");
                pupil.Read();
                Console.Write("\t• ");
                pupil.Write();
                Console.Write("\t• ");
                pupil.Relax();
            }
        }
    }
}
