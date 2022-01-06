using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nq = 0;
            int sumWater = 0;

            for (int i = 1; i <=n; i++)
            { 
                nq = int.Parse(Console.ReadLine());
                sumWater += nq;

                if (sumWater<=255)
                {
                  
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                    sumWater -= nq;
                    
                }
            }
            Console.WriteLine(sumWater);
        }
    }
}
