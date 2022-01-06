using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parking = new HashSet<string>();

            string[] input = Console.ReadLine().Split(", ");
            while (input[0]!="END")
            {
                string command = input[0];
                string plate = input[1];
                if (command=="IN")
                {
                    parking.Add(plate);
                }
                else
                {
                    parking.Remove(plate);
                }

                input = Console.ReadLine().Split(", ");
            }
            if (parking.Count==0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in parking)
                {
                    Console.WriteLine(item);
                }
            }
            
        }
    }
}
