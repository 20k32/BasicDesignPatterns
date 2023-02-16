using Prototype;
using System;

namespace BuilderLibrary
{
    public class ProcessorComponent : AbstractComputerComponent
    {
        public ProcessorComponent(string name, double price, int count) : base(name, price, count)
        {
        }

        public override IPrototype Clone()
        {
            return new ProcessorComponent(Name, Price ,Count);
        }
    }
}
