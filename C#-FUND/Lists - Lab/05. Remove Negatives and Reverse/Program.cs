using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums= Console.ReadLine().Split().Select(int.Parse).ToList();
           
            

            for (
                int i = 0; i <= nums.Count-1; i++)
            {
                if (nums[i]<0)
                {
                    //nums.Remove(nums[i]);
                    nums.RemoveAt(i--);
                    //if (nums[0]<0)
                    //{
                    //    i = -1;
                    //}
                    //else
                    //{
                    //  i = 0;
                    //}
                    
                    
                }
               
                            
            }
            if (nums.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                nums.Reverse();
                Console.WriteLine(String.Join(" ", nums));
                

            }
            
            
            
        }
    }
}
