using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = Math.Abs(n);
            int sumOdd = 0;
            int sumEven = 0;
            Console.WriteLine(GetMultipleOfEvenAndOdds(sumOdd, sumEven));
        }
        
        static void GetSumOfOddsDigits(int num,int sumEven)
        {
            int sum = 0;
            while (num>0)
            {
                int currentDigit = num%10;
                if (currentDigit%2==0)
                {
                    sum +=currentDigit;
                }
                num /= 10;
            }
            sumEven = sum;
        }
        static void GetSumOfOddDigits(int num,int sumOdd)
        {
            int sum = 0;
            while (num > 0)
            {
                int currentDigit = num % 10;
                if (currentDigit % 2 != 0)
                {
                    sum += currentDigit;
                }
                num /= 10;
            }
            sumOdd = sum;
        }
        static int GetMultipleOfEvenAndOdds(int sumOdd, int sumEven)
        {
            return sumEven * sumOdd;
        }



    }
}
