namespace BuilderLibrary
{
    public class ClientFluentBuilder
    {
        private Client client;

        public ClientFluentBuilder(AbstractBuilder Builder)
        {
            client = new Client(Builder);
        }

        public ClientFluentBuilder SetMotherBroad(AbstractComputerComponent MotherBroad)
        {
            client.MotherBroad = MotherBroad;
            return this;
        }

        public ClientFluentBuilder SetPowerSupplyUnit(AbstractComputerComponent PowerSupplyUnit)
        {
            client.PowerSupplyUnit = PowerSupplyUnit;
            return this;
        }

        public ClientFluentBuilder SetProcessor(AbstractComputerComponent Processor)
        {
            client.Processor = Processor;
            return this;
        }

        public ClientFluentBuilder SetRAM(AbstractComputerComponent RAM)
        {
            client.RAM = RAM;
            return this;
        }

        public ClientFluentBuilder SetROM(AbstractComputerComponent ROM)
        {
            client.ROM = ROM;
            return this;
        }

        public ClientFluentBuilder SetSystemUnit(AbstractComputerComponent SystemUnit)
        {
            client.SystemUnit = SystemUnit;
            return this;
        }

        public ClientFluentBuilder SetVideoCard(AbstractComputerComponent VideoCard)
        {
            client.VideoCard = VideoCard;
            return this;
        }

        public ClientFluentBuilder SetCoolingSystem(AbstractComputerComponent CoolingSystem)
        {
            client.CoolingSystem = CoolingSystem;
            return this;
        }

        public Client Build()
        {
            return client;
        }
    }
}
