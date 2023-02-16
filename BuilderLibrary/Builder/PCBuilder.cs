namespace BuilderLibrary
{
    public class PCBuilder : AbstractBuilder
    {
        public PCBuilder(Product CurrentProduct) : base(CurrentProduct)
        { }

        public override void BuildCoolingSystem(AbstractComputerComponent coolingSystem)
        {
            product.AddProduct(coolingSystem);
        }

        public override void BuildMotherBroad(AbstractComputerComponent motherbroad)
        {
            product.AddProduct(motherbroad);
        }

        public override void BuildPowerSupplyUnit(AbstractComputerComponent powerSupplyUnit)
        {
            product.AddProduct(powerSupplyUnit);
        }

        public override void BuildProcessor(AbstractComputerComponent processor)
        {
            product.AddProduct(processor);
        }

        public override void BuildRAM(AbstractComputerComponent ram)
        {
            product.AddProduct(ram);
        }

        public override void BuildROM(AbstractComputerComponent rom)
        {
            product.AddProduct(rom);
        }

        public override void BuildSystemUnit(AbstractComputerComponent systemUnit)
        {
            product.AddProduct(systemUnit);
        }

        public override void BuildVideoCard(AbstractComputerComponent videoCard)
        {
            product.AddProduct(videoCard);
        }

        public override Product GetPC()
        {
            return product;
        }
    }
}
