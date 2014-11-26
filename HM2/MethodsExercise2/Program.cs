using System;
using System.Text;

namespace MethodsExercise2
{
    class Program
    {
        private static float ExchangeCurrency(short money, float rate)
        {
            float newMoneyAmount = money * rate;
            return newMoneyAmount;
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введите сумму денег валюты, которую нужно конвертировать");

            string enteredMoneyValue = Console.ReadLine();
            short moneyAmount = Convert.ToInt16(enteredMoneyValue);

            Console.WriteLine("Введите курс конвертации в другую валюту");

            string enteredExchangeRate = Console.ReadLine();
            float exchangeRate = Convert.ToSingle(enteredExchangeRate);

            float moneyAmountInNewCurrency = ExchangeCurrency(moneyAmount, exchangeRate);
            Console.WriteLine("Значение в новое валюте будет {0}", moneyAmountInNewCurrency);

            Console.ReadKey();
        }
    }
}
