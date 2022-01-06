using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            printTriangle(n);
        }
        static void printTriangle(int n)
        {
            for (int i = 1; i <= n ; i++)
            {
                printFrom1(i);
            }
            for (int i = n-1; i > 0; i--)
            {
                printFrom1(i);
            }
        }
        static void printFrom1(int to)
        {
            for (int i = 1; i <= to ; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
