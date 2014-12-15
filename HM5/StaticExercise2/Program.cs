using System;

namespace StaticExercise2
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[] { 5, 4, 0, 1, 10 };
            array = array.SortArrayByAscending();
            array.PrintArray();

            Console.ReadKey();
        }
    }
}
