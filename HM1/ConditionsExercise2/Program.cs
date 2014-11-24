using System;

namespace ConditionsExercise2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter any number");

            string enteredValue = Console.ReadLine();

            short number = Convert.ToInt16(enteredValue);

            if (number >= 0 && number <= 14)
            {
                Console.WriteLine("The range is [0-14]");
            }
            else if (number >= 14 && number <= 35)
            {
                Console.WriteLine("The range is [15-35]");
            }
            else if (number >= 36 && number <= 50)
            {
                Console.WriteLine("The range is [36-50]");
            }
            else if (number >= 51 && number <= 100)
            {
                Console.WriteLine("The range is [51-100]");
            }
            else
            {
                Console.WriteLine("Entered value is out of any allowable range");
            }
        }
    }
}
