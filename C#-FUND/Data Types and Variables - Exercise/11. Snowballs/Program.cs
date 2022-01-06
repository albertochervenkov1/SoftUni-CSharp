using System;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
             double numofSnowballs = double.Parse(Console.ReadLine());
            double snowballsSnow = 0;
            double snowballsTime = 0;
            double snowballsQuality = 0;
            double snowballsValue = 0;

            double highestSnow = int.MinValue;
            double highestTime = int.MinValue;
            double highestQuality = int.MinValue;
            double highestValue = double.MinValue;

            for (int i = 1; i <=numofSnowballs; i++)
            {
                 snowballsSnow = double.Parse(Console.ReadLine());
                 snowballsTime = double.Parse(Console.ReadLine());
                 snowballsQuality = double.Parse(Console.ReadLine());
                double snowballsValueFirst = (snowballsSnow / snowballsTime);
                snowballsValue = Math.Pow(snowballsValueFirst, snowballsQuality);


                if (snowballsValue>highestValue)
                {
                    highestSnow = snowballsSnow;
                    highestTime = snowballsTime;
                    highestQuality = snowballsQuality;
                    highestValue = snowballsValue;
                }

               
            }
            Console.WriteLine($"{highestSnow} : {highestTime} = {highestValue} ({highestQuality})");
            //{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})
        }
    }
}
