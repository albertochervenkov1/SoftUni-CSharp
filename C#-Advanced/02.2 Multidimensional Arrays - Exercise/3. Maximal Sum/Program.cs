﻿using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int r = n[0];
            int c = n[1];
            int[,] matrix = new int[r, c];

            for (int row = 0; row < r; row++)
            {
                int[] data = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < c; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            int maxSum = int.MinValue;
            int rowIndex = -1;
            int colIndex = -1;
            for (int row = 0; row < r-2; row++)
            {
                for (int col = 0; col < c-2; col++)
                {
                    int sum = matrix[row, col];
                    sum+= matrix[row, col+1];
                    sum+= matrix[row, col+2];

                    sum += matrix[row + 1, col];
                    sum += matrix[row+1, col + 1];
                    sum += matrix[row+1, col + 2];

                    sum += matrix[row + 2, col];
                    sum += matrix[row + 2, col + 1];
                    sum += matrix[row + 2, col + 2];
                    if (sum>maxSum)
                    {
                        maxSum = sum;
                        rowIndex = row;
                        colIndex = col;

                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int row = rowIndex; row < rowIndex+3; row++)
            {
                for (int col = colIndex; col < colIndex+3; col++)
                {
                    Console.Write(matrix[row,col]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
