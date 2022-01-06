using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int r = n[0];
            int c = n[1];
            int[,] matrix = new int[r, c];
            
            for (int row = 0; row < r; row++)
            {
                int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < c; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            for (int col = 0; col < c; col++)
            {
                int sum = 0;
                for (int row = 0; row < r; row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
