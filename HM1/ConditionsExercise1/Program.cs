using System;

namespace ConditionsExercise1
{
    class Program
    {
        private static int _operand1;
        private static int _operand2;
        private static float _result;
        static void Main()
        {
            _operand1 = 111;
            _operand2 = 55;

            Console.WriteLine("You have two numbers: {0} and {1}\nPlease enter desired operation sign!", _operand1, _operand2);
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    _result = _operand1 + _operand2;
                    Console.WriteLine("{0} + {1} = {2}", _operand1, _operand2, _result);
                    break;
                case "-":
                    _result = _operand1 - _operand2;
                    Console.WriteLine("{0} - {1} = {2}", _operand1, _operand2, _result);
                    break;
                case "*":
                    _result = _operand1 * _operand2;
                    Console.WriteLine("{0} * {1} = {2}", _operand1, _operand2, _result);
                    break;
                case "/":
                    if (_operand2 != 0)
                    {
                        _result = (float) _operand1 / _operand2;
                        Console.WriteLine("{0} / {1} = {2}", _operand1, _operand2, _result);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, division by zero is impossible");
                    }         
                    break;
                default:
                    Console.WriteLine("Sorry, entered operation is unsupported");
                    break;
            }

            Console.ReadKey();
        }
    }
}
