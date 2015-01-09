using System;

namespace GenericsExercise1and3
{
    public static class ExtraClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }
            return array;
        }

        public static void PrintArray<T>(this T[] array)
        {
            foreach (var element in array)
            {
                Console.Write("{0} ", element);
            }
        }
    }
}
