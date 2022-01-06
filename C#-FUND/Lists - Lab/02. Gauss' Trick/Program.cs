using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();
            int length = nums.Count/2;
            
            for (int i = 0; i <length; i++)
            {
                nums[i] +=nums[nums.Count-1];              
                nums.RemoveAt(nums.Count-1);
               
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
