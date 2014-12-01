
using System;

namespace ClassesExercise2
{
    class Program
    {
        static void Main()
        {
            Point point1 = new Point(2, 4, "Point 1");
            Point point2 = new Point(3, 5, "Point 2");
            Point point3 = new Point(4, 6, "Point 3");
            Point point4 = new Point(4, 6, "Point 3");

            Figure figure = new Figure(point1, point2, point3, point4);
            double firstLine = figure.LengthSide(point1, point2);
            double secondLine = figure.LengthSide(point2, point3);
            double thirdLine = figure.LengthSide(point3, point4);
            double fourthLine = figure.LengthSide(point1, point4);

            double[] array = { firstLine, secondLine, thirdLine, fourthLine};
            figure.Perim(array);

            Console.ReadKey();
        }
    }
}
