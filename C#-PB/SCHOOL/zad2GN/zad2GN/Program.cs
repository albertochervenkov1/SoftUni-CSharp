using System;

namespace zad2GN
{
    class Program
    {
        static void Main(string[] args)
        {
            int pari = int.Parse(Console.ReadLine());
            int dolara20 = 0;
            int dolara10 = 0;
            int dolara5 = 0;
            int dolara1 = 0;

            while (pari>0)
            {
                if (pari >= 20)
                {
                    pari -= 20;
                    dolara20++;
                }
                else if (pari>=10)
                {
                    pari -= 10;
                    dolara10++;
                }
                else if (pari>=5)
                {
                    pari -= 5;
                    dolara5++;
                }
                else if (pari>=1)
                {
                    pari -= 1;
                    dolara1++;
                }

            }
            Console.WriteLine($"{dolara20} от $20, {dolara10} от $10, {dolara5} от $5, {dolara1} от $1.");
            
            
        }
    }
}
