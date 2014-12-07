using System;

namespace ClassesExercise2
{
    class Figure
    {
        private Point p1, p2, p3, p4, p5;

        public Figure(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public Figure(Point p1, Point p2, Point p3, Point p4):this(p1, p2, p3)
        {
            this.p4 = p4;
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5):this(p1, p2, p3, p4)
        {
            this.p5 = p5;
        }

        public void Perim()
        {
            double perim = 0;
            double[] array;
            if(p4 == null && p5 == null)
            {
                array = new[]
                {
                    LengthSide(p1, p2),
                    LengthSide(p2, p3),
                    LengthSide(p1, p3)
                };

                CountSum(array, ref perim);
                Console.Write("Figure is triangle. Perimetr is - {0:#.##}", perim);
            }
            else if (p5 == null)
            {
                array = new[]
                {
                    LengthSide(p1, p2),
                    LengthSide(p2, p3),
                    LengthSide(p3, p4),
                    LengthSide(p1, p4)
                };

                CountSum(array, ref perim);
                Console.Write("Figure is quadrilateral. Perimetr is - {0:#.##}", perim);
            }
            else
            {
                array = new[]
                {
                    LengthSide(p1, p2),
                    LengthSide(p2, p3),
                    LengthSide(p3, p4),
                    LengthSide(p4, p5),
                    LengthSide(p1, p5)
                };

                CountSum(array, ref perim);
                Console.Write("Figure is pentagon. Perimetr is - {0:#.##}", perim);
            }
        }

        private double LengthSide(Point A, Point B)
        {
            double length = Math.Sqrt(Math.Pow(B.coordinateX - A.coordinateY, 2) + Math.Pow(B.coordinateY - A.coordinateY, 2));
            return length;
        }

        private void CountSum(double[] array, ref double perim)
        {
            for (short i = 0; i < array.Length - 1; i++)
            {
                perim += perim + array[i];
            }
        }
    }
}
