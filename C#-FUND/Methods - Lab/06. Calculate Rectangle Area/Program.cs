using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(calc(a,b));
            

        }
        static double calc(double a, double b)
        {
            return a * b;
        }
    }
}
