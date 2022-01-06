using System;
using System.Collections.Generic;
using System.Linq;

namespace SwapInteger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<int>> list = new List<Box<int>>();

            for (int i = 0; i < n; i++)
            {
                Box<int> input = new Box<int>(int.Parse(Console.ReadLine()));
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

