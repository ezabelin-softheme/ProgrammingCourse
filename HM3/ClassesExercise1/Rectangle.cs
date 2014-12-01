namespace ClassesExercise1
{
    class Rectangle
    {
        private double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double Area
        {
            get { return AreaCalculator(side1, side2); }
        }

        public double Perimetr
        {
            get { return PerimeterCalculator(side1, side2); }
        }

        private double AreaCalculator(double firstSide, double secondSide)
        {
            double area = firstSide*secondSide;
            return area;
        }

        private double PerimeterCalculator(double firstSide, double secondSide)
        {
            double perimetr = (firstSide + secondSide)*2;
            return perimetr;
        }
    }
}
