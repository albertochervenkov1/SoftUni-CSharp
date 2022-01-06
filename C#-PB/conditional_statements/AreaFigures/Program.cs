using System;

namespace AreaFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();//tip na figurata

            if (figure=="square")
            {
                double stranasquare = double.Parse(Console.ReadLine());
                double areasquare = stranasquare * stranasquare;
                Console.WriteLine($"{areasquare:F3}");
            }

            else if (figure=="rectangle")
            {
                double firsstrana = double.Parse(Console.ReadLine());
                double secondstrana = double.Parse(Console.ReadLine());
                double areasquare = firsstrana * secondstrana;

                Console.WriteLine($"{areasquare:F3}"  );

            }

            else if (figure=="circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double stranacircle = Math.PI * (radius*radius);
                Console.WriteLine($"{stranacircle:F3}");
            }

            else if (figure=="triangle")
            {
                double length = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double areatriangle = length * (height / 2);
                Console.WriteLine($"{areatriangle:F2}");
            }
        }
    }
}
