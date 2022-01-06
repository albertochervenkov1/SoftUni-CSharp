using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = "";

            while (true)
            {
                input = Console.ReadLine();//52 74 23 44 96 110
                string[] command = input.Split();
                if (input=="End")
                {
                    break;
                }
                if (command[0]=="Shoot")
                {
                    commandShoot(nums, command);
                    
                }
                else if (command[0]=="Add")
                {
                    commandAdd(nums, command);
                }
                else if (command[0]=="Strike")
                {
                    commandStrike(nums, command);
                }
                
            }
            Console.WriteLine(string.Join("|",nums));
        }
        static void commandShoot(List<int> nums, string[] command)
        {
            int index = int.Parse(command[1]);
            int damage = int.Parse(command[2]);
            if (index > 0 && index <nums.Count)
            {
                nums[index] -= damage;
                if (nums[index]<=0)
                {
                    nums.RemoveAt(index);
                }

            }
            
        }
        static void commandAdd(List<int> nums, string[] command)
        {
            int index = int.Parse(command[1]);
            int value = int.Parse(command[2]);

            if (index>=0&&index<nums.Count)
            {
                nums.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
        }
        static void commandStrike(List<int> nums, string[] command)
        {
            int index = int.Parse(command[1]);
            int range = int.Parse(command[2]);
           

            if (index - range >= 0 && index + range < nums[nums.Count - 1])
            {
                nums.RemoveRange(index - range, range * 2 + 1);
            }
            else
            {
                Console.WriteLine($"Strike missed!");
            }
        }
    }
}
