using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bombs
{
    class Program
//        •	Datura Bombs: 40
//•	Cherry Bombs: 60
//•	Smoke Decoy Bombs: 120

    {
        static void Main(string[] args)
        {
            byte[] bombEffectsArr = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(byte.Parse).ToArray();
            Queue<byte> bombEffects = new Queue<byte>(bombEffectsArr);
            byte[] bombCasingsArr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(byte.Parse).ToArray();
            Stack<byte> bombCasings = new Stack<byte>(bombCasingsArr);

            byte datura = 0;
            byte cherryBombs = 0;
            byte smokeyDecoyBombs = 0;
            bool Filled = false;
            while (true)
            {
                if (bombCasings.Count<=0||bombEffects.Count<=0)
                {
                    break;
                }
                if (datura>=3&&cherryBombs>=3&&smokeyDecoyBombs>=3)
                {
                    Filled = true;
                    break;
                }

                byte currentEffects = bombEffects.Peek();
                byte currentCasing = bombCasings.Peek();

                if (currentCasing+currentEffects==40)
                {
                    datura++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();

                }
                else if (currentCasing+currentEffects==60)
                {
                    cherryBombs++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else if (currentCasing+currentEffects==120)
                {
                    smokeyDecoyBombs++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else
                {
                    
                    bombCasings.Pop();
                    currentCasing -= 5;
                    bombCasings.Push(currentCasing);
                }
            }
            if (Filled==true)
            {
                Console.WriteLine($"Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine($"You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Count<=0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: "+string.Join(", ",bombEffects));
            }
            if (bombCasings.Count<=0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: " + string.Join(", ", bombCasings));
            }

            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
            Console.WriteLine($"Datura Bombs: {datura}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeyDecoyBombs}");

        }
    }
}
