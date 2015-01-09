using System;

namespace GenericsExercise1and3
{
    class Program
    {
        static void Main()
        {
            MyList<int> myListWithInt = new MyList<int>();
            myListWithInt.Add(2);
            myListWithInt.Add(4);
            myListWithInt.Add(8);
            myListWithInt.Add(15);
            myListWithInt[3] = 16;

            MyList<string> myListWithStrings = new MyList<string>(2);
            myListWithStrings[0] = "First";
            myListWithStrings[1] = "Second";
            myListWithStrings.Add("Third");
            
            Console.WriteLine("First list contains {0} element(s). They are:", myListWithInt.Count);
            myListWithInt.GetArray().PrintArray();

            Console.WriteLine("\nSecond list contains {0} element(s). They are:", myListWithStrings.Count);
            myListWithStrings.GetArray().PrintArray();

            Console.ReadKey();
        }
    }
}
