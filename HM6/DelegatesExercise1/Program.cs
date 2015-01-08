using System;

namespace DelegatesExercise1
{
    class Program
    {
        public delegate double Cualculator(int x, int y);

        static void Main()
        {
            Cualculator add = (x, y) => x + y;
            Cualculator sub = (x, y) => x - y;
            Cualculator mul = (x, y) => x * y;
            Cualculator div = (x, y) =>
            {
                if (y != 0)
                {
                    return (double) x/y;
                }
                return -1;
            };

            Console.WriteLine("Enter first number:");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int secondValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter sign of operation:");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine("Result of sum is {0}", add(firstValue, secondValue));
                    break;
                case "-":
                    Console.WriteLine("Result of subtraction is {0}", sub(firstValue, secondValue));
                    break;
                case "*":
                    Console.WriteLine("Result of multiplication is {0}", mul(firstValue, secondValue));
                    break;
                case "/":
                    double result = div(firstValue, secondValue);
                    if (result > 0)
                    {
                        Console.WriteLine("Result of division is {0}", result);
                    }
                    else
                    {
                        Console.WriteLine("Impossible to delete on 0");
                    }
                    break;
                default:
                    Console.WriteLine("Entered operation is not supported");
                    break;
            }

            Console.ReadKey();     
        }
    }
}
