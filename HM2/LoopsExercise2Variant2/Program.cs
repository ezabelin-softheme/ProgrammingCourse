using System;
using System.Text;

namespace LoopsExercise2Variant2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int numberOfClients = 5;
            int valueOfMarshrut = 1;

            do
            {
                valueOfMarshrut *= numberOfClients;
                numberOfClients--;
            } while (numberOfClients > 0);

            Console.WriteLine("Количество возможных вариантов доставки товара для {0} клиентов равняется {1}", numberOfClients, valueOfMarshrut);

            Console.ReadKey();
        }
    }
}
