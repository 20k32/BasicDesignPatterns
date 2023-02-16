using Prototype;

namespace BuilderLibrary
{
    public class ROMComponent : AbstractComputerComponent
    {
        public ROMComponent(string name, double price, int count) : base(name, price, count)
        {
        }

        public override IPrototype Clone()
        {
            return new ROMComponent(Name, Price, Count);
        }
    }
}
