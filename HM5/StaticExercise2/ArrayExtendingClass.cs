using System;

namespace StaticExercise2
{
    static class ArrayExtendingClass
    {
        public static int[] SortArrayByAscending(this int[] array)
        {      
           for (int i = 0; i < array.Length; i++)
           {
               int position = 0;
               int maxValue = array[i];
               for (int j = i; j < array.Length; j++)
                   if (maxValue >= array[j])
                   { 
                       maxValue = array[j];
                       position = j;
                   }
               int g = array[i];
               array[i] = maxValue;
               array[position] = g;
           }

           return array;
        }

        public static void PrintArray(this int[] array)
        {
            Console.WriteLine("Sorted array:");

            foreach (int i in array)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
