using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Models.Products.Computers
{
    public abstract class Computer : Product,IComputer
    {
        private readonly List<IComponent> components;
        private readonly List<IPeripheral> peripherals;
        protected Computer(int id, string manufacturer, string model, decimal price, double overallPerformance) : base(id, manufacturer, model, price, overallPerformance)
        {
            components = new List<IComponent>();
            peripherals = new List<IPeripheral>();
        }

        public IReadOnlyCollection<IComponent> Components => components.AsReadOnly();

        public IReadOnlyCollection<IPeripheral> Peripherals => peripherals.AsReadOnly();
        public override double OverallPerformance => CalculateOveralPerformace();
        public override decimal Price => CalculateTotalPrice();

        public void AddComponent(IComponent component)
        {
            if (components.Any(x=>x.GetType()==component.GetType()))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingComponent, component.GetType().Name, this.GetType().Name, this.Id));
            }
            components.Add(component);
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            if (peripherals.Any(p=>p.GetType()==peripheral.GetType()))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingPeripheral, peripheral.GetType().Name, this.GetType().Name, this.Id));
            }
            peripherals.Add(peripheral);
        }

        public IComponent RemoveComponent(string componentType)
        {
            IComponent component = this.components.FirstOrDefault(x => x.GetType().Name == componentType);
            if (component==null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.NotExistingComponent, componentType, this.GetType().Name, this.Id));
            }
            components.Remove(component);
            return component;
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            IPeripheral peripheral = this.peripherals.FirstOrDefault(x => x.GetType().Name == peripheralType);

            if (peripheral == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.NotExistingPeripheral,
                    peripheralType, this.GetType().Name, this.Id));
            }

            this.peripherals.Remove(peripheral);
            return peripheral;
        }
        private double CalculateOveralPerformace()
        {
            if (this.components.Count == 0)
            {
                return base.OverallPerformance;
            }

            double result = base.OverallPerformance + this.components.Average(x => x.OverallPerformance);
            return result;
        }
        private decimal CalculateTotalPrice()
        {
            decimal result = this.components.Sum(x => x.Price) + this.peripherals.Sum(x => x.Price) + this.Price; // TODO this.Price to be chnaged for base.Price if recursion happenned
            return result;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());

            sb.AppendLine($" Components ({components.Count}):");
            foreach (var item in components)
            {
                sb.AppendLine($"  {item}");
            }

            sb.AppendLine($" Peripherals ({peripherals.Count}); Average Overall Performance ({peripherals.Average(x=>x.OverallPerformance)}):");
            foreach (var peripheral in this.peripherals)
            {
                sb.AppendLine($"  {peripheral}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
