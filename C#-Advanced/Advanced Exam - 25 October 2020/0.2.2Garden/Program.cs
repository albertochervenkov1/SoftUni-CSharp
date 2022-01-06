using System;
using System.Linq;

namespace Garden
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int r = dimensions[0];
            int c = dimensions[1];
            int[,] garden = new int[r, c];

            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                if (input.Contains("Bloom"))
                {
                    for (int row = 0; row < r; row++)
                    {
                        for (int col = 0; col < c; col++)
                        {
                            if (garden[row, col] == -1)
                            {
                                garden[row, col] = 1;
                            }
                        }
                    }
                    break;
                }
                else
                {
                    int n = int.Parse(input[0]);
                    int m = int.Parse(input[1]);

                    for (int row = 0; row < r; row++)
                    {
                        for (int col = 0; col < c; col++)
                        {
                            if (row == n && col == m)
                            {
                                garden[row, col] = -1;
                                for (int i = n; i < n+1; i++)
                                {
                                    for (int j = 0; j < c; j++)
                                    {
                                        if (garden[i,j]>=0)
                                        {
                                            
                                            garden[i, j]++;
                                            

                                        }
                                        
                                    }
                                }
                                for (int i = m; i < m+1; i++)
                                {
                                    for (int j = 0; j < r; j++)
                                    {
                                        if (garden[i, j] >= 0)
                                        {
                                            
                                            garden[j, i]++;

                                        }
                                    }
                                }

                            }
                        }
                    }

                }
                input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            }
            string arrayString = "";
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    arrayString += string.Format("{0} ", garden[i, j]);
                }
                arrayString += System.Environment.NewLine + System.Environment.NewLine;
            }

        }
    }
}
