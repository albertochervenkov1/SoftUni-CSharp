using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int r = n[0];
            int c = n[1];

            int[,] matrix = new int[r,c];
            for (int row = 0; row < r; row++)
            {
                int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < c; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            int sum = int.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;
            int[] arr1 = new int[2];
            int[] arr2 = new int[2];


            for (int row = 0; row < r-1; row++)
            {
                int s = 0;
                for (int col = row; col < c-1; col++)
                {
                    //s = (matrix[row, col] + matrix[row, col + 1]) + (matrix[col + 1, + row] +matrix[col + 1, + row + 1]);
                    s = (matrix[row, col] + matrix[row + 1, col])+(matrix[row,col+1]+matrix[row+1,col+1]);
                    if (s>sum)
                    {
                        sum = s;

                        maxSumRow = row;
                        maxSumCol = col;


                    }
                   

                }
            }
            Console.WriteLine(string.Join(" ",arr1));
            Console.WriteLine(string.Join(" ", arr2));
            Console.WriteLine(sum);
        }
    }
}
