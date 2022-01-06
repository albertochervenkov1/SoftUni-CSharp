using System;

namespace zadachaKvadratnoUravnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int x1 = 0;
            int x2 = 0;
            int d = 0;

            if (a==0)
            {
                if (b==0)
                {
                    if (c==0)
                    {
                        Console.WriteLine("Всяко x е решение");
                    }
                    else
                    {
                        Console.WriteLine("Няма решение");
                    }
                }
                else
                {
                    x1 = -c / b;
                    Console.WriteLine($"x1={x1}");
                }
            }
            else
            {
                d = (b * b) - ((a * 4) * c);
                if (d>0)
                {
                    Math.Sqrt(d);
                    x1 = (-b - d) / (2 * a);
                    x2 = (-b + d) / (2 * a);
                    Console.WriteLine($"x1={x1}");
                    Console.WriteLine($"x2={x2}");
                }
                else
                {
                    if (d==0)
                    {
                        x1 = -b / (2 * a);
                        Console.WriteLine($"x1={x1}");
                    }
                    else
                    {
                        Console.WriteLine("Няма решение");
                    }
                }
            }

        }
    }
}
