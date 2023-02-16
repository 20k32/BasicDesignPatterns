using System;

namespace BuilderLibrary
{
    public abstract class AbstractCoolingSystemComponent : AbstractComputerComponent
    {
        public AbstractCoolingSystemComponent(string name, double price, int count) : base(name, price, count)
        {
        }
    }
}
