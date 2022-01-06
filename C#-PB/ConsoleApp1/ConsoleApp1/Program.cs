using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > 12)
            {
                Console.WriteLine("true");
            }
            else if (b > 12)
            {
                Console.WriteLine("true");

            }
            else if (c > 12)
            {
                Console.WriteLine("true");

            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
