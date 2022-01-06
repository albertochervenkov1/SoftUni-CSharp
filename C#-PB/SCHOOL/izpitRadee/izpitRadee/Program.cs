using System;

namespace izpitRadee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = -6;
            int counter = 0;
            while (n<0)
            {
                Console.WriteLine(n);
                n += 2;
                counter++;
            }
            
            Console.WriteLine(counter);

        }
    }
}
