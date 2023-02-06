using System;

namespace FabricMethodLibrary
{
    public abstract class AbstractCoffee
    {
        protected TasteEnum Taste;
        protected FragranceEnum Fragrance;
        protected AcidityEnum Acidity;
        protected int Sugar;
        protected int MililitersOfEssention;
        protected Action<string> NotifyUser;

        public AbstractCoffee(TasteEnum taste, FragranceEnum fragrance, AcidityEnum acidity, int sugar, int mililitersOfEssention, Action<string> notifyUser)
        {
            Taste = taste;
            Fragrance = fragrance;
            Acidity = acidity;
            Sugar = sugar;
            MililitersOfEssention = mililitersOfEssention;
            NotifyUser = notifyUser;
        }
        public override string ToString()
        {
            return $"Taste: {Taste}, Fragrance: {Fragrance}, Acidity: {Acidity}, Sugar: {Sugar} g, Mililiters: {MililitersOfEssention} ml";
        }
    }
}
