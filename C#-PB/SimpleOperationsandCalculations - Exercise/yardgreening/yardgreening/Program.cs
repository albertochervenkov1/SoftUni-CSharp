using System;

namespace yardgreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double sq = double.Parse(Console.ReadLine());
            double pricesq = sq * 7.61;
            double ot = pricesq * 0.18;
            double total = pricesq - ot;
            

            Console.WriteLine($"The final price is: {total:F2} lv.");
            Console.WriteLine($"The discount is: {ot:F2} lv.");

        }
    }
}
