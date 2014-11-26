using System;
using System.Text;

namespace MethodsExercise1
{
    class Program
    {
        private static short _firstNumber;
        private static short _seconddNumber;

        private static float Add(int a, int b)
        {
            float result = a + b;
            return result;
        }

        private static float Sub(int a, int b)
        {
            float result = a - b;
            return result;
        }

        private static float Mul(int a, int b)
        {
            float result = a * b;
            return result;
        }

        private static float Div(int a, int b)
        {
            float result = (float) a / b;
            return result;
        }

        static void Main()
        {
            float result;

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
                    result = Add(_firstNumber, _seconddNumber);
                    Console.WriteLine("{0} + {1} = {2}", _firstNumber, _seconddNumber, result);
                    break;
                case "-":
                    result = Sub(_firstNumber, _seconddNumber);
                    Console.WriteLine("{0} - {1} = {2}", _firstNumber, _seconddNumber, result);
                    break;
                case "*":
                    result = Mul(_firstNumber, _seconddNumber);
                    Console.WriteLine("{0} * {1} = {2}", _firstNumber, _seconddNumber, result);
                    break;
                case "/":
                    if (_seconddNumber != 0)
                    {
                        result = Div(_firstNumber, _seconddNumber);
                        Console.WriteLine("{0} / {1} = {2}", _firstNumber, _seconddNumber, result);
                    }
                    else
                    {
                        Console.WriteLine("Извините, деление на 0 невозможно");
                    }
                    break;
                default:
                    Console.WriteLine("Извините, введенная операция не поддерживается");
                    break;
            }

            Console.ReadKey();
        }
    }
}
