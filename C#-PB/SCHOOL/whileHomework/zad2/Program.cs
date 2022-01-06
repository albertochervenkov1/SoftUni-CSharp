using System;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int cifra = int.Parse(Console.ReadLine());
            int currentDigit = 0;
            while (num != 0)
            {
                currentDigit = num % 10;
                num /= 10;
                if (currentDigit == cifra)
                {
                    Console.WriteLine("Yes");
                    break;
                }
                else
                {
                    Console.WriteLine("No");
                    break;
                }

            }

        }
    }
}
