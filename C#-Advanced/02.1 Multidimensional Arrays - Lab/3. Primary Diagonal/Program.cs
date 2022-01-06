﻿using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];


            for (int row = 0; row < n; row++)
            {
                int[] rowData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            int sum = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = row; col < n; col++)
                {
                    sum += matrix[row, col];
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
