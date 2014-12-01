using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise6
{
    class ClassRoom
    {
        public Pupil Pupil1 { get; set; }
        public Pupil Pupil2 { get; set; }
        public Pupil Pupil3 { get; set; }
        public Pupil Pupil4 { get; set; }

        public ClassRoom(Pupil pupil)
        {
            Pupil1 = pupil;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2):this(pupil1)
        {
            Pupil2 = pupil2;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3) :this(pupil1, pupil2)
        {
            Pupil3 = pupil3;
        }
    }
}
