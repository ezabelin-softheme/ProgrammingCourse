using System;

namespace ClassesExercise3
{
    class Program
    {
        static void Main()
        {
            User newUser = new User("Big Boy", "Tom", "Cruise", 52, "November, 30");
            
            Console.WriteLine("Users form is next:\nLogin - {0}\nFirst name - {1}\nLast name - {2}\nAge - {3}\nFilling date of form - {4}", newUser.Login, newUser.Name, newUser.Surname, newUser.Age, newUser.FormFillingDate);
            Console.ReadKey();
        }
    }
}
