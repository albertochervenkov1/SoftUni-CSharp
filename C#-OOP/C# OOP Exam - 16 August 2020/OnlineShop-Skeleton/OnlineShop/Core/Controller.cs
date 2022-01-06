using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Core
{
    public class Controller : IController
    {
        private List<IComputer> computers;
        private List<IComponent> components;
        private List<IPeripheral> peripherals;
        public Controller()
        {
            computers = new List<IComputer>();
            peripherals = new List<IPeripheral>();
            components = new List<IComponent>();
        }

        public string AddComponent(int computerId, int id, string componentType, string manufacturer, string model, decimal price, double overallPerformance, int generation)
        {
            DoesComputerExists(computerId);

            if (this.components.Any(x => x.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingComponentId);
            }

            IComponent componnet = componentType switch
            {
                nameof(CentralProcessingUnit) => new CentralProcessingUnit(id, manufacturer, model, price, overallPerformance, generation),
                nameof(Motherboard) => new Motherboard(id, manufacturer, model, price, overallPerformance, generation),
                nameof(PowerSupply) => new PowerSupply(id, manufacturer, model, price, overallPerformance, generation),
                nameof(RandomAccessMemory) => new RandomAccessMemory(id, manufacturer, model, price, overallPerformance, generation),
                nameof(VideoCard) => new VideoCard(id, manufacturer, model, price, overallPerformance, generation),
                nameof(SolidStateDrive) => new SolidStateDrive(id, manufacturer, model, price, overallPerformance, generation),
                _ => throw new ArgumentException(ExceptionMessages.InvalidComponentType)
            };

            this.computers.FirstOrDefault(x => x.Id == computerId).AddComponent(componnet);
            this.components.Add(componnet);
            return string.Format(SuccessMessages.AddedComponent,
                componentType, id, computerId);
        }

        public string AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {
            if (this.computers.Any(x => x.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingComputerId);
            }

            IComputer computer = computerType switch
            {
                nameof(Laptop) => new Laptop(id, manufacturer, model, price),
                nameof(DesktopComputer) => new DesktopComputer(id, manufacturer, model, price),
                _ => throw new ArgumentException(ExceptionMessages.InvalidComputerType)
            };

            this.computers.Add(computer);
            return string.Format(SuccessMessages.AddedComputer, id);
        }

        public string AddPeripheral(int computerId, int id, string peripheralType, string manufacturer, string model, decimal price, double overallPerformance, string connectionType)
        {
            DoesComputerExists(computerId);

            if (this.peripherals.Any(x => x.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingPeripheralId);
            }

            IPeripheral peripheral = peripheralType switch
            {
                nameof(Headset) => new Headset(id, manufacturer, model, price, overallPerformance, connectionType),
                nameof(Keyboard) => new Keyboard(id, manufacturer, model, price, overallPerformance, connectionType),
                nameof(Monitor) => new Monitor(id, manufacturer, model, price, overallPerformance, connectionType),
                nameof(Mouse) => new Mouse(id, manufacturer, model, price, overallPerformance, connectionType),
                _ => throw new ArgumentException(ExceptionMessages.InvalidPeripheralType)
            };

            this.computers.FirstOrDefault(x => x.Id == computerId).AddPeripheral(peripheral);
            this.peripherals.Add(peripheral);
            return string.Format(SuccessMessages.AddedPeripheral,
                peripheralType, id, computerId);
        }

        public string BuyBest(decimal budget)
        {
            IComputer computer = this.computers.Where(x => x.Price <= budget).OrderByDescending(X => X.OverallPerformance).FirstOrDefault();

            if (computer == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CanNotBuyComputer, budget));
            }

            this.computers.Remove(computer);
            return computer.ToString();
        }
        public string BuyComputer(int id)
        {
            DoesComputerExists(id);
            IComputer computer = this.computers.FirstOrDefault(x => x.Id == id);
            this.computers.Remove(computer);
            return computer.ToString();
        }

        public string GetComputerData(int id)
        {
            DoesComputerExists(id);

            return this.computers.FirstOrDefault(x => x.Id == id).ToString();
        }

        public string RemoveComponent(string componentType, int computerId)
        {
            DoesComputerExists(computerId);
            IComponent componenet = this.computers.FirstOrDefault(x => x.Id == computerId).RemoveComponent(componentType);
            return string.Format(SuccessMessages.RemovedComponent,
               componentType, componenet.Id);
        }

        public string RemovePeripheral(string peripheralType, int computerId)
        {
            DoesComputerExists(computerId);
            IPeripheral peripheral = this.computers.FirstOrDefault(x => x.Id == computerId).RemovePeripheral(peripheralType);
            return string.Format(SuccessMessages.RemovedPeripheral,
               peripheralType, peripheral.Id);
        }
        private bool DoesComputerExists(int id)
        {
            if (!computers.Any(c => c.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }
            return true;
        }
    }

        
    
}
