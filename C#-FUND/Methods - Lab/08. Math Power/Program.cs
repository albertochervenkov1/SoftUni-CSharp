using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(Calc(n,power));
            

        }
        static double Calc(double n, double power)
        {
            double result = 0;
            return result = (Math.Pow(n, power));
        }
    }
}
