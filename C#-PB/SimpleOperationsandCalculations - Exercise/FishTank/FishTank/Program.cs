using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {

            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percentinput = double.Parse(Console.ReadLine());
            double percent = percentinput / 100;

            double totalv = (lenght * width * height)/1000;
            double usedv = totalv * percent;
            double result = totalv - usedv;
            Console.WriteLine("{0:F3}", result);

        }
    }
}
