using System;
using System.Text;

namespace ArraysExercise1
{
    class Program
    {
        private static short FindMaxNumberInArray(short[] array)
        {
            short maxValue = array[0];

            for (short i = 0; i < array.Length; i++)
            {
                if (maxValue < array[i])
                {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }

        private static short FindMinNumberInArray(short[] array)
        {
            short minValue = array[0];

            for (short i = 0; i < array.Length; i++)
            {
                if (minValue > array[i])
                {
                    minValue = array[i];
                }
            }

            return minValue;
        }

        private static float GetArithmeticMean(short[] array)
        {
            short arraySum = 0;

            for (short i = 0; i < array.Length; i++)
            {
                arraySum += array[i];
            }

            float arithmeticMean = (float) arraySum/array.Length;
            return arithmeticMean;
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введите размер массива");

            string enteredArrayLengthValue = Console.ReadLine();
            short number = Convert.ToInt16(enteredArrayLengthValue);

            Console.WriteLine("Введите элементы массива по-одному, используя Enter:");
            short[] array = new short[number];

            for (short i = 0; i < number; i++)
            {
                string enteredValue = Console.ReadLine();
                short value = Convert.ToInt16(enteredValue);
                array[i] = value;
            }

            Console.WriteLine("Максимальное значение массива - {0}", FindMaxNumberInArray(array));
            Console.WriteLine("Минимальное значение массива - {0}", FindMinNumberInArray(array));
            Console.WriteLine("Среднее арифметическое значение массива - {0}", GetArithmeticMean(array));
            Console.WriteLine("Список всех нечетных значений массива:");
            for (short i = 0; i < array.Length; i++)
            {
                if(array[i]%2 == 1)
                    Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
