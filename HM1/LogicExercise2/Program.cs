using System;

namespace LogicExercise2
{
    class Program
    {
        static void Main()
        {
            int x = 5;
            int y = 10;
            int z = 15;

            x += y >> (x++ * z);
            Console.WriteLine("Result of first operation is " + x);

            x = 5;
            y = 10;
            z = 15;

            z = ++x & y*5;
            Console.WriteLine("Result of second operation " + z);

            x = 5;
            y = 10;
            z = 15;
            
            y /= x + 5 | z;
            Console.WriteLine("Result of third operation " + y);

            x = 5;
            y = 10;
            z = 15;

            z = x++ & y * 5;
            Console.WriteLine("Result of fourth operation " + z);

            x = 5;
            y = 10;
            z = 15;

            x = y << x++ ^ z;
            Console.WriteLine("Result of fifth operation " + x);
        }
    }
}
