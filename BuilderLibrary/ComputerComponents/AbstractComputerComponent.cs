using Prototype;
using System;
using System.Diagnostics;
using System.Linq;

namespace BuilderLibrary
{
    public abstract class AbstractComputerComponent : IPrototype
    {
        private double price;
        public double Price
        {
            get => price;
            set
            {
                if (value < 0.1d)
                {
                    throw new Exception("the price cannot be less than 0.1");
                }
                price = value;
            }
        }

        private int count;
        public int Count
        {
            get => count;
            set
            {
                if (value < 0)
                {
                    throw new Exception("the count cannot be less than 0");
                }
                count = value;
            }
        }

        public string Name { get; set; } = null!;

        public AbstractComputerComponent(string name, double price, int count)
        {
            Price = price;
            Count = count;
            Name = name;
        }

        public override string ToString()
        {
            return "Product: " + Name + ", Price: " + Price + ".";
        }

        public IPrototype DeepCopyClone()
        {
            return Clone();
        }
        public abstract IPrototype Clone();
    }
}
