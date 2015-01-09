using System;

namespace GenericsExercise4
{
    public class Car : ISpecial
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public short Year { get; set; }
        public int Price { get; set; }

        public void PrintCarInfo()
        {
            Console.WriteLine("Name - {0}\nColor - {1}\nYear of issue - {2}\nPrice - {3}", Name, Color, Year, Price);
        }
    }
}
