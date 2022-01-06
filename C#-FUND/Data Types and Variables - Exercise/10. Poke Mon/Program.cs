using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //You will be given the poke power the Poke Mon has, N – an integer.
            int m = int.Parse(Console.ReadLine()); //Then you will be given the distance between the poke targets, M – an integer.
            byte y = byte.Parse(Console.ReadLine()); //Then you will be given the exhaustionFactor Y – an integer.
            int nStart = n; 

            int pokeCounter = 0;

            while (n>=m)
            {
                if (n==nStart/2)
                {
                    if (y>0)//y>0
                    {
                        n /= y;
                        continue;
                    }
                }
                n -= m;
                pokeCounter++;
                
            }
            Console.WriteLine(n);
            Console.WriteLine(pokeCounter);
        }
    }
}
