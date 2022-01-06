using System;

namespace jhivkoDomashno
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string sex = Console.ReadLine();

            switch (sex)
            {
                case "m":
                    if (age<16)
                    {
                        Console.WriteLine("Master");
                    }
                    else
                    {
                        Console.WriteLine("Mr.");
                    }
                    break;
                case "f":
                    if (age < 16)
                    {
                        Console.WriteLine("Miss");
                    }
                    else
                    {
                        Console.WriteLine("Ms.");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
