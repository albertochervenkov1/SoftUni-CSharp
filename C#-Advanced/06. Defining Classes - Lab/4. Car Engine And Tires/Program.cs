using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Engine v12 = new Engine(580, 1200);
            Tire[] tires = new Tire[]
                {
                    new Tire(2018,2.3),
                    new Tire(2018,2.2),
                    new Tire(2018,2.5),
                    new Tire(2018,2.3)

                };

            Car Bmw = new Car("BMW", "X6", 2012, 5003,-50, v12, tires);

        }
    }
}
