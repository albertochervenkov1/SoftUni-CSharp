using System;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            kvadrati(n);
        }
        static void kvadrati(int n)
        {
            for (int i = 1; i <=n ; i++)
            {
                Console.WriteLine(i*i);
            }
        }
    }
}
