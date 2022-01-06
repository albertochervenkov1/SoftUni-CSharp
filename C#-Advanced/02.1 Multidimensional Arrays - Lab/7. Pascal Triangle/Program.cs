using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentLength = 1;
            long[][] jaggedArr = new long[n][];

            for (int i = 0; i < n; i++)
            {
                jaggedArr[i] = new long[currentLength];
                jaggedArr[i][0] = 1;
                jaggedArr[i][currentLength - 1] = 1;
                if (currentLength>2)
                {
                    for (int j = 1; j <currentLength-1; j++)
                    {
                        jaggedArr[i][j] = jaggedArr[i - 1][j - 1] + jaggedArr[i - 1][j];
                    }
                }
                currentLength++;
            }
            foreach (long[] item in jaggedArr)
            {
                Console.WriteLine(string.Join(" ",item));
            }
        }
    }
}
