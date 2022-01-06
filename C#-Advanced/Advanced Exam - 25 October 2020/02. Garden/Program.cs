using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NatureProphet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] colRow = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = colRow[1];
            int col = colRow[0];
            decimal[,] matrix = new decimal[col, rows];

            string command = Console.ReadLine();
            string[] colRowAffect = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (command != "Bloom Bloom Plow")
            {
                int rowsA = int.Parse(colRowAffect[0]);
                int colA = int.Parse(colRowAffect[1]);
                for (int i = 0; i < col; i++) //Change values
                {

                    for (int j = 0; j < rows; j++)
                    {
                        if (i == rowsA || j == colA)
                        {
                            matrix[i, j] += 1;
                        }

                    }
                }
                command = Console.ReadLine();
                colRowAffect = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            //Print result
            for (int i = 0; i < col; i++)
            {

                for (int j = 0; j < rows; j++)
                {

                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}