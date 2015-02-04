using System;
using System.Linq;

namespace Exceptions_Exercise1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter size of workers array:");
            string arraySize = Console.ReadLine();
            Worker[] allWorkers = new Worker[Convert.ToInt32(arraySize)];
            Console.WriteLine(new string('-', 25));

            for (int i = 0; i < allWorkers.Length; i++)
            {
                Worker newWorker = new Worker();
                newWorker.FillWorkerData();
                allWorkers[i] = newWorker;
            }

            allWorkers = allWorkers.OrderBy(c => c.LastNameAndInitials).ToArray();

            Console.WriteLine("Enter experience value for array sorting");
            string enteredYearsExperience = Console.ReadLine();

            for (int i = 0; i < allWorkers.Length; i++)
            {
                int workerExperience = allWorkers[i].CountExperience();
                if (workerExperience > Convert.ToInt32(enteredYearsExperience))
                {
                    Console.WriteLine(allWorkers[i].LastNameAndInitials);
                }
            }

            Console.ReadKey();
        }
    }
}
