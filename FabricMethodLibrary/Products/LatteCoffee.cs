using System;

namespace FabricMethodLibrary
{
    public class LatteCoffee : AbstractCoffee
    {
        public LatteCoffee(int sugar, int mililitersOfEssention, Action<string> notifyUser) : base(TasteEnum.Harmonious, FragranceEnum.Mild, AcidityEnum.Unexpressed, sugar, mililitersOfEssention, notifyUser)
        {
        }

        public void PourExtraction()
        {
            NotifyUser.Invoke("LatteCoffee extraction poured");
        }

        public void PourMilkFoam()
        {
            NotifyUser.Invoke("MilkFoam extraction poured");
        }

        public void PourMilk()
        {
            NotifyUser.Invoke("Milk extraction poured");
        }
    }
}
