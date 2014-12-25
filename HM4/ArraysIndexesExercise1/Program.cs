using System;

namespace ArraysIndexesExercise1
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            MyMatrix matrix = new MyMatrix(5, 4);

            Console.WriteLine("Matrix is: \n");

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    matrix[i, j] = random.Next(1, 100);
                    Console.Write("{0}\t",matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
