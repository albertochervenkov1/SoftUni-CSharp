using System;

namespace Shapes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IDrawable rectangle = new Recatangle(6,4);
            rectangle.Draw();
            IDrawable circle = new Circle(3);
            circle.Draw();
        }
    }
}
