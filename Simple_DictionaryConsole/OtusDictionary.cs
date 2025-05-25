using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_DictionaryConsole
{
    internal class OtusDictionary
    {
        private int _version;
        private int _size;
        private int[] keys;
        private string[] stringValues;
        public int Lenght => _lenght;
        private int _lenght;

        public OtusDictionary()
        {
            _size = 2;
            _version = 0;
            keys = new int[2];
            stringValues = new string[2];
            _lenght = 0;
        }
        public OtusDictionary(int size)
        {
            if (size < 0)
            {
                throw new ArgumentOutOfRangeException("size: " + size);
            }
            _size = size;
            _version = 0;
            keys = new int[size];
            stringValues = new string[size];
            _lenght = 0;
        }
        public void Add(int key, string stringValue)
        {
            if(stringValue is null)
            {
                throw new ArgumentNullException("StringValue can't be null.");
            }

            _lenght++;
            if (_lenght >= _size)
            {
                IncreaseDictionarySize();
            }
            
            keys[_lenght] = key;
            stringValues[_lenght] = stringValue;
        }
        private void IncreaseDictionarySize()
        {
            if (_size == 0)
            {
                _size = 2;
            }
            else
            {
                try
                {
                    _size *= 2;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            Array.Resize(ref keys, _size);
            Array.Resize(ref stringValues, _size);
        }
        public string GetFirstStringByKey(int key)
        {
            for (int i = 0; i < _lenght; i++)
            {
                if (keys[i] == key) return stringValues[i];
            }
            throw new ValueNotFoundExeption($"StringValue of key {key} not found.");
        }
    }
}
