using System;

namespace FabricMethodLibrary
{
    public class LatteCafe : AbstractCafe
    {
        LatteCoffee latteCoffeeCup;
        public LatteCafe(string name, Action<string> notifyUser) : base(name, notifyUser)
        {
        } 

        public override AbstractCoffee GetCoffee()
        {
            return new LatteCoffee(70, 300, NotifyUser);
        }

        public override void MakeCoffee()
        {
            latteCoffeeCup = new LatteCoffee(70, 300, NotifyUser);
            latteCoffeeCup.PourExtraction();
            latteCoffeeCup.PourMilk();
            latteCoffeeCup.PourMilkFoam();
        }
    }
}
