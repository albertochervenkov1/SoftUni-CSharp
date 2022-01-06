using System;

namespace DANCEHALL
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());

            //hall area
            double hallarea = l * w;
            double wardrobearea = a * a;
            double bencharea = hallarea / 10;

            double freespace = hallarea - wardrobearea - bencharea;
            freespace = freespace * 10000;

            double dancers = Math.Floor(freespace / 7040);
            Console.WriteLine(dancers);


        }
    }
}
