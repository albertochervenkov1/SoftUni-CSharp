using System;
using System.Linq;

namespace zad1GN
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int reverseNum = 0;
            int sum = 0;
            int result = num.ToString().Sum(c => c - '0');
            while (num > 0)
            {
                
                reverseNum = reverseNum * 10 + num % 10;
                
                num /= 10;              
            }
            
            
            Console.WriteLine(reverseNum);
            Console.WriteLine(result);


        }
    }
}
