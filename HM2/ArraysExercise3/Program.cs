using System;
using System.Text;

namespace ArraysExercise3
{
    class Program
    {
        private static int[] ExtendArrayToOneElementMy(int[] array, int newValue)
        {
            int[] newArray = new int[array.Length+1];
            
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            newArray[newArray.Length - 1] = newValue;
            return newArray;
        }

        private static int[] ExtendArrayToOneElementMyUsingDefaultMethods(int[] array, int newValue)
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

            int[] extendedArray = ExtendArrayToOneElementMy(array, 6);

            Console.WriteLine("Расширенный массив:");
            foreach (int element in extendedArray)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}
