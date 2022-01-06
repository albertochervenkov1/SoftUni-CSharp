using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(", ").Select(decimal.Parse).Select(nums => nums + (nums * 0.2m)).ToArray();

            foreach (var item in nums)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
