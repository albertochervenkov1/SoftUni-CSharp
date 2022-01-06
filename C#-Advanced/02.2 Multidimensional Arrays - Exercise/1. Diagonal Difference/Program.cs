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
            int firstSum = 0;
            int secondSum = 0;
            for (int row = 0; row < n; row++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = row; col < n; col+=1)
                {
                    firstSum += matrix[row, col];
                    break;
                }
            }
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
