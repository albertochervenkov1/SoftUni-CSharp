using System;

namespace izpitOleg
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 0; i < 31; i++)
            {
                double ocenka = double.Parse(Console.ReadLine());
                sum += ocenka;

            }
            sum = sum / 31;
            Console.WriteLine($"Средният успех е {sum:F2}");
            
        }
    }
}
