using System;
using System.Text;

namespace LoopsExercise2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            const int numberOfClients = 5;
            int valueOfMarshrut = 1;
            int counter = 1;

            do
            {
                valueOfMarshrut *= counter;
                counter++;
            } while (counter <= numberOfClients);

            Console.WriteLine("Количество возможных вариантов доставки товара для {0} клиентов равняется {1}", numberOfClients, valueOfMarshrut);

            Console.ReadKey();
        }
    }
}
