using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = int.Parse(Console.ReadLine());
            int freeWindow=int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            int counter=0;

            while (true)
            {
                int secondsOnGreen = seconds;
                int remainingFreeWindow = freeWindow;
                if (input=="green")
                {
                    while ( secondsOnGreen> 0 && queue.Count != 0)
                    {
                        string firstCarInQueue = queue.Dequeue();
                        secondsOnGreen -= firstCarInQueue.Count();
                        if (secondsOnGreen>=0)
                        {
                            counter++;
                        }
                        else
                        {
                            remainingFreeWindow += secondsOnGreen;
                            if (remainingFreeWindow < 0)
                            {
                                Console.WriteLine($"A crash happened!{Environment.NewLine}" +
                                    $"{firstCarInQueue} was hit at" +
                                    $" {firstCarInQueue[firstCarInQueue.Length + remainingFreeWindow]}.");
                                return;
                            }
                            counter++;

                        }

                    }
                    
                }
                else
                {
                    queue.Enqueue(input);
                   
                }
                if (input=="END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{counter} total cars passed the crossroads.");
                    break;
                }
                input = Console.ReadLine();
            }

        }
    }
}
