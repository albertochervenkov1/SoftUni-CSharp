using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var sortedDictionary = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (sortedDictionary.ContainsKey(num))
                {
                    sortedDictionary[num]++;
                }
                else
                {
                    sortedDictionary.Add(num,1);
                }
            }
            
            foreach (var item in sortedDictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
