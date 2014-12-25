using System;

namespace AbstractionExercise2
{
    class Program
    {
        static void Main()
        {
            IRecordable recorder = new Player();
            recorder.Record();
            recorder.Pause();
            recorder.Stop();

            IPlayable player = new Player();
            player.Play();
            player.Pause();
            player.Stop();

            Console.ReadKey();
        }
    }
}
