using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = arr[0];
            int s = arr[1];
            int x = arr[2];
            int[] numbersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> nums = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                nums.Enqueue(numbersInput[i]);
            }
            for (int i = 0; i < s; i++)
            {
                nums.Dequeue();
            }
            if (nums.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (!nums.Any())
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(nums.Min());
            }

        }
    }
}
