using System;

namespace GenericsExercise1and3
{
    public class MyList<T>
    {
        private T[] _list;
        private const int Minimum = 0;

        public MyList(int listLength)
        {
            _list = new T[listLength];
        }

        public MyList() : this(Minimum)
        {
        }

        public T this[int i]
        {
            get { return _list[i]; }
            set { _list[i] = value; }
        }

        public int Count
        {
            get { return _list.Length; }
        }

        public void Add(T element)
        {
            Array.Resize(ref _list, _list.Length + 1);
            _list[_list.Length - 1] = element;
        }
    }
}
