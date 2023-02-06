using System;

namespace FabricMethodLibrary
{
    public sealed class EspressoCoffee : AbstractCoffee
    {
        public EspressoCoffee(int sugar, int mililiters, Action<string> notifyUser) : base(TasteEnum.SuperHarmonious, FragranceEnum.Strong, AcidityEnum.Moderate, sugar, mililiters, notifyUser)
        {
        }

        public void PourExtraction()
        {
            NotifyUser.Invoke("Espresso coffee extraction poured");
        }
    }
}
