using Prototype;
using System;

namespace BuilderLibrary
{
    public class CoolerComponent : AbstractCoolingSystemComponent
    {
        public CoolerComponent(string name, double price, int count) : base(name, price, count)
        {
        }

        public override IPrototype Clone()
        {
            return new CoolerComponent(Name, Price, Count);
        }
    }
}
