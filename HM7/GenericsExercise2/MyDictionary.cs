using System;

namespace GenericsExercise2
{
    public class MyDictionary<TKey, TValue>
    {
        private TKey[] _key;
        private TValue[] _value;
        private const int Minimum = 0;

        public MyDictionary(int listLength)
        {
            _key = new TKey[listLength];
            _value = new TValue[listLength];
        }

        public MyDictionary()
            : this(Minimum)
        {
        }

        public TValue this[TKey key]
        {
            get
            {
                TValue resultValue = default(TValue);
                for (int i = 0; i < _key.Length; i++)
                {
                    if (_key[i].ToString() == key.ToString())
                    {
                        resultValue = _value[i];
                        return resultValue;
                    }
                }
                return resultValue;
            }
            set
            {
                for (int i = 0; i < _key.Length; i++)
                {
                    if (_key[i].ToString() == key.ToString())
                    {
                        _value[i] = value;
                    }
                }
            }
        }

        public int Count
        {
            get { return _key.Length; }
        }

        public void Add(TKey keyElement, TValue valueElement)
        {
            Array.Resize(ref _key, _key.Length + 1);
            _key[_key.Length - 1] = keyElement;
            Array.Resize(ref _value, _value.Length + 1);
            _value[_value.Length - 1] = valueElement;
        }

        public void PrinAllElements()
        {
            for (int i = 0; i < _key.Length; i++)
            {
                Console.WriteLine("{0}  {1}", _key[i], _value[i]);
            }
        }
    }
}
