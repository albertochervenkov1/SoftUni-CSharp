using System;
using System.Collections.Generic;

namespace SwapInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<double>> list = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                Box<double> input = new Box<double>(double.Parse(Console.ReadLine()));
                list.Add(input);
            }
            double value = double.Parse(Console.ReadLine());
            Box<double> boxValue = new Box<double>(value);
            //GetGreater(list, boxValue);
            Console.WriteLine(GetGreater(list, boxValue));
        }
        private static int GetGreater<T>(List<Box<T>> boxes, Box<T> box)
            where T : IComparable
        {
            int count = 0;
            foreach (var item in boxes)
            {
                int compare = item.Value.CompareTo(box.Value);
                if (compare > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
