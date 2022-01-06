using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            for (int row = 0; row < n; row++)
            {
                string text = Console.ReadLine();
                char[] charcaters = text.ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = charcaters[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            bool isFound = false;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row,col]==symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFound = true;
                        return;
                    }
                }
            }
            if (isFound==false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix ");
            }
        }
    }
}
