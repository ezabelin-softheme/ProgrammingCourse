using System;
using System.Text;

namespace MethodsExercise3
{
    class Program
    {
        private static string IsNumberPositive(short number)
        {
            string result;

            if (number > 0)
                result = "Введенное число - позитивное";
            else if (number < 0)
                result = "Введенное число - негативное";
            else
                result = "Введенное число 0";

            return result;
        }

        static bool IsNumberPrime(short number)
        {
            if (number < 2) 
                return false;
            for (short i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) 
                    return false;
            }
            return true;
        }

        static bool IsSpecialNumber(short number)
        {
            if ((number % 2 == 0) && (number % 3 == 0) && (number % 5 == 0) && (number % 6 == 0) && (number % 9 == 0))
                return true;
            return false;
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введите целое число");

            string enteredValue = Console.ReadLine();
            short number = Convert.ToInt16(enteredValue);

            Console.WriteLine("{0}", IsNumberPositive(number));

            bool numberType = IsNumberPrime(number);
            if (numberType)
            {
                Console.WriteLine("Введенное число - простое");
            }
            else
            {
                Console.WriteLine("Введенное число - не простое");
            }

            bool spceialNumber = IsSpecialNumber(number);
            if (spceialNumber)
            {
                Console.WriteLine("Введенное число - делится без остататка на 2, 3, 5, 6, 9");
            }
            else
            {
                Console.WriteLine("Введенное число - не делится без остататка на 2, 3, 5, 6, 9");
            }

            Console.ReadKey();
        }
    }
}
