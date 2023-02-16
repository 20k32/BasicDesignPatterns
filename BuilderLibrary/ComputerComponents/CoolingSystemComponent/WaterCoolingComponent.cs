using Prototype;
using System;

namespace BuilderLibrary
{
    public class WaterCoolingComponent : AbstractCoolingSystemComponent
    {
        public WaterCoolingComponent(string name, double price, int count) : base(name, price, count)
        {
        }

        public override IPrototype Clone()
        {
            return new WaterCoolingComponent(Name, Price, Count);
        }
    }
}
