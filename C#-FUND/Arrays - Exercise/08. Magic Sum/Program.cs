using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < nums.Length-1; i++)
            {
                int currentNumber = nums[i];
                for (int j = i+1; j < nums.Length; j++)
                {
                    
                    if (nums[j]+currentNumber==n)
                    {
                        Console.WriteLine($"{currentNumber} {nums[j]}");
                    }
                }

            }
        }
    }
}
