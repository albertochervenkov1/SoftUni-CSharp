﻿using System;

namespace _08._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string cityName = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            double area=double.Parse(Console.ReadLine());

            Console.WriteLine($"Town {cityName} has population of {population} and area {area} square km.");

            
        }
    }
}
