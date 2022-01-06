using System;

namespace petsFood2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysNumber = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());
            double foodEatenByDog = 0;
            double foodEatenByCat = 0;
            double biscuits = 0;

            for (int i = 1; i <= daysNumber; i++)
            {
                foodEatenByDog += double.Parse(Console.ReadLine());
                foodEatenByCat += double.Parse(Console.ReadLine());
                if (i % 10 == 3)
                {
                    biscuits = (foodEatenByDog + foodEatenByCat) * 0.1;
                    //foodEatenByDog += biscuits;
                    //foodEatenByCat += biscuits;
                }
            }
            double totalFoodEaten = foodEatenByDog + foodEatenByCat;
            double percentFoodEaten = totalFoodEaten / totalFood * 100;
            double totalFoodEatenByDog = foodEatenByDog / totalFoodEaten * 100;
            double totalFoodEatenByCat = foodEatenByCat / totalFoodEaten * 100;
            Console.WriteLine($"Total eaten biscuits: {Math.Abs(biscuits)}gr.");
            Console.WriteLine($"{percentFoodEaten:f2}% of the food has been eaten.");
            Console.WriteLine($"{totalFoodEatenByDog:f2}% eaten from the dog.");
            Console.WriteLine($"{totalFoodEatenByCat:f2}% eaten from the cat.");
        }
    }
}
