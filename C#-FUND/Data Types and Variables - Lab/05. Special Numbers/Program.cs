using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                int digitsum = 0;
                int num = i;
                while (num > 0)
                {
                    digitsum += num % 10;
                    num /= 10;

                }
                bool isSpecial = digitsum == 5 || digitsum == 7 || digitsum == 11;

                Console.WriteLine($"{i} -> {isSpecial}");
            }


        }
    }
}
