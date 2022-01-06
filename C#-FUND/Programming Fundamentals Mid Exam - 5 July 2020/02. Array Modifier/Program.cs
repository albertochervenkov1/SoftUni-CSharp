using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="end")
                {
                    break;
                }
                string[] command = input.Split();
                if (command[0]=="swap")
                {
                    int firstIndex = int.Parse(command[1]);
                    int secondIndex = int.Parse(command[2]);
                    
                    int temp = nums[firstIndex];
                    nums[firstIndex] = nums[secondIndex];
                    nums[secondIndex] = temp;
                }
                else if (command[0]=="multiply")
                {
                    int firstIndex = int.Parse(command[1]);
                    int secondIndex = int.Parse(command[2]);

                    int num1 = nums[firstIndex];
                    int num2 = nums[secondIndex];
                    int multiply = num1 * num2;
                    nums[firstIndex] = multiply;
                    //nums.Remove(secondIndex);

                }
                else if (command[0]=="decrease")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        nums[i]--;
                    }
                }
            }
            Console.WriteLine(string.Join(", ",nums));
        }
    }
}
