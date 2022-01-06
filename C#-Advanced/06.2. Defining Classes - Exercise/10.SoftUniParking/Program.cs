using System;

namespace SoftUniParking

{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Parking parking = new Parking(1);
            var car = new Car("Skoda", "Fabia", 65, "CC1856BG");
            var car2 = new Car("Audi", "A3", 110, "EB8787MN");

            Console.WriteLine(parking.AddCar(car));
            Console.WriteLine(parking.AddCar(car));
            Console.WriteLine(parking.AddCar(car2));

        }
    }
}
