using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public static class Validator
    {
        public static void ThrowIfStringIsNullOrEmpty(string str, string message) 
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException(message);
            }
        }
        public static void ThrowIfNumberIsNegative(decimal number, string message)
        {
            if (number<0)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
