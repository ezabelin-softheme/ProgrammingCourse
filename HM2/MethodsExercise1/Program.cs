using System;
using System.Text;

namespace MethodsExercise1
{
    class Program
    {
        private static short _firstNumber;
        private static short _seconddNumber;

        private static string Add(int a, int b)
        {
            float result = a + b;
            return string.Format("{0} + {1} = {2}", a, b, result);
        }

        private static string Sub(int a, int b)
        {
            float result = a - b;
            return string.Format("{0} - {1} = {2}", _firstNumber, _seconddNumber, result);
        }

        private static string Mul(int a, int b)
        {
            float result = a * b;
            return string.Format("{0} * {1} = {2}", _firstNumber, _seconddNumber, result);
        }

        private static string Div(int a, int b)
        {
            if (b != 0)
            {
                float result = (float)a / b;
                return string.Format("{0} / {1} = {2}", _firstNumber, _seconddNumber, result);
            }

            return "Извините, деление на 0 невозможно";
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введите первое число");

            string firstEnteredNumber = Console.ReadLine();
            _firstNumber = Convert.ToInt16(firstEnteredNumber);

            Console.WriteLine("Введите второе число");

            string secondEnteredNumber = Console.ReadLine();
            _seconddNumber = Convert.ToInt16(secondEnteredNumber);

            Console.WriteLine("Введите знак операции над числами");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine(Add(_firstNumber, _seconddNumber));
                    break;
                case "-":
                    Console.WriteLine(Sub(_firstNumber, _seconddNumber));
                    break;
                case "*":
                    Console.WriteLine(Mul(_firstNumber, _seconddNumber));
                    break;
                case "/":
                    Console.WriteLine(Div(_firstNumber, _seconddNumber));
                    break;
                default:
                    Console.WriteLine("Извините, введенная операция не поддерживается");
                    break;
            }

            Console.ReadKey();
        }
    }
}
