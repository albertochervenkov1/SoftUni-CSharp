using System;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cifra = int.Parse(Console.ReadLine());
            //chislo(n, cifra);
            Console.WriteLine(chislo(n,cifra));
        }
        static  int chislo(int n, int cifra)
        {
            int counter = 0;
            for (int i = 0; i < n.ToString().Length; i++)
            {
                int a = n % 10;
                n /= 10;
                if (a==cifra)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
