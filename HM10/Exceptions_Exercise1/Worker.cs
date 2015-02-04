using System;
using System.Globalization;

namespace Exceptions_Exercise1
{
    public struct Worker
    {
        public string LastNameAndInitials { get; set; }
        public string Vacancy { get; set; }
        public DateTime DataEntry { get; set; }

        public void FillWorkerData()
        {
            string format = "mm-dd-yyyy";

            Console.WriteLine("Enter worker's last name and initials");
            LastNameAndInitials = Console.ReadLine();

            Console.WriteLine("Enter worker's vacancy");
            Vacancy = Console.ReadLine();

            Console.WriteLine("Enter worker's data entry");
            string enteredData = Console.ReadLine();
            try
            {
                DateTime temporaryData;
                bool isFormatCorrect = DateTime.TryParseExact(enteredData, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out temporaryData);
                if (!isFormatCorrect)
                {
                    throw new IncorrectDataFormatException("Incorrect data format. Should be mm-dd-yyyy");
                }
                DataEntry = temporaryData;
            }
            catch (IncorrectDataFormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.WriteLine(new string('-',25));
        }

        public int CountExperience()
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime nowDate = DateTime.Now;
            TimeSpan result = nowDate.Subtract(DataEntry);
            int years = (zeroTime + result).Year - 1;
            return years;
        }
    }
}
