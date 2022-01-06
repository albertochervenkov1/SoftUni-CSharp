using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int firstSum = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = row; col < n; col++)
                {
                    firstSum += matrix[row, col];
                    break;
                }
            }

            int secondSum = 0;
            int counter = n - 1;
            for (int row = 0; row < n; row++)
            {
                secondSum += matrix[row, counter];
                counter--;
            }

            int sum = Math.Abs(firstSum - secondSum);
            Console.WriteLine(sum);
        }
    }
}
