using Prototype;
using System;

namespace BuilderLibrary
{
    public class SystemUnitComponent : AbstractComputerComponent
    {
        public SystemUnitComponent(string name, double price, int count) : base(name, price, count)
        {
        }

        public override IPrototype Clone()
        {
            return new SystemUnitComponent(Name, Price,Count);
        }
    }
}
