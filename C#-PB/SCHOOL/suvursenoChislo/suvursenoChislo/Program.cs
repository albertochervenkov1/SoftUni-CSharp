using System;

namespace suvursenoChislo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num%i==0)
                {
                    if (i==num)
                    {
                        continue;
                    }
                    else
                    {
                        sum += i;
                    }
                    
                }
            }
            if (sum==num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
