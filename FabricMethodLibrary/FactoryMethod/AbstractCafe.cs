using System;

namespace FabricMethodLibrary
{
    public abstract class AbstractCafe
    {
        protected string Name;
        protected Action<string> NotifyUser;

        public AbstractCafe(string name, Action<string> notifyUser)
        {
            Name = name;
            NotifyUser = notifyUser;
        }

        public abstract AbstractCoffee GetCoffee();

        public abstract void MakeCoffee();

        public override string ToString()
        {
            return Name;
        }
    }
}
