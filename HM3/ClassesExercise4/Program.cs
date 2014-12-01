using System;

namespace ClassesExercise4
{
    class Program
    {
        static void Main()
        {
            const double ammountInGrivna = 1000;
            const double ammountInForeignCurrency = 100;

            Converter converter = new Converter(15.2, 19, 0.3);

            Console.WriteLine("{0} grn = {1:#.##} usd", ammountInGrivna, converter.MakeConvertationFromGrivna(ammountInGrivna, "usd"));
            Console.WriteLine("{0} grn = {1:#.##} eur", ammountInGrivna, converter.MakeConvertationFromGrivna(ammountInGrivna, "eur"));
            Console.WriteLine("{0} grn = {1:#.##} rub", ammountInGrivna, converter.MakeConvertationFromGrivna(ammountInGrivna, "rub"));

            Console.WriteLine("{0} usd = {1} grn", ammountInForeignCurrency, converter.MakeConvertationToGrivna(ammountInForeignCurrency, "usd"));
            Console.WriteLine("{0} usd = {1} eur", ammountInForeignCurrency, converter.MakeConvertationToGrivna(ammountInForeignCurrency, "eur"));
            Console.WriteLine("{0} usd = {1} rub", ammountInForeignCurrency, converter.MakeConvertationToGrivna(ammountInForeignCurrency, "rub"));

            Console.ReadKey();
        }
    }
}
