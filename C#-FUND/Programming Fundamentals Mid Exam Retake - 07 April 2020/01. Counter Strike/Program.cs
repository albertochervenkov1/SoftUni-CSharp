using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            short initialEnergy = short.Parse(Console.ReadLine());
            
            string input = string.Empty;

            short count= 0;
            bool end = false;

            while (true)
            {
                input = Console.ReadLine();   
                if (input!="End of battle")
                {
                    short distance = short.Parse(input);

                    if (initialEnergy - distance < 0)
                    {
                        end = false;
                        break;
                    }

                    initialEnergy -= distance;
                    count++;
                    if (count % 3 == 0)
                    {
                        initialEnergy += count;
                    }
                }
                else
                {
                    end = true;
                    break;
                }

            }
            if (end == true)
            {
                Console.WriteLine($"Won battles: {count}. Energy left: {initialEnergy}");
            }
            else
            {
                Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {initialEnergy} energy");
            }
        }
    }
}
