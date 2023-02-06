using System;

namespace FabricMethodLibrary
{
    public class AmericanoCafe : AbstractCafe
    {
        private AmericanoCoffeee americanoCoffeeCup;
        public AmericanoCafe(string name, Action<string> notifyUser) : base(name, notifyUser)
        {
        }

        public override AbstractCoffee GetCoffee()
        {
            return new AmericanoCoffeee(10, 100, NotifyUser);
        }

        public override void MakeCoffee()
        {
            americanoCoffeeCup = new AmericanoCoffeee(10, 100, NotifyUser);

            americanoCoffeeCup.PourExtraction();
            americanoCoffeeCup.PourWater();
        }
    }
}
