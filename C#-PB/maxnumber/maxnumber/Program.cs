using System;

namespace maxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int max = int.MinValue;

            while(n>count
                )
            {
                int num = int.Parse(Console.ReadLine());
                count++;
                if (num>max)
                {
                    max = num;
                }
                Console.WriteLine(max);
            }
        }
    }
}
