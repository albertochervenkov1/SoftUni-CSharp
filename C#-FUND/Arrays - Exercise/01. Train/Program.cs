using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                nums[i] = number;
                sum += number;

                
            }
            Console.WriteLine(string.Join(" ", nums));
            Console.WriteLine(sum);
        }
    }
}
