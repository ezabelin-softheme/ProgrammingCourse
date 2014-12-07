using System;

namespace ClassesExercise6
{
    class Program
    {
        static void Main()
        {
            ClassRoom classRoom = new ClassRoom(new GoodPupil(), new BadPupil(), new ExcelentPupil());
            classRoom.Pupils[3] = new GoodPupil();

            Console.WriteLine("Pupil1 information:");
            classRoom.Pupils[0].Study();
            classRoom.Pupils[0].Write();
            classRoom.Pupils[0].Read();
            classRoom.Pupils[0].Relax();

            Console.WriteLine("Pupil2 information:");
            classRoom.Pupils[1].Study();
            classRoom.Pupils[1].Write();
            classRoom.Pupils[1].Read();
            classRoom.Pupils[1].Relax();

            Console.WriteLine("Pupil3 information:");
            classRoom.Pupils[2].Study();
            classRoom.Pupils[2].Write();
            classRoom.Pupils[2].Read();
            classRoom.Pupils[2].Relax();

            Console.WriteLine("Pupil4 information:");
            classRoom.Pupils[3].Study();
            classRoom.Pupils[3].Write();
            classRoom.Pupils[3].Read();
            classRoom.Pupils[3].Relax();

            Console.ReadKey();
        }
    }
}
