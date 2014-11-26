using System;
using System.Text;

namespace LoopsExercise1
{
    class Program
    {

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            const int a = 4;
            const int b = 6;

            int sum = 0;

            for (short i = a + 1; i < b; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("Сумма целых числе между {0} и {1} = {2}", a, b, sum);
            Console.WriteLine("Список всех нечетных целых чисел, расположенных между {0} и {1}:", a, b);

            for (short i = a + 1; i < b; i++)
            {
                if ((i & 1) == 1)
                {
                    Console.WriteLine("{0}", i);
                }
            }

            Console.ReadKey();
        }
    }
}
