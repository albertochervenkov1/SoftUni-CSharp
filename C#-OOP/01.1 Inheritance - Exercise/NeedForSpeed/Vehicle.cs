using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        public Vehicle(int hp,double fuel)
        {
            this.HorsePower = hp;
            this.Fuel = fuel;
        }
        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public virtual double FuelConsumption=>DefaultFuelConsumption;

        public virtual void Drive(double kilometers) 
        {
            bool canDrive = this.Fuel - this.FuelConsumption * kilometers>=0;
            if (canDrive)
            {
                this.Fuel -= kilometers * this.FuelConsumption;

            }
            
        }
    }
}
