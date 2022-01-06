using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int r = n[0];
            int c = n[1];

            char[,] matrix = new char[r, c];

            for (int row = 0; row < r; row++)
            {
                char[] data= Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < c; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            int counter = 0;

            for (int row = 0; row < r-1; row++)
            {
                for (int col = 0; col < c-1; col++)
                {
                    if (matrix[row, col] ==matrix[row,col+1]&&matrix[row,col]==matrix[row+1,col]&& matrix[row, col] == matrix[row + 1, col+1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
