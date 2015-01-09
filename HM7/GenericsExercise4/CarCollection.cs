using System;

namespace GenericsExercise4
{
    public class CarCollection<T> where T : ISpecial
    {
        private T[] _carList;
        private const int Minimum = 0;

        public CarCollection(int listLength)
        {
            _carList = new T[listLength];
        }

        public CarCollection() : this(Minimum)
        {
        }

        public T this[int i]
        {
            get { return _carList[i]; }
            set { _carList[i] = value; }
        }

        public int Count
        {
            get { return _carList.Length; }
        }

        public void Add(T element)
        {
            Array.Resize(ref _carList, _carList.Length + 1);
            _carList[_carList.Length - 1] = element;
        }

        public void Clear()
        {
            Array.Resize(ref _carList, 0);
        }
    }
}
