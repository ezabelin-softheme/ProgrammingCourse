using System;

namespace ConditionsExercise3
{
    class Program
    {
        private static double _piNumber;
        private static decimal _eNumber;

        static void Main()
        {
            _piNumber = 3.141592653;
            _eNumber = 2.7182818284590452m;

            Console.WriteLine("Value of Pi number is " + _piNumber);
            Console.WriteLine("Value of Euler's number is " + _eNumber);

            Console.ReadKey();
        }
    }
}
