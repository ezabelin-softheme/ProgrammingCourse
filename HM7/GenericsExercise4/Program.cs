using System;

namespace GenericsExercise4
{
    class Program
    {
        static void Main()
        {
            CarCollection<Car> carCollection = new CarCollection<Car>();
            carCollection.Add(new Car
            {
                Name = "Audi",
                Year = 2008,
                Color = "Black",
                Price = 55000
            });

            carCollection.Add(new Car
            {
                Name = "Mazda",
                Year = 2012,
                Color = "White",
                Price = 30000,
            });

            carCollection.Add(new Car
            {
                Name = "Nissan",
                Year = 2011,
                Color = "Red",
                Price = 40000,
            });

            Car car = carCollection[0];
            Console.WriteLine("Information about second car from collection:");
            car.PrintCarInfo();
            Console.WriteLine("\nMy collection contains {0} car(s)", carCollection.Count);

            carCollection.Clear();
            Console.WriteLine("\nCollection has been cleared and it contains {0} cars", carCollection.Count);
            Console.ReadKey();
        }
    }
}
