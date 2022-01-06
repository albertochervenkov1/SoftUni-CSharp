using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumpsCount = int.Parse(Console.ReadLine());
            Queue<string> pumpsData = new Queue<string>();
            for (int i = 0; i < pumpsCount; i++)
            {
                pumpsData.Enqueue(Console.ReadLine());
            }
            
            for (int i = 0; i < pumpsCount; i++)
            {
                bool isSuccessfull = true;
                int currentPetrolAmount = 0;
                for (int j = 0; j < pumpsCount; j++)
                {
                    int[] pumpData = pumpsData.Dequeue().Split().Select(int.Parse).ToArray();
                    pumpsData.Enqueue(string.Join(" ", pumpData));
                    currentPetrolAmount += pumpData[0];
                    currentPetrolAmount -= pumpData[1];
                    if (currentPetrolAmount<0)
                    {
                        isSuccessfull = false;
                    }
                }
                if (isSuccessfull)
                {
                    Console.WriteLine(i);
                    break;
                }
                string tempData = pumpsData.Dequeue();
                pumpsData.Enqueue(tempData);
            }
        }
    }
}
