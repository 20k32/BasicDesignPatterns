using System;
using System.Linq;
using System.Windows.Automation.Peers;

namespace BuilderLibrary
{
    public class Client
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
    }
}
