using System;

namespace ArraysIndexesExercise1
{
    internal class MyMatrix
    {
        private int[,] matrix;
        public int Rows { get; set; }
        public int Columns { get; set; }

        public MyMatrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            matrix = new int[Rows, Columns];
        }

        public int this[int index1, int index2]
        {
            get { return matrix[index1, index2]; }
            set { matrix[index1, index2] = value; }
        }

        public void AddRow()
        {
            Rows = Rows + 1;
            CopyMatrix(Rows - 1, Columns);
        }

        public void DeleteRow()
        {
            if (Rows != 1)
            {
                Rows = Rows - 1;
                CopyMatrix(Rows, Columns);
            }
            else
            {
                Console.WriteLine("Sorry, impossible to delete single row of matrix"); 
            }
        }

        public void AddColumn()
        {
            if (Columns != 1)
            {
                Columns = Columns + 1;
                CopyMatrix(Rows, Columns - 1);
            }
            else
            {
                Console.WriteLine("Sorry, impossible to delete single column of matrix");
            }
        }

        public void DeleteColumn()
        {
            Columns = Columns - 1;
            CopyMatrix(Rows, Columns);
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private void CopyMatrix(int rowsNumber, int columnsNumber)
        {
            var newMatrix = new int[Rows, Columns];
            for (int i = 0; i < rowsNumber; i++)
            {
                for (int j = 0; j < columnsNumber; j++)
                {
                    newMatrix[i, j] = matrix[i, j];
                }
            }
            matrix = newMatrix;
        }
    }
}
