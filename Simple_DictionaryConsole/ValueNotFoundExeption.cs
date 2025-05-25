using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_DictionaryConsole
{
    internal class ValueNotFoundExeption : Exception
    {
        public ValueNotFoundExeption(string? message) : base(message)
        {

        }

        public ValueNotFoundExeption(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
