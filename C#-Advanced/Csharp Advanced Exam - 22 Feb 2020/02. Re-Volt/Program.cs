using System;

namespace _02._Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                char[] rowData = input.ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            bool won = false;
            for (int i = 0; i < m; i++)
            {
                string command = Console.ReadLine();
                bool plFounded = false;
                if (command=="up")
                {
                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            if (matrix[row,col]=='f')
                            {
                                matrix[row, col] = '-';
                                plFounded = true;
                                if (row - 1 < 0)
                                {
                                    matrix[row, col] = '-';
                                    if (matrix[n-1, col] == 'F')
                                    {
                                        won = true;
                                    }
                                    
                                    matrix[n - 1, col] = 'f';
                                }
                                else if (matrix[row-1,col]=='F')
                                {
                                    matrix[row, col] = '-';
                                    matrix[row - 1, col] = 'f';
                                    won = true;
                                }
                                else if (matrix[row-1,col]=='B')
                                {
                                    matrix[row, col] = '-';
                                    //check if is out of bounds
                                    if (row-2<0)
                                    {
                                        if (matrix[row - 2, col] == 'F')
                                        {
                                            won = true;
                                        }
                                        matrix[n - 1, col] = 'f';
                                    }
                                    else
                                    {
                                        
                                        matrix[row - 2, col] = 'f';
                                        
                                    }
                                    
                                }
                                else if (matrix[row-1,col]=='-')
                                {
                                    matrix[row, col] = '-';
                                    matrix[row - 1, col] = 'f';
                                }
                                else if (matrix[row-1,col]=='T')
                                {
                                    matrix[row, col] = 'f';
                                }
                               
                            }
                            if (plFounded==true)
                            {
                                break;
                            }
                        }
                        if (plFounded==true)
                        {
                            break;
                        }
                    }
                }
                else if (command=="down")
                {
                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            if (matrix[row, col] == 'f')
                            {
                                matrix[row, col] = '-';
                                plFounded = true;
                                if (row + 1>=n)
                                {
                                    matrix[row, col] = '-';
                                    if (matrix[0, col] == 'F')
                                    {
                                        won = true;
                                    }

                                    matrix[0, col] = 'f';
                                }
                                else if (matrix[row + 1, col] == 'F')
                                {
                                    matrix[row, col] = '-';
                                    matrix[row + 1, col] = 'f';
                                    won = true;
                                }
                                else if (matrix[row + 1, col] == 'B')
                                {
                                    matrix[row, col] = '-';
                                    //check if is out of bounds
                                    if (row + 2 >= n)
                                    {
                                        if(matrix[row + 2, col] == 'F')
                                        {
                                            won = true;
                                        }
                                        matrix[0, col] = 'f';


                                    }
                                    else
                                    {
                                        matrix[row + 2, col] = 'f';
                                    }
                                }
                                else if (matrix[row + 1, col] == '-')
                                {
                                    matrix[row, col] = '-';
                                    matrix[row + 1, col] = 'f';
                                }
                                else if (matrix[row + 1, col] == 'T')
                                {
                                    matrix[row, col] = 'f';
                                }

                            }
                            if (plFounded == true)
                            {
                                break;
                            }
                        }
                        if (plFounded == true)
                        {
                            break;
                        }
                    }
                }
                else if (command=="left")
                {
                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            if (matrix[row, col] == 'f')
                            {
                                matrix[row, col] = '-';
                                plFounded = true;
                                if (col-1<0)
                                {
                                    

                                    matrix[row, col] = '-';
                                    if (matrix[row, n-1] == 'F')
                                    {
                                        won = true;
                                    }

                                    matrix[row, n - 1] = 'f';
                                }
                                else if (matrix[row, col-1] == 'F')
                                {
                                    matrix[row, col] = '-';
                                    matrix[row, col-1] = 'f';
                                    won = true;
                                }
                                else if (matrix[row, col-1] == 'B')
                                {
                                    matrix[row, col] = '-';
                                    //check if is out of bounds
                                    if (col - 2 < 0)
                                    {
                                        if(matrix[row, n-1] == 'F')
                                        {
                                            won = true;
                                        }
                                        matrix[row, n-1] = 'f';
                                    }
                                    else
                                    {
                                        matrix[row, col-2] = 'f';
                                    }
                                }
                                else if (matrix[row, col-1] == '-')
                                {
                                    matrix[row, col] = '-';
                                    matrix[row, col-1] = 'f';
                                }
                                else if (matrix[row, col-1] == 'T')
                                {
                                    matrix[row, col] = 'f';
                                }

                            }
                            if (plFounded == true)
                            {
                                break;
                            }
                        }
                        if (plFounded == true)
                        {
                            break;
                        }
                    }
                }
                else if (command=="right")
                {
                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            if (matrix[row, col] == 'f')
                            {
                                matrix[row, col] = '-';
                                plFounded = true;
                                if (col+1>=n)
                                {
                                    matrix[row, col] = '-';
                                    if (matrix[row, 0] == 'F')
                                    {
                                        won = true;
                                    }
                                    matrix[row, 0] = 'f';

                                }
                                else if (matrix[row, col + 1] == 'F')
                                {
                                    matrix[row, col] = '-';
                                    matrix[row, col + 1] = 'f';
                                    won = true;
                                }
                                else if (matrix[row, col + 1] == 'B')
                                {
                                    matrix[row, col] = '-';
                                    //check if is out of bounds
                                    if (col + 2 >= n)
                                    {
                                        if (matrix[row, 0] == 'F')
                                        {
                                            won = true;
                                        }
                                        matrix[row, 0] = 'f';
                                    }
                                    else
                                    {
                                        matrix[row, col + 2] = 'f';
                                    }
                                }
                                else if (matrix[row, col + 1] == '-')
                                {
                                    matrix[row, col] = '-';
                                    matrix[row, col + 1] = 'f';
                                }
                                else if (matrix[row, col + 1] == 'T')
                                {
                                    matrix[row, col] = 'f';
                                }

                            }
                            if (plFounded == true)
                            {
                                break;
                            }
                        }
                        if (plFounded == true)
                        {
                            break;
                        }
                    }
                }
                if (won==true)
                {
                    break;
                }
            }
            if (won==true)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }
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
