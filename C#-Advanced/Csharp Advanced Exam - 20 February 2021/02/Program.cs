using System;
using System.Linq;

namespace Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixDimension = int.Parse(Console.ReadLine());

            string[] commands = Console.ReadLine().Split(",");

            char[,] matrix = new char[matrixDimension, matrixDimension];

            int playerOneShips = 0;
            int playerTwoShips = 0;
            FillMatrix(matrixDimension, matrix, ref playerOneShips, ref playerTwoShips);

            

            int dataPair = 0;
            bool outIndex = true;
            int destroyed = 0;

            while (playerOneShips > 0 && playerTwoShips > 0)
            {
                if (commands.Length - 1 == dataPair)
                {
                    
                    Console.WriteLine($"It's a draw! Player One has {playerOneShips} ships left. Player Two has {playerTwoShips} ships left.");
                    outIndex = false;
                    break;
                }
                int[] dataPairArr = commands[dataPair].Split(' ').Select(int.Parse).ToArray();
                int row = dataPairArr[0];
                int col = dataPairArr[1];

                if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
                {
                    dataPair++;
                    continue;
                }

                if (dataPair % 2 == 0)
                {
                    if (matrix[row, col] == '>')
                    {
                        destroyed++;
                        playerTwoShips--;
                        
                    }
                }
                else
                {
                    if (matrix[row, col] == '<')
                    { 
                        destroyed++;
                        playerOneShips--;
                    }
                }

                if (matrix[row, col] == '#')
                {
                    matrix[row, col] = 'X';
                    if (row - 1 >= 0 && col + 1 < matrix.GetLength(1))
                    {
                        if (matrix[row - 1, col + 1] == '<')
                        { 
                            destroyed++;
                            playerOneShips--;
                           
                        }
                        else if (matrix[row - 1, col + 1] == '>')
                        { 
                            destroyed++;
                            playerTwoShips--;
                           
                        }
                        matrix[row - 1, col + 1] = 'X';
                    }
                    if (row - 1 >= 0)
                    {
                        if (matrix[row - 1, col] == '<')
                        {
                            destroyed++;
                            playerOneShips--;
                        }
                        else if (matrix[row - 1, col] == '>')
                        {
                            destroyed++;
                            playerTwoShips--;
                        }
                        matrix[row - 1, col] = 'X';
                    }

                    if (row - 1 >= 0 && col - 1 >= 0)
                    {
                        if (matrix[row - 1, col - 1] == '<')
                        { 
                            destroyed++;
                            playerOneShips--;
                           
                        }
                        else if (matrix[row - 1, col - 1] == '>')
                        {  
                            destroyed++;
                            playerTwoShips--;
                          
                        }
                        matrix[row - 1, col - 1] = 'X';
                    }

                    if (col - 1 >= 0)
                    {
                        if (matrix[row, col - 1] == '<')
                        { 
                            destroyed++;
                            playerOneShips--;
                           
                        }
                        else if (matrix[row, col - 1] == '>')
                        { 
                            destroyed++;
                            playerTwoShips--;
                           
                        }
                        matrix[row, col - 1] = 'X';
                    }

                    if (col + 1 < matrixDimension)
                    {
                        if (matrix[row, col + 1] == '<')
                        { 
                            destroyed++;
                            playerOneShips--;
                           
                        }
                        else if (matrix[row, col + 1] == '>')
                        { 
                            destroyed++;
                            playerTwoShips--;
                           
                        }
                        matrix[row, col + 1] = 'X';
                    }

                    if (row + 1 < matrixDimension)
                    {
                        if (matrix[row + 1, col] == '<')
                        { 
                            destroyed++;
                            playerOneShips--;
                           
                        }
                        else if (matrix[row + 1, col] == '>')
                        {
                            destroyed++;
                            playerTwoShips--;
                        }
                        matrix[row + 1, col] = 'X';
                    }

                    if (row + 1 < matrixDimension && col - 1 >= 0)
                    {
                        if (matrix[row + 1, col - 1] == '<')
                        {
                            destroyed++;
                            playerOneShips--;
                            
                        }
                        else if (matrix[row + 1, col - 1] == '>')
                        {
                            destroyed++;
                            playerTwoShips--;
                            
                        }
                        matrix[row + 1, col - 1] = 'X';
                    }

                    if (row + 1 < matrixDimension && col + 1 < matrixDimension)
                    {
                        if (matrix[row + 1, col + 1] == '<')
                        {  
                            destroyed++;
                            playerOneShips--;
                          
                        }
                        else if (matrix[row + 1, col + 1] == '>')
                        { 
                            destroyed++;
                            playerTwoShips--;
                           
                        }
                        matrix[row + 1, col + 1] = 'X';
                    }
                }

                
                dataPair++;
            }


            if (outIndex)
            {
                if (playerOneShips > 0)
                {
                    Console.WriteLine($"Player One has won the game! {destroyed} ships have been destroyed in the battle.");
                }
                else
                {
                    Console.WriteLine($"Player Two has won the game! {destroyed} ships have been destroyed in the battle.");
                }
            }
        }
        private static void FillMatrix(int matrixDimension, char[,] matrix, ref int playerOne, ref int PlayerTwo)
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
    }
}
