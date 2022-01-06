using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float maxVolume = float.MinValue;
            string biggestModel = "";


            for (int i = 1; i <=n; i++)
            {
                string modelKeg = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                float volume = (float)(Math.PI * Math.Pow(radius, 2) * height);

                if (volume>maxVolume)
                {
                    maxVolume = volume;
                    biggestModel = modelKeg;
                }

            }
            Console.WriteLine(biggestModel);
        }
    }
}
