using System;
using System.Collections.Generic;
using System.Text;

namespace FootbalTeamGenerator
{
    public static class Validator
    {
        public static void ThrowException(string name,double value)
        {
            if (value<0||value>100)
            {
                throw new ArgumentException($"{name} should be between 0 and 100.");
            }
        }
    }
}
