using System;

namespace ClassesExercise6
{
    class Program
    {
        static void Main()
        {
            ClassRoom classRoom = new ClassRoom(new GoodPupil(), new BadPupil(), new ExcelentPupil());
            classRoom.Pupil4 = new GoodPupil();

            Console.WriteLine("Pupil1 information:");
            classRoom.Pupil1.Study();
            classRoom.Pupil1.Write();
            classRoom.Pupil1.Read();
            classRoom.Pupil1.Relax();

            Console.WriteLine("Pupil2 information:");
            classRoom.Pupil2.Study();
            classRoom.Pupil2.Write();
            classRoom.Pupil2.Read();
            classRoom.Pupil2.Relax();

            Console.WriteLine("Pupil3 information:");
            classRoom.Pupil3.Study();
            classRoom.Pupil3.Write();
            classRoom.Pupil3.Read();
            classRoom.Pupil3.Relax();

            Console.WriteLine("Pupil4 information:");
            classRoom.Pupil4.Study();
            classRoom.Pupil4.Write();
            classRoom.Pupil4.Read();
            classRoom.Pupil4.Relax();

            Console.ReadKey();
        }
    }
}
