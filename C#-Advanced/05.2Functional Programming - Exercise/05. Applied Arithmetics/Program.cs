using System;
using System.Collections.Generic;
using System.Linq;
namespace _0.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            Func<int, int> func = num => num;
            Action<List<int>> print = nums =>
                                            Console.WriteLine(string.Join(" ", nums));
            while (command != "end")
            {
                if (command == "add")
                {
                    func = num => num + 1;
                    nums = nums.Select(func).ToList();

                }
                else if (command == "subtract")
                {
                    func = num => num - 1;
                    nums = nums.Select(func).ToList();
                }
                else if (command == "multiply")
                {
                    func = num => num * 2;
                    nums = nums.Select(func).ToList();
                }
                else if (command == "print")
                {
                    print(nums);
                }

                command = Console.ReadLine();
            }
        }
    }
}
