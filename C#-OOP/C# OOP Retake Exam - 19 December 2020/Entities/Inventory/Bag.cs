using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory
{
    public abstract class Bag : IBag
    {
        private int capacity;
        private readonly List<Item> items;

        protected Bag(int capacity)
        {
            Capacity = capacity;
            items = new List<Item>();
        }

        public int Capacity
        {
            get => this.capacity;
            set
            {
                if (value <= 100)
                {
                    this.capacity = value;
                }

            }

        }
        public int Load => items.Sum(i => i.Weight);

        public IReadOnlyCollection<Item> Items => this.items.AsReadOnly();

        public void AddItem(Item item)
        {
            if (Load+item.Weight>Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.ExceedMaximumBagCapacity);
            }
            items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (items.Count==0)
            {
                throw new InvalidOperationException(ExceptionMessages.EmptyBag);
            }
            if (this.items.Any(i => i.GetType().Name == name) == false)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ItemNotFoundInBag, name));
            }
            var item = items.FirstOrDefault(i => i.GetType().Name == name);
            items.Remove(item);
            return item;
        }
    }
}
