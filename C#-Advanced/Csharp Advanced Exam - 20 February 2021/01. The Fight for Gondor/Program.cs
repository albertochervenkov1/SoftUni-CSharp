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
            int[] platesArr = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> plates = new Queue<int>(platesArr);

            bool platesLost = false;
            List<int> orcs = new List<int>();

            for (int i = 1; i <= numberofWaves; i++)
            {
                int[] warriorsArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                Stack<int> warriorsOrc = new Stack<int>(warriorsArr);
                if (i%3==0)
                {
                    int n = int.Parse(Console.ReadLine());
                    plates.Enqueue(n);
                }
                while (true)
                {
                    
                    if (warriorsOrc.Count<=0||plates.Count<=0)
                    {
                        break;
                    }
                    else
                    {
                        int currentWarrior = warriorsOrc.Peek();
                        int currentPlate = plates.Peek();
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
                            List<int> list = new List<int>(plates);
                            list.Insert(0, currentPlate);
                            plates = new Queue<int>(list);

                        }
                        else if (currentWarrior>currentPlate)
                        {
                            plates.Dequeue();
                            currentWarrior -= currentPlate;
                            warriorsOrc.Pop();
                            warriorsOrc.Push(currentWarrior);

                        }
                    }
                }
                if (plates.Count<=0)
                {
                    platesLost = true;
                    orcs.AddRange(warriorsOrc);
                    break;
                    
                }
            }
            if (platesLost==false)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ",plates)}");
            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ",orcs)}");
            }
        }
    }
}
