using System;
using System.Text;

namespace ArraysExercise2
{
    class Program
    {
        private static int[] MyReverse(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            int i = 0;

            for (int j = array.Length-1; j >= 0; j--)
            {
                reversedArray[i] = array[j];
                i++;
            }

            return reversedArray;
        }

        private static int[] MyReverseUsingDefaultArrayMethod(int[] array)
        {
            int[] reversedArray = (int[]) array.Clone();
            Array.Reverse(reversedArray);
            return reversedArray;
        }

        private static int[] SubArray(int[] array, int index, int count)
        {
            int[] subArray = new int[count];
            if ((array.Length-index)>=count)
                Array.Copy(array, index, subArray, subArray[0], count);
            else if ((array.Length - index) < count)
            {
                Array.Copy(array, index, subArray, subArray[0], array.Length - index);
                int firstZeroElement = Array.FindIndex(subArray, element => element == 0);
                for (int i = firstZeroElement; i < subArray.Length; i++)
                {
                    subArray[i] = 1;
                }
            }
            return subArray;
        }


        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] array = { 3, 4, 5, 6, 7 };
            Console.WriteLine("Базовый массив:");
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }

            int[] reversedArray = MyReverse(array);

            Console.WriteLine("Инвертированный массив:");
            foreach (int element in reversedArray)
            {
                Console.WriteLine(element);
            }

            int[] reversedArrayByDefaultClass = MyReverseUsingDefaultArrayMethod(array);
            Console.WriteLine("Инвертированный массив через базовый метод:");
            foreach (int element in reversedArrayByDefaultClass)
            {
                Console.WriteLine(element);
            }

            int[] subArray = SubArray(array, 2, 3);
            Console.WriteLine("Преобразованный масив:");
            foreach (int element in subArray)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}
