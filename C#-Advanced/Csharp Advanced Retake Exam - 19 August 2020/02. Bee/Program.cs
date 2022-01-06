using System;
using System.Linq;

namespace _02._Bee
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
            int counter = 0;
            bool bOut= false;
           
            while (command!="End")
            {
                bool founded = false;
                if (command=="up")
                {
                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            int currentRow = row;
                            int currentCol = col;
                            
                            if (matrix[row,col]=='B')
                            {
                                founded = true;
                                matrix[row, col] = '.';
                                if (currentRow - 1 < 0 || currentRow - 1 >= n || currentCol < 0 || currentCol >= n)
                                {
                                    bOut = true;

                                    break;
                                }
                                

                                if (matrix[row-1,col]=='f')
                                {
                                    counter++;
                                    

                                    matrix[row-1, col] = 'B';
                                }
                                else if (matrix[row - 1, col] == 'O')
                                {
                                    matrix[row - 1, col] = '.';
                                    if (currentRow-2<0||currentRow-2>=n||currentCol<0||currentCol>=n)
                                    {
                                        bOut = true;
                                        break;
                                    }
                                    if (matrix[row-2,col]=='f')
                                    {
                                        counter++;


                                        matrix[row - 2, col] = 'B';
                                    }
                                    else
                                    {
                                        matrix[row - 2, col] = 'B';
                                    }
                                    
                                }
                                else if (matrix[row-1,col]=='.')
                                {
                                    matrix[row - 1, col]='B';
                                }
                                break;
                                
                            }
                        }
                        if (bOut == true||founded==true)
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
                            int currentRow = row;
                            int currentCol = col;
                            
                            if (matrix[row,col]=='B')
                            {
                                founded = true;
                                matrix[row, col] = '.';
                                if (currentRow + 1 < 0 || currentRow + 1 >= n || currentCol < 0 || currentCol >= n)
                                {
                                    bOut = true;
                                    break;
                                }
                                
                                if (matrix[row+1,col]=='.')
                                {
                                    matrix[row + 1, col] = 'B';
                                }
                                else if (matrix[row+1,col]=='f')
                                {
                                    counter++;
                                    matrix[row + 1, col] = 'B';
                                }
                                else if (matrix[row+1,col]=='O')
                                {
                                    matrix[row + 1, col] = '.';
                                    if (currentRow + 2 < 0 || currentRow + 2 >= n || currentCol < 0 || currentCol >= n)
                                    {
                                        bOut = true;
                                        break;
                                    }

                                    if (matrix[row + 2, col] == 'f')
                                    {
                                        counter++;


                                        matrix[row + 2, col] = 'B';
                                    }
                                    else
                                    {
                                        matrix[row + 2, col] = 'B';
                                    }
                                }
                                break;
                            }
                        }
                        if (bOut==true||founded==true)
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
                            int currentRow = row;
                            int currentCol = col;
                            
                            if (matrix[row, col] == 'B')
                            {
                                founded = true;
                                matrix[row, col] = '.';
                                if (currentRow < 0 || currentRow >= n || currentCol-1 < 0 || currentCol-1 >= n)
                                {
                                    bOut = true;

                                    break;
                                }
                               

                                if (matrix[row, col-1] == 'f')
                                {
                                    counter++;


                                    matrix[row, col-1] = 'B';
                                }
                                else if (matrix[row, col-1] == 'O')
                                {
                                    matrix[row, col-1] = '.';
                                    if (currentRow < 0 || currentRow >= n || currentCol-2 < 0 || currentCol-2 >= n)
                                    {
                                        bOut = true;
                                        break;
                                    }
                                    if (matrix[row, col-2] == 'f')
                                    {
                                        counter++;


                                        matrix[row, col-2] = 'B';
                                    }
                                    else
                                    {
                                        matrix[row , col-2] = 'B';
                                    }
                                }
                                else if (matrix[row,col-1]=='.')
                                {
                                    matrix[row, col - 1] = 'B';
                                }
                                break;
                            }
                        }
                        if (bOut==true||founded==true)
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
                            int currentRow = row;
                            int currentCol = col;

                            if (matrix[row, col] == 'B')
                            {
                                founded = true;
                                matrix[row, col] = '.';
                                if (currentRow < 0 || currentRow >= n || currentCol + 1 < 0 || currentCol + 1 >= n)
                                {
                                    bOut = true;

                                    break;
                                }
                                

                                if (matrix[row, col + 1] == 'f')
                                {
                                    counter++;


                                    matrix[row, col + 1] = 'B';
                                }
                                else if (matrix[row, col + 1] == 'O')
                                {
                                    matrix[row, col + 1] = '.';
                                    if (currentRow < 0 || currentRow >= n || currentCol + 2 < 0 || currentCol + 2 >= n)
                                    {
                                        bOut = true;
                                        break;
                                    }
                                    if (matrix[row, col + 2] == 'f')
                                    {
                                        counter++;


                                        matrix[row, col + 2] = 'B';
                                    }
                                    else
                                    {
                                        matrix[row, col + 2] = 'B';
                                    }
                                }
                                else if (matrix[row,col+1]=='.')
                                {
                                    matrix[row,col+1]='B';
                                }
                                break;
                            }
                        }
                        if (bOut == true||founded==true)
                        {
                            break;
                        }
                    }
                }
                if (bOut==true)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if (bOut==true)
            {
                Console.WriteLine("The bee got lost!");
            }
            if (counter>=5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {counter} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5-counter} flowers more");
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
