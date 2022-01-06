using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input2.Length; j++)
                {
                    if (input[i]==input2[j])
                    {
                        Console.Write($"{input2[j]} ");
                    }
                }
            }
        }
    }
}
