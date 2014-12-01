using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public double LengthSide(Point A, Point B)
        {
            double length = Math.Sqrt(Math.Pow(B.coordinateX - A.coordinateY,2) + Math.Pow(B.coordinateY - A.coordinateY,2));
            return length;
        }

        public void Perim(double[] sideArray)
        {
            double perim = 0;
            int arrayLength = sideArray.Length;

            for (short i = 0; i < arrayLength - 1; i++)
            {
                perim += perim + sideArray[i];
            }

            switch (arrayLength)
            {
                case 3:
                    Console.Write("Figure is triangle. Perimetr is - {0}", perim);
                    break;
                case 4:
                    Console.Write("Figure is quadrilateral. Perimetr is - {0}", perim);
                    break;
                case 5:
                    Console.Write("Figure is pentagon. Perimetr is - {0}", perim);
                    break;
            }
        }
    }
}
