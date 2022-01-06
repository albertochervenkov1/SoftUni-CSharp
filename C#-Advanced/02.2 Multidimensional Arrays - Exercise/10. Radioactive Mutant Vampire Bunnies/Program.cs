using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int r = n[0];
            int c = n[1];
            char[,] matrix = new char[r, c];
            int playerRow = -1;
            int playerCol = -1;
            for (int row = 0; row < r; row++)
            {
                char[] data = Console.ReadLine().ToCharArray();
                for (int col = 0; col < c; col++)
                {
                    matrix[row, col] = data[col];
                    if (matrix[row,col]=='P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
            char[] directions = Console.ReadLine().ToCharArray();
            bool isWon = false;
            bool isDead = false;

            foreach (var direction in directions)
            {
                int newPlayerRow = playerRow;
                int newPlayerCol = playerCol;
                if (direction=='U')
                {
                    newPlayerRow--;
                }
                else if (direction == 'D')
                {
                    newPlayerRow++;
                }
                else if (direction == 'L')
                {
                    newPlayerCol--;
                }
                else if (direction == 'R')
                {
                    newPlayerCol++;
                }
                if (!isValidCell(newPlayerRow,newPlayerCol,r,c))
                {
                    isWon = true;
                    matrix[playerRow, playerCol] = '.';
                }
                else if (matrix[newPlayerRow,newPlayerCol]=='.')
                {
                    matrix[playerRow, playerCol] = '.';
                    matrix[newPlayerRow, newPlayerCol] = 'P';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                }
                else if (matrix[newPlayerRow, newPlayerCol] == 'B')
                {
                    isDead = true;
                    matrix[playerRow, playerCol] = '.';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                }
                List<int[]> bunniesCordinates = GetBunniesCordinate(matrix);
                SpreadBunnies(bunniesCordinates, matrix);

            }
            
        }
        private static void SpreadBunnies(List<int[]> bunniesCordinates, char[,] matrix) 
        {
            int rowsLength = matrix.GetLength(0);
            int colsLength = matrix.GetLength(1);
            foreach (int[] bunnyCordinate in bunniesCordinates)
            {
                int row = bunnyCordinate[0];
                int col = bunnyCordinate[1];
                

            }
        }
        private static List<int[]> GetBunniesCordinate(char[,] matrix)
        {
            List<int[]> bunniesCordinates = new List<int[]>();
           
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    if (matrix[row, col] == 'B')
                    {
                        bunniesCordinates.Add(new int[] { row, col });
                    }
                }
            }
            return bunniesCordinates;
        }
        private static bool isValidCell(int row, int col, int r, int c) 
        {
            return row >= 0 && row < r && col >= 0 && col < c;
        }
    }
}
