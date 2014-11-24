using System;
using System.Text;

namespace LogicExercise1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введите любой целое число:");

            string enteredNumber = Console.ReadLine();
            short number = Convert.ToInt16(enteredNumber);
            
            if ((number & 1) == 0)
                Console.WriteLine("Число {0} - четное", number);
            else
                Console.WriteLine("Число {0} - нечетное", number); 

            Console.ReadKey();
        }
    }
}
