using System;

namespace _07._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            char L = 'L';

            for (int i = floors; i >0; i--)
            {
                for (int j = 0; j < rooms; j++)
                {
                    if (i<0)
                    {
                        if (floors%2==0)
                        {
                            L = 'O';
                        }
                        else
                        {
                            L = 'A';
                        }
                    }
                    Console.Write($"{L}{i}{j}");
                }
                
            }
            Console.Write("\n");
            
        }
    }
}
