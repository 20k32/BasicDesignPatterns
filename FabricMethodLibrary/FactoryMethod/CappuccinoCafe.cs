using System;

namespace FabricMethodLibrary
{
    public class CappuccinoCafe : AbstractCafe
    {
        private CappuccinoCoffee cappuccionCoffeCup = null!;
        public CappuccinoCafe(string name, Action<string> notifyUser) : base(name, notifyUser)
        {
        }

        public override AbstractCoffee GetCoffee()
        {
            return new CappuccinoCoffee(100, 400, NotifyUser);
        }

        public override void MakeCoffee()
        {
            cappuccionCoffeCup = new CappuccinoCoffee(100, 400, NotifyUser);
            cappuccionCoffeCup.PourExtraction();
            cappuccionCoffeCup.PourMilk();
            cappuccionCoffeCup.PourMilkFoam();
        }
    }
}
