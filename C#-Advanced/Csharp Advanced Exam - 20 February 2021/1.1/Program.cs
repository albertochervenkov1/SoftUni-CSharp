using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._The_Fight_for_Gondor
{
    class Program
    {
        static void Main(string[] args)
        {
             int numberofWaves = int.Parse(Console.ReadLine());
            byte[] platesArr = Console.ReadLine().Split(" ").Select(byte.Parse).ToArray();
            Queue<byte> plates = new Queue<byte>(platesArr);

            bool platesLost = false;
            List<byte> orcs = new List<byte>();

            for (int i = 1; i <= numberofWaves; i++)
            {
                byte[] warriorsArr = Console.ReadLine().Split(" ").Select(byte.Parse).ToArray();
                Stack<byte> warriorsOrc = new Stack<byte>(warriorsArr);
                if (i % 3 == 0)
                {
                    byte n = byte.Parse(Console.ReadLine());
                    plates.Enqueue(n);
                }
                while (true)
                {

                    if (warriorsOrc.Count <= 0 || plates.Count <= 0)
                    {
                        break;
                    }
                    else
                    {
                        byte currentWarrior = warriorsOrc.Peek();
                        byte currentPlate = plates.Peek();
                        if (currentPlate == currentWarrior)
                        {
                            warriorsOrc.Pop();
                            plates.Dequeue();

                        }
                        else if (currentPlate > currentWarrior)
                        {
                            warriorsOrc.Pop();
                            currentPlate -= currentWarrior;
                            plates.Dequeue();
                            List<byte> list = new List<byte>(plates);
                            list.Insert(0, currentPlate);
                            plates = new Queue<byte>(list);

                        }
                        else if (currentWarrior > currentPlate)
                        {
                            plates.Dequeue();
                            currentWarrior -= currentPlate;
                            warriorsOrc.Pop();
                            warriorsOrc.Push(currentWarrior);

                        }
                    }
                }
                if (plates.Count <= 0)
                {
                    platesLost = true;
                    orcs.AddRange(warriorsOrc);
                    break;

                }
            }
            if (platesLost == false)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(" ", plates)}");
            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}");
            }
        }
    }
}
