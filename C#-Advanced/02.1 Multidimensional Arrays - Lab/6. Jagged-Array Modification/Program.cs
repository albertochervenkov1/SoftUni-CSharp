﻿using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            string[] input = Console.ReadLine().Split();

            while (input[0]!="END")
            {
                string command = input[0];
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);
                //bool invalidCordinates = row < 0 || row > rows || col < 0 || col >= jaggedArray[row].Length;
                switch (command)
                {
                    case "Add":
                        if (row < 0 || row >= rows || col < 0 || col >= jaggedArray[row].Length)
                        {
                            Console.WriteLine("Invalid coordinates");
                            
                        }
                        else
                        {
                            jaggedArray[row][col] += value;
                        }
                        break;
                    case "Subtract":
                        if (row < 0 || row >= rows || col < 0 || col >= jaggedArray[row].Length)
                        { 
                            Console.WriteLine("Invalid coordinates");
                            
                        }
                        else
                        {
                           jaggedArray[row][col] -= value;
                        }
                        break;
                    default:
                        break;
                }


                input = Console.ReadLine().Split();
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < rows; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
