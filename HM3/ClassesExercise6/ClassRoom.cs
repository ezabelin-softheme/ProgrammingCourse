using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise6
{
    class ClassRoom
    {
        public Pupil[] Pupils { get; set; }

        public ClassRoom(Pupil pupil)
        {
            Pupils = new Pupil[4];
            Pupils[0] = pupil;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2):this(pupil1)
        {
            Pupils[1] = pupil2;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3) :this(pupil1, pupil2)
        {
            Pupils[2] = pupil3;
        }
    }
}
