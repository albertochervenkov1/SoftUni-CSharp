using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SignOfInt();
        }
        static void SignOfInt() 
        {
            int n = int.Parse(Console.ReadLine());

            if (n>0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n<0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else if (n==0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}
