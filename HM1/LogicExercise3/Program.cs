using System;

namespace LogicExercise3
{
    class Program
    {
        static void Main()
        {
            const short zarplata = 2000;
            byte procent;
            float bonus;

            Console.WriteLine("Enter value of years:");
            string eneteredYearsValue = Console.ReadLine();
            short vuslyga = Convert.ToInt16(eneteredYearsValue);

            if (vuslyga > 0 && vuslyga < 5)
            {
                procent = 10;
                bonus = CalculateBonus(zarplata, procent);
                Console.WriteLine("Bonus will be " + bonus);
            }
            else if (vuslyga >= 5 && vuslyga < 10)
            {
                procent = 15;
                bonus = CalculateBonus(zarplata, procent);
                Console.WriteLine("Bonus will be " + bonus);
            }
            else if (vuslyga >= 10 && vuslyga < 15)
            {
                procent = 25;
                bonus = CalculateBonus(zarplata, procent);
                Console.WriteLine("Bonus will be " + bonus);
            }
            else if (vuslyga >= 15 && vuslyga < 20)
            {
                procent = 35;
                bonus = CalculateBonus(zarplata, procent);
                Console.WriteLine("Bonus will be " + bonus);
            }
            else if (vuslyga >= 20 && vuslyga < 25)
            {
                procent = 45;
                bonus = CalculateBonus(zarplata, procent);
                Console.WriteLine("Bonus will be " + bonus);
            }
            else if (vuslyga >= 25)
            {
                procent = 50;
                bonus = CalculateBonus(zarplata, procent);
                Console.WriteLine("Bonus will be " + bonus);
            }

            Console.ReadKey();
        }

        static float CalculateBonus(short zarplata, byte procent)
        {
            float bonus = (float)(zarplata * procent) / 100;
            return bonus;
        }
    }
}
