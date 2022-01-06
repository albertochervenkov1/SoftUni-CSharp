using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int n = dimensions[0];
            int m = dimensions[1];
            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                int[] rawData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = rawData[col];
                }
            }
            int maxSum = int.MinValue;



        }
    }
}
