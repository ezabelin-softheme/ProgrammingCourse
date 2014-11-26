using System;
using System.Text;

namespace ArraysExercise3
{
    class Program
    {
        private static int[] ExtendArrayToOneElement(int[] array, int newValue)
        {
            int[] newArray = (int[])array.Clone();
            Array.Resize(ref newArray, array.Length + 1);
            newArray[newArray.Length - 1] = newValue;
            return newArray;
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Базовый массив:");
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }

            int[] extendedArray = ExtendArrayToOneElement(array, 6);

            Console.WriteLine("Расширенный массив:");
            foreach (int element in extendedArray)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}
