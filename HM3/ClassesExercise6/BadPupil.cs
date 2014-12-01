using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise6
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("\tBad pupil: do not studying");
        }

        public override void Read()
        {
            Console.WriteLine("\tBad pupil: do not read at all");
        }

        public override void Write()
        {
            Console.WriteLine("\tBad pupil: do not write at all");
        }

        public override void Relax()
        {
            Console.WriteLine("\tBad pupil: relaxing every minut");
        }
    }
}
