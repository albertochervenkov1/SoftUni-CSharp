using System;

namespace _07._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLpart = 0;
            int sumRpart = 0;
            for (int i = 1; i <=n; i++)
            {
                int leftpart = int.Parse(Console.ReadLine());
                sumLpart += leftpart;
                
                
            }
            for (int i = 1; i <= n; i++)
            {
                int rightpart = int.Parse(Console.ReadLine());
                sumRpart += rightpart;
            }
            if (sumLpart == sumRpart)
            {
                Console.WriteLine($"Yes, sum = {(sumLpart + sumRpart) / 2}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumLpart - sumRpart)}");
            }



        }
    }
}
