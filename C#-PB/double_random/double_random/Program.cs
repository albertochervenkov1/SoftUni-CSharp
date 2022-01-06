using System;

namespace double_random
{
    class Program
    {
        static void Main(string[] args)
        {
            //double maximum = 15.8;
            //double minimum = 9.9;
            //Random random = new Random();
            //random.NextDouble() * (maximum - minimum) + minimum;
        }

            public class RandomNumbers : Random
        {
            public RandomNumbers(int seed) : base(seed) { }

            public double NextDouble(double minimum, double maximum)
            {
                return base.NextDouble() * (maximum - minimum) + minimum;
            }
        }


    }
    
}
