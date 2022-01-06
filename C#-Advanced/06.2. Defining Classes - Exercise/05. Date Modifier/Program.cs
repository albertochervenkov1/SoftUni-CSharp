using System;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int days = DateModifier.GetDifferenceBetweenDates(firstDate, secondDate);

            Console.WriteLine(Math.Abs(days));
        }
    }
}
