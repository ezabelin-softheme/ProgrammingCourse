using System;

namespace ArraysIndexesExercise2
{
    class Program
    {
        static void Main()
        {
            Store store = new Store(3);
            store[0] = new Article("Banana", "Silpo", 19.99);
            store[1] = new Article("Apple", "Ashan", 15.30);
            store[2] = new Article("Peach", "Fozzy", 40.50);

            try
            {
                store["Apple"].ShowInfo();
                store["Orange"].ShowInfo();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Articel with such name is absent");
            }

            Console.ReadKey();
        }
    }
}
