using System;

namespace FabricMethodLibrary
{
    public class AmericanoCoffeee : AbstractCoffee
    {
        public AmericanoCoffeee(int sugar, int mililitersOfEssention, Action<string> notifyUser) : base(TasteEnum.Difficult, FragranceEnum.AboveAverage, AcidityEnum.Intense, sugar, mililitersOfEssention, notifyUser)
        {
            
        }

        public void PourExtraction()
        {
            NotifyUser.Invoke("AmericanoCoffee extraction poured");
        }

        public void PourWater()
        {
            NotifyUser.Invoke("Water poured");
        }
    }
}
