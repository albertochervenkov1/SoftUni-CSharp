using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();

            int[] arr1 = new int[input.Length];
            int[] arr2 = new int[input2.Length];

            
            for (int i = 0; i < input.Length; i++)
            {
                arr1[i] = int.Parse(input[i]);
                arr2[i] = int.Parse(input2[i]);
                
                if (arr1[i]!=arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                
                
            }
            int sum = arr1.Sum();
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
