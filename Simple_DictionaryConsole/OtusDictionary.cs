using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Simple_DictionaryConsole
{
    internal class OtusDictionary
    {
        private int _size;
        private int[] keys;
        private string[] stringValues;
        public int Lenght => _size;

        public OtusDictionary()
        {
            _size = 2;
            keys = new int[2];
            stringValues = new string[2];
        }
        public OtusDictionary(int size)
        {
            if (size < 1)
            {
                throw new ArgumentOutOfRangeException("size: " + size);
            }
            _size = size;
            keys = new int[size];
            stringValues = new string[size];
        }

        /// <summary>
        /// Indexater
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public (int, string) this[int i]
        {
            get
            {
                if (i < 0 || i >= _size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return (keys[i], stringValues[i]);
            }
        }
        public void Add(int key, string stringValue)
        {
            if (stringValue is null)
            {
                throw new ArgumentNullException("StringValue can't be null.");
            }

            //keys[key % _size] чтобы не было 100 % 10 и 1000 % 10, как одинаковые индексы
            if (stringValues[key % _size] is null || keys[key % _size] == key)
            {
                stringValues[key % _size] = stringValue;
                keys[key % _size] = key;
            }
            else
            {
                IncreaseDictionarySize();
                Add(key, stringValue);
            }
        }
        private void IncreaseDictionarySize()
        {
            int tempsize = _size;
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

            int[] tempKeys = keys;
            string[] tempStringValues = stringValues;

            keys = new int[_size];
            stringValues = new string[_size];

            for (int i = 0; i < tempsize; i++)
            {
                if (stringValues[i % _size] != null)
                {
                    Add(tempKeys[i], tempStringValues[i]);
                }
            }
        }
        public string Get(int key)
        {
            //Сравниваем в keys[key % _size] c key, чтобы не было 10 и 100 одинаковые значения
            if (key % _size >= 0 && keys[key % _size] == key && stringValues[key % _size] != null)
            {
                return stringValues[key % _size];
            }
            throw new ValueNotFoundExeption($"StringValue of key {key} not found.");
        }
    }
}
