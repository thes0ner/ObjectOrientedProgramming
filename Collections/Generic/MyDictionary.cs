using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Generic
{
    class MyDictionary<T,U>
    {

        T[] _key;
        U[] _value;

        T[] _tempKey;
        U[] _tempValue;

        //Initialy setting 0;
        public MyDictionary()
        {
            _key = new T[0];
            _value = new U[0];
        }


        public void Add(T key, U value)
        {
            //Temporary storess the new Address.
            _tempKey = _key;
            _tempValue = _value;

            //Whenever user enter value it will shrink data to right.
            _key = new T[_key.Length + 1];
            _value = new U[_value.Length + 1];


            //Assigns values to the original Array.
            for(int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
                _value[i] = _tempValue[i];
            }

            //Adding end of the arry last key and value.
            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;


        }

        public T[] Keys
        {
            get { return _key; }
        }

        public U[] Values
        {
            get { return _value; }
        }

        public int Length { get { return _key.Length; } }

    }
}
