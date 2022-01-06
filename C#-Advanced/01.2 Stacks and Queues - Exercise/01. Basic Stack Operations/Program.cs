using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
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
            Stack<int> nums = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                nums.Push(numbersInput[i]);
            }
            for (int i = 0; i < s; i++)
            {
                nums.Pop();
            }
            bool isFound = nums.Contains(x);
            
            
            if (isFound==true)
            {
                Console.WriteLine("true");
            }
            else if (!nums.Any())
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(nums.Min());
            }
        }
    }
}
