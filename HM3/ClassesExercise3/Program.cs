using System;

namespace ClassesExercise3
{
    class Program
    {
        static void Main()
        {
            User newUser = new User("Big Boy", "Tom", "Cruise", 52);

            Console.WriteLine(newUser.ToString());
            Console.ReadKey();
        }
    }
}
