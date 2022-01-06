using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
//    •	Make: string
//•	Model: string
//•	HorsePower: int
//•	RegistrationNumber: string

    public class Car
    {
        public Car(string make,string model,int horsepower,string registratioNumber)
        {
            this.Model = model;
            this.Make = make;
            this.HorsePower = horsepower;
            this.RegistrationNumber = registratioNumber;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public override string ToString()
        {
            string res = $"Make: {this.Make}" + Environment.NewLine;
            res += $"model: {this.Model}" + Environment.NewLine;
            res += $"HorsePower: {this.HorsePower}" + Environment.NewLine;
            res += $"RegistrationNumber: {this.RegistrationNumber}";
            return res;
            
        }

    }
}
