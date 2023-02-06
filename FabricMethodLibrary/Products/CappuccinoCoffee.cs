using System;

namespace FabricMethodLibrary
{
    public class CappuccinoCoffee : AbstractCoffee
    {
        public CappuccinoCoffee(int sugar, int mililitersOfEssention, Action<string> notifyUser) : base(TasteEnum.Unbalanced, FragranceEnum.Mild, AcidityEnum.Moderate,sugar, mililitersOfEssention, notifyUser)
        {
        }

        public void PourExtraction()
        {
            NotifyUser.Invoke("CappuccionCoffee extraction poured");
        }

        public void PourMilkFoam()
        {
            NotifyUser.Invoke("MilkFoam poured");
        }

        public void PourMilk()
        {
            NotifyUser.Invoke("Milk poured");
        }
    }
}
