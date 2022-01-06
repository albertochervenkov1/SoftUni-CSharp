using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int produced = 0;
            int days = 0;
            if (startingYield<100)
            {
                Console.WriteLine(days);
                Console.WriteLine(produced);
            }
            else
            {
                while (startingYield >= 100)
                {


                produced += startingYield - 26;
                startingYield -= 10;
                days++;

                }
                produced -= 26;

                Console.WriteLine(days);
                Console.WriteLine(produced);
            }

           

            
        }
    }
}
