using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int count = 0;
            bool isEnd = false;
            while (!isEnd)
            {
                string input = Console.ReadLine();
               
                if (input=="End")
                {
                    isEnd = true;
                    continue;
                } int index = int.Parse(input);

                
                
                     if(index >= 0 && index < nums.Count)
                     {
                     
                        int tempNum = nums[index];
                        nums[index] = -1;
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (tempNum < nums[i]&&nums[i]!=-1)
                            {
                                nums[i] -= tempNum;
                                count++;
                            }
                            else if (tempNum >= nums[i]&&nums[i]!=nums[index])
                            {
                                nums[i] += tempNum;
                                count++;
                            }

                        }

                     }
                    
                
            }
            string s1 = string.Join(" ", nums);
            Console.WriteLine($"Shot targets: {count} -> " + s1);
            
        }
    }
}
