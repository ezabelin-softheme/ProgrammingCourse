using System;

namespace ClassesExercise3
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        private readonly DateTime FormFillingDate;

        public User(string login, string name, string surname, byte age)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            FormFillingDate = DateTime.UtcNow;
        }

        public override string ToString()
        {
            return string.Format("Users form is next:\nLogin - {0}\nFirst name - {1}\nLast name - {2}\nAge - {3}\nFilling date of form - {4}",
                    Login, Name, Surname, Age, FormFillingDate);
        }
    }
}
