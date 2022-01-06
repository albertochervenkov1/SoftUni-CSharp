using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> periodicTable = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < input.Length; j++)
                {
                    periodicTable.Add(input[j]);
                }
            }
            var sorted=periodicTable.OrderByDescending(k => k).Reverse().ToArray();
            Console.WriteLine(string.Join(" ",sorted));
        }
    }
}
