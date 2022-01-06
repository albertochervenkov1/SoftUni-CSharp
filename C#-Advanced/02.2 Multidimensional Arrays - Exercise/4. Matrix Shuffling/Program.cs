using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int r = n[0];
            int c = n[1];
            string[,] matrix = new string[r, c];

            for (int row = 0; row < r; row++)
            {
                string[] data = Console.ReadLine().Split();
                for (int col = 0; col < c; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            string input = Console.ReadLine();
            while (input!="END")
            {
                string[] splitted = input.Split();
                string command = splitted[0];
                int row1 = int.Parse(splitted[1]);
                int col1 = int.Parse(splitted[2]);
                int row2 = int.Parse(splitted[3]);
                int col2 = int.Parse(splitted[4]);
                bool isValid1 = row1 >= 0 && row1 <= r && col1 >= 0 && col1 <= c;
                bool isValid2= row2 >= 0 && row2 <= r && col2 >= 0 && col2 <= c;

                if (splitted.Length!=5||command!="swap")
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }

                if (!isValid1||!isValid2)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }

                string value1 = matrix[row1, col1];
                string value2 = matrix[row2, col2];

                matrix[row1, col1] = value2;
                matrix[row2, col2] = value1;
                for (int row = 0; row < r; row++)
                {
                    for (int col = 0; col < c; col++)
                    {
                        Console.Write(matrix[row,col] + " ");
                    }
                    Console.WriteLine();
                }

                input = Console.ReadLine();
            }
        }
    }
}
