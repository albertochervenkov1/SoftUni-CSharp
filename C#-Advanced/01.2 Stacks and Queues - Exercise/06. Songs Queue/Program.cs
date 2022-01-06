using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputSongs = Console.ReadLine().Split(", ");
            Queue<string> playlist = new Queue<string>(inputSongs);

            while (playlist.Count>0)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string song ="";
                if (input.Length>1)
                { 
                    song = input[1];

                }
               
                if (command=="Add")
                {
                    if (playlist.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        playlist.Enqueue(song);

                    }
                    
                }
                else if (command=="Show")
                {
                    Console.WriteLine(string.Join(", ",playlist));
                }
                else if (command=="Play")
                {
                    playlist.Dequeue();
                }
            }
            Console.WriteLine("No more songs!");

        }
    }
}
