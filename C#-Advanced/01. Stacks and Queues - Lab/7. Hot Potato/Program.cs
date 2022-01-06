using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] guys = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> game = new Queue<string>(guys);
            int tossess = 0;
            while (game.Count>1)
            {
                tossess++;
                string kid = game.Dequeue();
                if (tossess==n)
                {
                    tossess = 0;
                    Console.WriteLine($"Removed {kid}");
                }
                else
                {
                    game.Enqueue(kid);
                }
            }
            Console.WriteLine($"Last is {game.Dequeue()}");
        }
    }
}
