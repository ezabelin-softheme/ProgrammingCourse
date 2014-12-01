using System;
using System.Text;

namespace ClassesExercise1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введите длину первой стороны прямоугольника");

            string enteredFirstValue = Console.ReadLine();
            double firstSideLength = Convert.ToDouble(enteredFirstValue);

            Console.WriteLine("Введите длину второй стороны прямоугольника");

            string enteredSecondValue = Console.ReadLine();
            double secondSideLength = Convert.ToDouble(enteredSecondValue);

            Rectangle rectangle = new Rectangle(firstSideLength, secondSideLength);

            Console.WriteLine("Площадь прямоугольника - {0}", rectangle.Area);
            Console.WriteLine("Периметр прямоугольника - {0}", rectangle.Perimetr);

            Console.ReadKey();
        }
    }
}
