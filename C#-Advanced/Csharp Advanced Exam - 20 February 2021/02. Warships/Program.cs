using System;
using System.Collections.Generic;

namespace _02.Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixDimension = int.Parse(Console.ReadLine());
            List<string> commands = new List<string>(Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries));

            int playerOneShips = 0;
            int playerTwoShips = 0;

            char[,] matrix = new char[matrixDimension, matrixDimension];
            FillMatrix(matrixDimension, matrix, ref playerOneShips, ref playerTwoShips);
            

          
            int ships = 0;
            int playerOneDestroyedCounter = 0;
            int playerTwoDestroyedCounter = 0;
           
            

            while (playerOneShips != 0 && playerTwoShips != 0 && commands.Count > 0)
            {
                if (playerOneShips==0||playerTwoShips==00||commands.Count<=0)
                {
                    break;
                }
                string[] data = commands[0].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                commands.RemoveAt(0);
                int rowData = int.Parse(data[0]);
                int colData = int.Parse(data[1]);
                if (!isValid(rowData, colData, matrixDimension))
                {
                    continue;
                }
                else
                {
                    
                    if (matrix[rowData, colData] == '#')
                    {
                        if (isValid(rowData, colData, matrixDimension))
                        {
                            matrix[rowData, colData] = 'X';
                            
                            if (isValid(rowData + 1, colData, matrixDimension))
                            {

                                if (matrix[rowData + 1, colData] == '<')
                                {
                                    
                                    ships++;
                                    playerOneShips--;
                                    playerTwoDestroyedCounter++;
                                    
                                    
                                   
                                }
                                if (matrix[rowData + 1, colData] == '>')
                                {
                                    ships++;
                                    playerTwoShips--;
                                    playerOneDestroyedCounter++;
                                    
                                    
                                    
                                }
                                matrix[rowData + 1, colData] = 'X';
                            }
                            if (isValid(rowData - 1, colData, matrixDimension))
                            {
                                if (matrix[rowData - 1, colData] == '<')
                                {
                                    ships++;
                                    playerOneShips--;
                                    playerTwoDestroyedCounter++;
                                    
                                   
                                    
                                }
                                if (matrix[rowData - 1, colData] == '>')
                                { 
                                    ships++; 
                                    playerTwoShips--;
                                    playerOneDestroyedCounter++;
                                   
                                   
                                  
                                }
                                matrix[rowData - 1, colData] = 'X';
                            }
                            if (isValid(rowData, colData - 1, matrixDimension))
                            {
                                if (matrix[rowData, colData - 1] == '<')
                                { 
                                    ships++; 
                                    playerOneShips--;
                                    playerTwoDestroyedCounter++;
                                }
                                if (matrix[rowData, colData - 1] == '>')
                                {
                                    ships++;
                                    playerTwoShips--;
                                    playerOneDestroyedCounter++;
                                }
                                matrix[rowData, colData - 1] = 'X';
                            }
                            if (isValid(rowData, colData + 1, matrixDimension))
                            {
                                if (matrix[rowData, colData + 1] == '<')
                                {
                                    ships++;  
                                    playerOneShips--;
                                    playerTwoDestroyedCounter++;
                                  
                                    
                                   
                                }
                                if (matrix[rowData, colData + 1] == '>')
                                { 
                                    ships++;
                                    playerOneDestroyedCounter++;
                                    playerTwoShips--;
                                }
                                matrix[rowData, colData + 1] = 'X';

                            }
                            if (isValid(rowData + 1, colData + 1, matrixDimension))
                            {
                                if (matrix[rowData + 1, colData + 1] == '<')
                                {   
                                    ships++;
                                    playerOneShips--;
                                    
                                    playerTwoDestroyedCounter++;
                                }
                                if (matrix[rowData + 1, colData + 1] == '>')
                                {
                                    ships++;
                                    playerTwoShips--;
                                    playerOneDestroyedCounter++; 
                                }
                                matrix[rowData + 1, colData + 1] = 'X';
                            }
                        }
                    }
                    if (matrix[rowData, colData] == '<')
                    {
                        matrix[rowData, colData] = 'X';
                        ships++;
                        playerTwoDestroyedCounter++;
                        playerOneShips--;
                        
                        
                    }
                    if (matrix[rowData, colData] == '>')
                    { 
                        matrix[rowData, colData] = 'X';
                        ships++;
                        playerTwoShips--;
                        playerOneDestroyedCounter++;
                    }
                }

            }
            if (playerOneShips == 0)
            {
                Console.WriteLine($"Player Two has won the game! {ships} ships have been sunk in the battle.");
                return;
            }
            if (playerTwoShips == 0)
            {
                Console.WriteLine($"Player One has won the game! {ships} ships have been sunk in the battle.");
                return;
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {playerOneShips} ships left. Player Two has {playerTwoShips} ships left.");
            }

        }
        private static void FillMatrix(int matrixDimension, char[,] matrix,ref int playerOne, ref int PlayerTwo)
        {
            for (int row = 0; row < matrixDimension; row++)
            {
                string[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrixDimension; col++)
                {
                    matrix[row, col] = char.Parse(rowData[col]);
                    if (matrix[row, col] == '<')
                    {
                        playerOne++;
                    }
                    if (matrix[row, col] == '>')
                    {
                        PlayerTwo++;
                    }
                }
            }
        }

        public static bool isValid(int row, int col,int matrixDimension)
        {
            if (row < 0 || row >= matrixDimension)
            {
                return false;
            }
            if (col < 0 || col >= matrixDimension)
            {
                return false;
            }

            return true;
        }

    }
}
