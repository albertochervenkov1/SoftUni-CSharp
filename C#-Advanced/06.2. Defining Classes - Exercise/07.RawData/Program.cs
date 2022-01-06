using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> list = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                //tire1
                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);
                //tire2
                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);
                //tire3
                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);
                //tire4
                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);

                list.Add(new Car(model, new Engine(engineSpeed, enginePower), new Cargo(cargoWeight, cargoType), new List<Tire> { new Tire(tire1Pressure, tire1Age), new Tire(tire2Pressure, tire2Age), new Tire(tire3Pressure, tire3Age), new Tire(tire4Pressure, tire4Age) }));
            }
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                list.Where(c => c.Cargo.CargoType == "fragile").Where(c => c.Tires.Any(t => t.TirePressure < 1)).Select(c => c.Model).ToList().ForEach(m => Console.WriteLine(m));
            }
            else if (command == "flamable")
            {
                list.Where(c => c.Cargo.CargoType == "flamable").Where(c => c.Engine.EnginePower > 250).Select(c => c.Model).ToList().ForEach(m => Console.WriteLine(m));
            }

        }
      
        }
    }

