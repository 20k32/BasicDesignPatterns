using Prototype;
using System;

namespace BuilderLibrary
{
    public class VideoCardComponent : AbstractComputerComponent
    {
        public VideoCardComponent(string name, double price, int count) : base(name, price, count)
        {
        }

        public override IPrototype Clone()
        {
            return new VideoCardComponent(Name, Price, Count);
        }
    }
}
