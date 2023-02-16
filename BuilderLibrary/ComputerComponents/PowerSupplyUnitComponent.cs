using Prototype;
using System;

namespace BuilderLibrary
{
    public class PowerSupplyUnitComponent : AbstractComputerComponent
    {
        public PowerSupplyUnitComponent(string name, double price, int count) : base(name, price, count)
        {  }

        public override IPrototype Clone()
        {
            return new PowerSupplyUnitComponent(Name, Price, Count);
        }
    }
}
