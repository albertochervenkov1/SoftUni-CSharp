using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Nmbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            double sum = nums.Sum();
            double average = sum / nums.Count;
            //Console.WriteLine(average);
            List<int> newNums = new List<int>();
            bool averageYes = false;

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i]>average)
                {

                    newNums.Add(nums[i]);
                    averageYes = true;
                }
               
                
            }
            if (averageYes==false)
            {
                Console.WriteLine("No");
                return;
            }
           
            
            //newNums.Sort();
            //newNums.Reverse();
           
           
            if (newNums.Count>5)
            {
                newNums.Sort();
                newNums.Reverse();
                foreach (int topn in newNums.Take(5))
                {
                    Console.Write(topn+" ");
                }
            }
           
            else
            {
                newNums.Sort();
                newNums.Reverse();
                Console.WriteLine(string.Join(" ",newNums));
            }
            
            
        }
    }
}
