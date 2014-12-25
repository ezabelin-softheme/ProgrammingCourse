namespace ArraysIndexesExercise2
{
    class Store
    {
        private readonly Article[] _products;

        public Store(int num)
        {
            _products = new Article[num];
        }

        public Article this[int index]
        {
            get { return _products[index]; }
            set { _products[index] = value; }
        }

        public Article this[string articelName]
        {
            get
            {
                for (int i = 0; i < _products.Length; i++)
                {
                    if (_products[i].Name == articelName)
                    {
                        return _products[i];
                    }
                }
                return null;
            }
        }
    }
}
