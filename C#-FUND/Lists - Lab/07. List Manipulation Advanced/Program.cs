using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool printList = false;
            while (true)
            {

                string input = Console.ReadLine();
                string[] command = input.Split();
                
                if (input == "end")
                {
                    break;
                }
                
                
                    if (command[0] == "Contains")
                    {
                        commandContains(nums, command);
                    }
                    else if (command[0] == "PrintEven")
                    {
                        commandPrintEven(nums, command);
                    }
                    else if (command[0] == "PrintOdd")
                    {
                        commandPrintOdd(nums, command);
                    }
                    else if (command[0] == "GetSum")
                    {
                        commandGetSum(nums, command);
                    }
                    else if (command[0] == "Filter")
                    {
                        commandFilter(nums, command);
                    }

                //previous task
                if (command[0] == "Add")
                {
                    commandAdd(nums, command);
                }
                else if (command[0] == "Remove")
                {
                    commandRemove(nums, command);
                }
                else if (command[0] == "RemoveAt")
                {
                    commandRemoveAt(nums, command);
                }
                else if (command[0] == "Insert")
                {
                    commandInsert(nums, command);
                }
                if (command[0]=="Add"||command[0]=="Remove"||command[0]=="RemoveAt"||command[0]=="Insert")
                {
                    printList = true;
                }
            }
            if (printList==true)
            {
                Console.WriteLine(string.Join(" ",nums));
            }
        }
        static void commandContains(List<int> nums, string[] command)
        {
            int numToContain = int.Parse(command[1]);
            if (nums.Contains(numToContain))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
        static void commandPrintEven(List<int> nums, string[] command)
        {
            List<int> nums2 = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i]%2==0)
                {
                    nums2.Add(nums[i]);
                }
            }
            Console.WriteLine(string.Join(" ", nums2));
        }
        static void commandPrintOdd(List<int> nums, string[] command) 
        {
            List<int> nums2 = new List<int>();
            for (int i = 0; i <nums.Count; i++)
            {
                if (nums[i]%2!=0)
                {
                    nums2.Add(nums[i]);
                }
            }
            Console.WriteLine(String.Join(" ", nums2));
        }
        static void commandGetSum(List<int> nums, string[] command)
        {
            int sum = nums.Sum();
            Console.WriteLine(sum);
        }
        static void commandFilter(List<int> nums, string[] command)
        {
            List<int> nums2 = new List<int>();
            int index = int.Parse(command[2]);

            if (command[1]==">")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i]>=index)
                    {
                        nums2.Add(nums[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", nums2));
            }
            
            else if (command[1]=="<")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i]<=index)
                    {
                        nums2.Add(nums[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", nums2));
            }
            else if (command[1]==">=")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] >= index)
                    {
                        nums2.Add(nums[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", nums2));
            }
            else if (command[1]=="<=")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] <= index)
                    {
                        nums2.Add(nums[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", nums2));
            }
        }

        //previous task
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
