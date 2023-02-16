using System;

namespace FabricMethodLibrary
{
    public class EspressoCafe : AbstractCafe
    {
        private EspressoCoffee espressoCup = null!;

        public EspressoCafe(string name, Action<string> notifyUser) : base(name, notifyUser)
        {
        }

        public override AbstractCoffee GetCoffee()
        {
            return new EspressoCoffee(20, 100, NotifyUser);
        }

        public override void MakeCoffee()
        {
            espressoCup = new EspressoCoffee(20, 100, NotifyUser);
            espressoCup.PourExtraction();
        }
    }
}
