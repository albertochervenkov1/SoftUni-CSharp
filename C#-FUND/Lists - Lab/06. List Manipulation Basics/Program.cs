using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            
            

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="end")
                {
                    break;
                }
                string[] command = input.Split();
                if (command[0]=="Add")
                {
                    commandAdd(nums,command);
                }
                else if (command[0]=="Remove")
                {
                    commandRemove(nums, command);
                }
                else if (command[0]=="RemoveAt")
                {
                    commandRemoveAt(nums, command);
                }
                else if (command[0]=="Insert")
                {
                    commandInsert(nums, command);
                }
            }
            Console.WriteLine(string.Join(" ", nums));

        }
        static void commandAdd(List<int> nums, string[] command)
        {
            int numberToAdd = int.Parse(command[1]);
            nums.Add(numberToAdd);
        }
        static void commandRemove(List<int> nums, string[] command)
        {
            int numberToRemove = int.Parse(command[1]);
            nums.Remove(numberToRemove);
        }
        static void commandRemoveAt(List<int> nums, string[] command)
        {
            int numberToRemove = int.Parse(command[1]);
            nums.RemoveAt(numberToRemove);

        }
        static void commandInsert(List<int> nums, string[] command)
        {
            int numberToInsert = int.Parse(command[1]);
            int index = int.Parse(command[2]);
            nums.Insert(index, numberToInsert);
        }

    }
}
