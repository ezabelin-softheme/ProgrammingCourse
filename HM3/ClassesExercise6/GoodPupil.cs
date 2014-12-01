using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise6
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("\tGood pupil: studying good");
        }

        public override void Read()
        {
            Console.WriteLine("\tGood pupil: reading good");
        }

        public override void Write()
        {
            Console.WriteLine("\tGood pupil: reading good");
        }

        public override void Relax()
        {
            Console.WriteLine("\tGood pupil: relaxing moderately");
        }
    }
}
