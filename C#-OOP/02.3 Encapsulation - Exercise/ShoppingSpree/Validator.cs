using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public static class Validator
    {
        public static void ThrowIfStringIsNullOrEmpty(string str,string message)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException(message);
            }
        }
        public static void ThrowIfValueIsNegative(decimal value,string message)
        {
            if (value<0)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
