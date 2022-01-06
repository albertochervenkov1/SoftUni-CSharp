using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int st = int.Parse(Console.ReadLine());
            int nd = int.Parse(Console.ReadLine());
            int rd = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            int sum = st + nd;
            int sum2 = sum / rd;
            int sum3 = sum2 * fourth;
            Console.WriteLine(sum3);

        }
    }
}
