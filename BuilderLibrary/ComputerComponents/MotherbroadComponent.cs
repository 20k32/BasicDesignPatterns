using Prototype;

namespace BuilderLibrary
{
    public class MotherbroadComponent : AbstractComputerComponent
    {
        public MotherbroadComponent(string name, double price, int count) : base(name, price, count)
        {  }

        public override IPrototype Clone()
        {
            return new MotherbroadComponent(Name, Price, Count);
        }
    }
}
