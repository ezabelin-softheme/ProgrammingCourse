using System;

namespace ClassesExercise4
{
    class Converter
    {
        private double Usd { get; set; }
        private double Eur { get; set; }
        private double Rub { get; set; }
        
        public Converter(double usd, double eur, double rub)
        {
            Usd = usd;
            Eur = eur;
            Rub = rub;
        }

        public double MakeConvertationToGrivna(double ammountToChange, string currency)
        {
            double valueInGrivna = 0;
            switch (currency)
            {
                case "usd":
                    valueInGrivna = ammountToChange * Usd;
                    break;
                case "eur":
                    valueInGrivna = ammountToChange * Eur;
                    break;
                case "rub":
                    valueInGrivna = ammountToChange * Rub;
                    break;
                default:
                    Console.WriteLine("Current currency is not supported");
                    break;
            }
            return valueInGrivna;
        }

        public double MakeConvertationFromGrivna(double ammountToChange, string currency)
        {
            double newAmmount = 0;
            switch (currency)
            {
                case "usd":
                    newAmmount = ammountToChange / Usd;
                    break;
                case "eur":
                    newAmmount = ammountToChange / Eur;
                    break;
                case "rub":
                    newAmmount = ammountToChange / Rub;
                    break;
                default:
                    Console.WriteLine("Current currency is not supported");
                    break;
            }
            return newAmmount;
        }
    }
}
