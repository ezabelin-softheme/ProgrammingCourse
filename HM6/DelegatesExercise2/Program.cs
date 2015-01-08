using System;

namespace DelegatesExercise2
{
    class Program
    {
        private delegate int Randomizer();
        private delegate double Average(Randomizer[] randomizers);

        static void Main()
        {
            Randomizer randomizer1 = MakeRandomValue;
            Randomizer randomizer2 = MakeRandomValue;
            Randomizer randomizer3 = MakeRandomValue;
            Randomizer randomizer4 = MakeRandomValue;
            Randomizer randomizer5 = MakeRandomValue;

            Randomizer[] randomizers =
            {
                randomizer1,
                randomizer2,
                randomizer3,
                randomizer4,
                randomizer5
            };

            Average avarageValue = delegate(Randomizer[] randomizersArray)
            {
                int sum = 0;

                foreach (var element in randomizersArray)
                {
                    sum += element();
                }

                double avarage = (double)sum / randomizersArray.Length;
                return avarage;
            };

            Console.WriteLine("Avarage value is {0}", avarageValue(randomizers));          
            Console.ReadKey();
        }

        private static int MakeRandomValue()
        {
            Random ran = new Random();
            int value = ran.Next(100);
            return value;
        }
    }
}
