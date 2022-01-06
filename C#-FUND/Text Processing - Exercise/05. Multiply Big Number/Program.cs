using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            if (number==0)
            {
                Console.WriteLine(0);
                return;
            }
            while (bigNumber[0]=='0')
            {
                bigNumber = bigNumber.Substring(1);
            }
            int remainder = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = bigNumber.Length-1; i >=0 ; i--)
            {
                int res = int.Parse(bigNumber[i].ToString()) * number + remainder;
                remainder = 0;
                if (res>9)
                {
                    remainder = res / 10;
                    res = res % 10;
                }
                sb.Append(res);
            }
            if (remainder!=0)
            {
                sb.Append(remainder);
            }
            StringBuilder result = new StringBuilder();

            for (int i = sb.Length-1; i >=0 ; i--)
            {
                result.Append(sb[i]);
            }
            Console.WriteLine(result);

            
        }
    }
}
