using System;

namespace BuilderLibrary
{
    public class VideoCardComponent : AbstractComputerComponent
    {
        public VideoCardComponent(string name, double price, int count) : base(name, price, count)
        {
        }
    }
}
