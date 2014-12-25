using System;

namespace AbstractionExercise2
{
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Playing has been started");
        }

        public void Record()
        {
            Console.WriteLine("Recodring has been started");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Playing has been paused");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Playing has been stoped");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Recodring has been paused");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Recodring has been stoped");
        }
    }
}
