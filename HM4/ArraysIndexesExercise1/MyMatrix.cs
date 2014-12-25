namespace ArraysIndexesExercise1
{
    class MyMatrix
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
    }
}
