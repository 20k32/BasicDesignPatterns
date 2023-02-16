using System;

namespace BuilderLibrary
{
    public class CoolerComponent : AbstractCoolingSystemComponent
    {
        public CoolerComponent(string name, double price, int count) : base(name, price, count)
        {
        }
    }
}
