using System;

namespace GenericsExercise2
{
    class Program
    {
        static void Main()
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            
            //Add new elements to dictionary
            myDictionary.Add(10, "Ben");
            myDictionary.Add(25, "Glan");
            myDictionary.Add(40, "Forest");

            //Changing value of element with key 2 inside dictionary
            myDictionary[25] = "OOO";

            Console.WriteLine("Collection contains {0} pair(s). They are:", myDictionary.Count);
            myDictionary.PrinAllElements();

            Console.ReadKey();
        }
    }
}
