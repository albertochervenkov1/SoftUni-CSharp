using System;

namespace _02._Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string str = Console.ReadLine();
                char[] rowData = str.ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            string command = Console.ReadLine();

            bool snakeOut = false;
            int foodQuantity = 0;
            while (true)
            {
                bool snakeFounded = false;
                if (command == "up")
                {
                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            int currentRow = row;
                            int currentCol = col;
                            if (matrix[row, col] == 'S')
                            {
                                snakeFounded = true;
                                matrix[row, col] = '.';
                                if (currentRow - 1 < 0 || currentRow - 1 >= n || currentCol < 0 || currentCol >= n)
                                {
                                    snakeOut = true;
                                    break;
                                }
                                if (matrix[row - 1, col] == '-')
                                {
                                    matrix[row - 1, col] = 'S';
                                }
                                else if (matrix[row - 1, col] == '*')
                                {
                                    matrix[row - 1, col] = 'S';
                                    foodQuantity++;
                                }
                                else if (matrix[row - 1, col] == 'B')
                                {
                                    matrix[row - 1, col] = '.';
                                    for (int row2 = 0; row2 < n; row2++)
                                    {
                                        for (int col2 = 0; col2 < n; col2++)
                                        {
                                            if (matrix[row2, col2] == 'B')
                                            {
                                                matrix[row2, col2] = 'S';
                                            }
                                        }
                                    }
                                }
                                break;
                            }
                        }
                        if (snakeFounded || snakeOut == true)
                        {
                            break;
                        }
                    }
                }
                else if (command == "down")
                {
                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            int currentRow = row;
                            int currentCol = col;
                            if (matrix[row, col] == 'S')
                            {
                                snakeFounded = true;
                                matrix[row, col] = '.';
                                if (currentRow + 1 < 0 || currentRow + 1 >= n || currentCol < 0 || currentCol >= n)
                                {
                                    snakeOut = true;
                                    break;
                                }
                                if (matrix[row + 1, col] == '-')
                                {
                                    matrix[row + 1, col] = 'S';
                                }
                                else if (matrix[row + 1, col] == '*')
                                {
                                    matrix[row + 1, col] = 'S';
                                    foodQuantity++;
                                }
                                else if (matrix[row + 1, col] == 'B')
                                {
                                    matrix[row + 1, col] = '.';
                                    for (int row2 = 0; row2 < n; row2++)
                                    {
                                        for (int col2 = 0; col2 < n; col2++)
                                        {
                                            if (matrix[row2, col2] == 'B')
                                            {
                                                matrix[row2, col2] = 'S';
                                            }
                                        }
                                    }
                                }
                                break;
                            }
                        }
                        if (snakeFounded || snakeOut == true)
                        {
                            break;
                        }
                    }

                }
                else if (command == "left")
                {
                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            int currentRow = row;
                            int currentCol = col;
                            if (matrix[row, col] == 'S')
                            {
                                snakeFounded = true;
                                matrix[row, col] = '.';
                                if (currentRow < 0 || currentRow >= n || currentCol - 1 < 0 || currentCol - 1 >= n)
                                {
                                    snakeOut = true;
                                    break;
                                }
                                if (matrix[row, col - 1] == '-')
                                {
                                    matrix[row, col - 1] = 'S';
                                }
                                else if (matrix[row, col - 1] == '*')
                                {
                                    matrix[row, col - 1] = 'S';
                                    foodQuantity++;
                                }
                                else if (matrix[row, col - 1] == 'B')
                                {
                                    matrix[row, col - 1] = '.';
                                    for (int row2 = 0; row2 < n; row2++)
                                    {
                                        for (int col2 = 0; col2 < n; col2++)
                                        {
                                            if (matrix[row2, col2] == 'B')
                                            {
                                                matrix[row2, col2] = 'S';
                                            }
                                        }
                                    }
                                }
                                break;
                            }
                        }
                        if (snakeFounded || snakeOut == true)
                        {
                            break;
                        }
                    }

                }
                else if (command == "right")
                {
                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            int currentRow = row;
                            int currentCol = col;
                            if (matrix[row, col] == 'S')
                            {
                                snakeFounded = true;
                                matrix[row, col] = '.';
                                if (currentRow < 0 || currentRow >= n || currentCol + 1 < 0 || currentCol + 1 >= n)
                                {
                                    snakeOut = true;
                                    break;
                                }
                                if (matrix[row, col + 1] == '-')
                                {
                                    matrix[row, col + 1] = 'S';
                                }
                                else if (matrix[row, col + 1] == '*')
                                {
                                    matrix[row, col + 1] = 'S';
                                    foodQuantity++;
                                }
                                else if (matrix[row, col + 1] == 'B')
                                {
                                    matrix[row, col + 1] = '.';
                                    for (int row2 = 0; row2 < n; row2++)
                                    {
                                        for (int col2 = 0; col2 < n; col2++)
                                        {
                                            if (matrix[row2, col2] == 'B')
                                            {
                                                matrix[row2, col2] = 'S';
                                            }
                                        }
                                    }
                                }
                                break;
                            }
                        }
                        if (snakeFounded || snakeOut == true)
                        {
                            break;
                        }
                    }
                }
                if (snakeOut==true||foodQuantity>=10)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if (snakeOut==true)
            {
                Console.WriteLine("Game over!");
            }
            else
            {
                Console.WriteLine("You won! You fed the snake.");
            }
            Console.WriteLine($"Food eaten: {foodQuantity}");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
