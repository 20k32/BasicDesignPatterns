using Prototype;
using System;

namespace BuilderLibrary
{
    public class Client : IPrototype
    {
        private AbstractBuilder builder = null!;

        public AbstractComputerComponent MotherBroad { get; set; } = null!;
        public AbstractComputerComponent PowerSupplyUnit { get; set; } = null!;
        public AbstractComputerComponent Processor { get; set; } = null!;
        public AbstractComputerComponent RAM { get; set; } = null!;
        public AbstractComputerComponent ROM { get; set; } = null!;
        public AbstractComputerComponent SystemUnit { get; set; } = null!;
        public AbstractComputerComponent VideoCard { get; set; } = null!;
        public AbstractComputerComponent CoolingSystem { get; set; } = null!;

        public Action<string> NotifyUser { get; set; } = null!;


        public Client(AbstractBuilder Builder)
        {
            builder = Builder;
        }

        public void Construct()
        {
            builder.BuildMotherBroad(MotherBroad);
            builder.BuildPowerSupplyUnit(PowerSupplyUnit);
            builder.BuildProcessor(Processor);
            builder.BuildRAM(RAM);
            builder.BuildROM(ROM);
            builder.BuildSystemUnit(SystemUnit);
            builder.BuildVideoCard(VideoCard);
            builder.BuildCoolingSystem(CoolingSystem);
        }

        public void GetList()
        {
            foreach (AbstractComputerComponent item in builder.GetPC().GetPCComponents())
            {
                NotifyUser?.Invoke(item.ToString());
            }
        }

        public double GetTotalPrice()
        {
            double result = 0d;
            foreach (AbstractComputerComponent item in builder.GetPC().GetPCComponents())
            {
                result += item.Price;
            }
            return result;
        }

        public IPrototype DeepCopyClone()
        {
            AbstractBuilder builderClone = (AbstractBuilder)builder.DeepCopyClone();
            return new Client(builderClone)
            {
                MotherBroad = (AbstractComputerComponent)this.MotherBroad.Clone(),
                PowerSupplyUnit = (AbstractComputerComponent)this.PowerSupplyUnit.Clone(),
                Processor = (AbstractComputerComponent)this.Processor.Clone(),
                RAM = (AbstractComputerComponent)this.RAM.Clone(),
                ROM = (AbstractComputerComponent)this.ROM.Clone(),
                SystemUnit = (AbstractComputerComponent)this.SystemUnit.Clone(),
                VideoCard = (AbstractComputerComponent)this.VideoCard.Clone(),
                CoolingSystem = (AbstractComputerComponent)this.CoolingSystem.Clone(),
            };
        }

        public IPrototype Clone()
        {
            AbstractBuilder builderClone = (AbstractBuilder)builder.Clone();
            return new Client(builderClone)
            {
                MotherBroad = this.MotherBroad,
                PowerSupplyUnit = this.PowerSupplyUnit,
                Processor = this.Processor,
                RAM = this.RAM,
                ROM = this.ROM,
                SystemUnit = this.SystemUnit,
                VideoCard = this.VideoCard,
                CoolingSystem = this.CoolingSystem,
            };
        }
    }
}
