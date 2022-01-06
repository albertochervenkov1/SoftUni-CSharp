using System;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int br = 0;
            int s = 0;
            int counter = 0;
            do
            {
                a += 10;
                br += 10;
                s += a;
                counter++;
            } while (br<=40);
            Console.WriteLine(counter);
        }
    }
}
