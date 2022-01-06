using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <=n; i++)
            {
                int curentDigit = 0;
                int num = i;
                while (num>0)
                {
                    curentDigit += num % 10;
                    num /= 10;
                    sum = curentDigit;
                    
                }
            }
            Console.WriteLine(sum);

        }
    }
}
