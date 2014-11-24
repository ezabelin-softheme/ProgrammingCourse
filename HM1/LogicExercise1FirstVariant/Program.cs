using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicExercise1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            const int enteredValue = 9;
            string binaryNumber = Convert.ToString(enteredValue, 2);

            string lastElement = binaryNumber.Substring(binaryNumber.Length - 1);

            switch (lastElement)
            {
                case ("1"):
                    Console.WriteLine("Число {0} - нечетное", enteredValue);
                    break;
                case ("0"):
                    Console.WriteLine("Число {0} - четное", enteredValue);
                    break;
            }

            Console.ReadKey();
        }
    }
}
