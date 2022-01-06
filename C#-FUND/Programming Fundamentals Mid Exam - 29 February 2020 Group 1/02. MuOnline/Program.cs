using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rooms = Console.ReadLine().Split('|').ToList();
            int initialHealth = 100;
            int initialBitcoin = 0;
            int health = initialHealth;
            int totalBitcoins = 0;
            bool died = false;

            for (int i = 0; i < rooms.Count; i++)
            {
                string command = rooms[i];
                string[] splitted = command.Split();
                int num = int.Parse(splitted[1]);
                if (splitted[0]=="potion")
                {
                    if (health<initialHealth)
                    {
                        if (health+num<initialHealth)
                        {
                            health += num;
                            Console.WriteLine($"You healed for {num} hp.");
                            Console.WriteLine($"Current health: {health} hp.");

                        }
                        else
                        {
                            int tempHealth = health;
                            health = 100;
                            
                            Console.WriteLine($"You healed for {health-tempHealth} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        
                    }
                }
                else if (splitted[0]=="chest")
                {
                    totalBitcoins += num;
                    Console.WriteLine($"You found {num} bitcoins.");
                }
                else
                {
                    health -= num;
                    if (health>0)
                    {
                        Console.WriteLine($"You slayed {splitted[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {splitted[0]}.");
                        Console.WriteLine($"Best room: {i+1}");
                        died = true;
                        break;
                    }
                }
            }
            if (died==false)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {totalBitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
