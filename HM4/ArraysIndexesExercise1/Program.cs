using System;

namespace ArraysIndexesExercise1
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            MyMatrix matrix = new MyMatrix(2, 4);

            Console.WriteLine("Matrix is: \n");

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    matrix[i, j] = random.Next(1, 100);
                }
            }

            matrix.PrintMatrix();

            matrix.AddColumn();
            for (int i = 0; i < matrix.Rows; i++)
            {
                matrix[i, matrix.Columns - 1] = random.Next(1, 100);
            }

            Console.WriteLine("\nNew matrix with 1 added column is: \n");
            matrix.PrintMatrix();

            matrix.AddRow();
            for (int i = 0; i < matrix.Columns; i++)
            {
                matrix[matrix.Rows - 1, i] = random.Next(1, 100);
            }

            Console.WriteLine("\nNew matrix with 1 added row is: \n");
            matrix.PrintMatrix();

            matrix.DeleteRow();
            Console.WriteLine("\nNew matrix with 1 deleted row is: \n");
            matrix.PrintMatrix();

            matrix.DeleteColumn();
            Console.WriteLine("\nNew matrix with 1 deleted row is: \n");
            matrix.PrintMatrix();

            Console.WriteLine("\nTrying to delete all rows in matrix");
            matrix.DeleteRow();
            Console.WriteLine("1 row has been deleted, matrix is:");
            matrix.PrintMatrix();
            matrix.DeleteRow();

            Console.ReadKey();
        }
    }
}
