using System;

namespace _1._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            byte firstEmployee = byte.Parse(Console.ReadLine());
            byte secondEmployee = byte.Parse(Console.ReadLine());
            byte thirdEmployee = byte.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());

            int peoplePerHour = firstEmployee + secondEmployee + thirdEmployee;
            int hours = 0;
            //while (peopleCount > 0)
            //{
            //    hours++;
            //    if (hours % 4 == 0)
            //    {
            //        continue;
            //    }
            //    peopleCount -= peoplePerHour;
            //}
            
            for (int i = 0; i < peopleCount; i++)
            {
                if (hours % 4 == 0)
                {
                    continue;
                }
                peopleCount -= peoplePerHour;

            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
