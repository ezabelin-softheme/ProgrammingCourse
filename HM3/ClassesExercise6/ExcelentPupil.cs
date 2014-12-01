using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise6
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("\tExcelent pupil: studying excelent");
        }

        public override void Read()
        {
            Console.WriteLine("\tExcelent pupil: reading excelent");
        }

        public override void Write()
        {
            Console.WriteLine("\tExcelent pupil: reading excelent");
        }

        public override void Relax()
        {
            Console.WriteLine("\tExcelent pupil: relaxing just when he's sleeping :)");
        }
    }
}
