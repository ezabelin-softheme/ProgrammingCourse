using System;

namespace ClassesExercise7
{
    class Vehicle
    {
        protected string Coordinates { get; set; }
        protected float Price { get; set; }
        protected float Speed { get; set; }
        protected string IssueYear { get; set; }

        protected Vehicle(string coordinates, float price, float speed, string issueYear)
        {
            Coordinates = coordinates;
            Price = price;
            Speed = speed;
            IssueYear = issueYear;
        }

        public virtual void ShowFullInfo()
        {
            Console.WriteLine("Coordinates - {0}\nPrice - {1}\nSpeed - {2}\nYear - {3}", Coordinates, Price, Speed, IssueYear);
        }
    }
}
