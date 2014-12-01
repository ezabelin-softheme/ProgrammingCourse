using System;

namespace ClassesExercise7
{
    class Plane : Vehicle
    {
        private float Altitude { get; set; }
        private short PassengeQuantity { get; set; }

        public Plane(float altitude, short passengers, string coordinates, float price, float speed, string issueYear)
            : base(coordinates, price, speed, issueYear)
        {
            Altitude = altitude;
            PassengeQuantity = passengers;
        }

        public override void ShowFullInfo()
        {
            Console.WriteLine("Coordinates - {0}\nPrice - {1}\nSpeed - {2}\nYear - {3}\nAltitude - {4}\nNumber of passangers - {5}", Coordinates, Price, Speed, IssueYear, Altitude, PassengeQuantity);
        }
    }
}
