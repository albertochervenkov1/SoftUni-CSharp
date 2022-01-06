using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            decimal counter = 0;
            for (int i = 1; i <=n; i++)
            {
               decimal num = decimal.Parse(Console.ReadLine());
                counter += num;

                
            }
            Console.WriteLine(counter);
        }
    }
}
