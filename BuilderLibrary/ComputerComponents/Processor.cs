using System;

namespace BuilderLibrary
{
    public class ProcessorComponent : AbstractComputerComponent
    {
        public ProcessorComponent(string name, double price, int count) : base(name, price, count)
        {
        }
    }
}
