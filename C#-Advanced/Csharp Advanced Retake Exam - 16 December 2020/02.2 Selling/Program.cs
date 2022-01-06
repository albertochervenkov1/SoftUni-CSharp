using System;

namespace _02._2_Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int snakeRow = -1;
            int snakeCol = -1;
            int firstPillarRow = -1;
            int firstPillarColumn = -1;
            int secondPillarRow = -1;
            int secondPillarColumn = -1;

            char[,] matrix = new char[n, n];
            FillMatrix(n, ref snakeRow, ref snakeCol, matrix,ref firstPillarRow,ref firstPillarColumn,ref secondPillarRow,ref secondPillarColumn);

            string command = Console.ReadLine();
            int moneyCounter = 0;
            bool isOut= false;
            bool enoughMoney = false;
            while (true)
            {
                int newRow = snakeRow;
                int newCol = snakeCol;
                switch (command)
                {
                    case "up":
                        newRow--;
                        break;
                    case "down":
                        newRow++;
                        break;
                    case "left":
                        newCol--;
                        break;
                    case "right":
                        newCol++;
                        break;
                    
                            
                    default:
                        break;
                }
                if (CheckIndexIsOutOfRange(newRow,newCol,n))
                {
                    isOut = true;
                    break;
                }
                else
                {
                    matrix[snakeRow, snakeCol] = '-';

                    snakeRow = newRow;
                    snakeCol = newCol;
                }
                if (matrix[snakeRow, snakeCol] == 'O')
                {
                    matrix[snakeRow, snakeCol] = '-';

                    snakeRow = secondPillarRow;
                    snakeCol = secondPillarColumn;


                }
                else if (Char.IsDigit(matrix[snakeRow, snakeCol]))
                {
                    moneyCounter += (int)char.GetNumericValue(matrix[snakeRow, snakeCol]);

                    if (moneyCounter >= 50)
                    {


                        enoughMoney = true;
                        break;
                    }
                }
                command =Console.ReadLine();
            }
            if(enoughMoney)
            {
                matrix[snakeRow, snakeCol] = 'S';
                Console.WriteLine("Good news! You succeeded in collecting enough money!");

            }
            else if (isOut)
            {
                matrix[snakeRow, snakeCol] = '-';

                Console.WriteLine("Bad news, you are out of the bakery.");
            }
            Console.WriteLine($"Money: {moneyCounter}");
            PrintMatrix(matrix, n);
        }

        private static void FillMatrix(int n, ref int snakeRow, ref int snakeCol, char[,] matrix,ref int firstPillarRow,ref int firstPillarColumn,ref int secondPillarRow,ref int secondPillarColumn)
        {
            for (int row = 0; row < n; row++)
            {
                var current = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = current[col];
                    if (matrix[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                    else if (matrix[row, col] == 'O')
                    {
                        if (firstPillarRow < 0 && firstPillarColumn < 0)
                        {
                            firstPillarRow = row;
                            firstPillarColumn = col;
                        }
                        else
                        {
                            secondPillarRow = row;
                            secondPillarColumn = col;
                        }

                    }
                }
            }
        }
        static bool CheckIndexIsOutOfRange(int currentRow, int currentColumn, int matrixSize)
        {
            if (currentColumn >= matrixSize || currentColumn < 0
                || currentRow >= matrixSize || currentRow < 0)
            {

                return true;
            }

            return false;

        }
        static void PrintMatrix(char[,] matrix, int size)
        {

            for (int row = 0; row < size; row++)
            {

                for (int col = 0; col < size; col++)
                {

                    Console.Write(matrix[row, col]);

                }
                Console.WriteLine();
            }
        }
    }
}
