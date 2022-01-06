using System;

namespace dancehall
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());

            double totalareahall = (l * 100) * (w * 100);
            double wardrobe = a * 100;
            double totwardrobe = (wardrobe * wardrobe);
            double sizepench = totalareahall / 10;
            double free = totalareahall - totwardrobe - sizepench;
            double numdancers = free / (40 + 7000);

            Console.WriteLine(Math.Round(numdancers));

        }
    }
}
