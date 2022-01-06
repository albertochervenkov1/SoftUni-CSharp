using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int ditancemeters = int.Parse(Console.ReadLine());

            double km = ditancemeters * 0.001;
            Console.WriteLine($"{km:F2}");
                
        }
    }
}
