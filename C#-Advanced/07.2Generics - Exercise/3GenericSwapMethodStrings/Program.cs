using System;
using System.Collections.Generic;
using System.Linq;

namespace _3GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> list = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                Box<string> input = new Box<string>(Console.ReadLine());
                list.Add(input);
            }
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SwapIndexes(list, indexes[0], indexes[1]);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
        private static void SwapIndexes<T>(List<Box<T>> boxes, int firstIndex, int secondIndex) 
        {
            Box<T> temp = boxes[firstIndex];
            boxes[firstIndex] = boxes[secondIndex];
            boxes[secondIndex] = temp;
        }
    }
}
