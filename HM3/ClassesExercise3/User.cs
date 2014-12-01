namespace ClassesExercise3
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public readonly string FormFillingDate;

        public User(string login, string name, string surname, byte age, string formFillingDate)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            FormFillingDate = formFillingDate;
        }
    }
}
