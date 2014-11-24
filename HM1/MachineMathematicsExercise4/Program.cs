using System;
using System.Text;

namespace ConditionsExercise4
{
    class Program
    {
        private static string _firstString;
        private static string _secondString;
        private static string _thirdString;
        
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            _firstString = "\nмоя строка 1";
            _secondString = "\tмоя строка 2";
            _thirdString = "\aмоя строка 3";

            Console.WriteLine(_firstString);
            // Moves the cursor line
            
            Console.WriteLine(_secondString);
            //Add horizontal tab

            Console.WriteLine(_thirdString);
            // Alert

            Console.ReadKey();
        }
    }
}
