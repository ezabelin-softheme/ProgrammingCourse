using System;

namespace ClassesExercise7
{
    class Program
    {
        static void Main()
        {
            Car car = new Car("41°24'12.2'N 2°10'26.5'E", 700, 180, "2013");
            Plane plane = new Plane(50, 180, "21°08'13.2'N 5°20'16.5'E", 100000, 1200, "2011");
            Ship ship = new Ship(500, "Odessa", "32°28'05.2'N 2°50'16.8'E", 200000, 100, "2012");

            Console.WriteLine("All information about the car:");
            car.ShowFullInfo();
            
            Console.WriteLine("\nAll information about the plane:");
            plane.ShowFullInfo();

            Console.WriteLine("\nAll information about the ship:");
            ship.ShowFullInfo();

            Console.ReadLine();
        }
    }
}
