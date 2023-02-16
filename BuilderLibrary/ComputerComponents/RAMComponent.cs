using Prototype;
using System;

namespace BuilderLibrary
{
    public class RAMComponent : AbstractComputerComponent
    {
        public RAMComponent(string name, double price, int count) : base(name, price, count)
        {
        }

        public override IPrototype Clone()
        {
            return new RAMComponent(Name, Price, Count);
        }
    }
}
