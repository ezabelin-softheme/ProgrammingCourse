using System;

namespace ClassesExercise7
{
    class Ship : Vehicle
    {
        private short PassengeQuantity { get; set; }
        private string PortName { get; set; }

        public Ship(short passengers, string portName, string coordinates, float price, float speed, string issueYear)
            : base(coordinates, price, speed, issueYear)
        {
            PassengeQuantity = passengers;
            PortName = portName;
        }

        public override void ShowFullInfo()
        {
            Console.WriteLine("Coordinates - {0}\nPrice - {1}\nSpeed - {2}\nYear - {3}\nNumber of passangers - {4}\nPort name - {5}", Coordinates, Price, Speed, IssueYear, PassengeQuantity, PortName);
        }
    }
}
