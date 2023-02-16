using Prototype;
using System;

namespace BuilderLibrary
{
    public abstract class AbstractBuilder : IPrototype
    {
        protected Product product;

        public AbstractBuilder(Product CurrentProduct)
        {
            product = CurrentProduct;
        }

        public abstract void BuildMotherBroad(AbstractComputerComponent motherbroad);

        public abstract void BuildSystemUnit(AbstractComputerComponent systemUnit);

        public abstract void BuildROM(AbstractComputerComponent rom);

        public abstract void BuildRAM(AbstractComputerComponent ram);

        public abstract void BuildProcessor(AbstractComputerComponent processor);

        public abstract void BuildPowerSupplyUnit(AbstractComputerComponent powerSuppyUnit);

        public abstract void BuildVideoCard(AbstractComputerComponent videoCard);

        public abstract void BuildCoolingSystem(AbstractComputerComponent coolingSystem);

        public abstract Product GetPC();

        public abstract IPrototype DeepCopyClone();

        public abstract IPrototype Clone();
    }
}
