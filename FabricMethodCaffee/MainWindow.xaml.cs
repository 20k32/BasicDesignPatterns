using System.Windows;
using System.Collections.Generic;
using BuilderLibrary;
using System;
using Prototype;


namespace FabricMethodCaffee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double standartMotherbroadPrice = 1000d;
        private double standartPowerSupplyUnitPrice = 800d;
        private double standartProcessorPrice = 1500d;
        private double standartRAMPrice = 1200d;
        private double standartROMPrice = 1000d;
        private double statndartSystemUnitPrice = 1600d;
        private double standartVideoCardPrice = 3000d;
        private double standartCoolerCoolingSystemPrice = 900d;
        private double standartWaterCoolingSystemPrice = 1900d;

        private List<string> MotherbroadModels = new List<string>() { "Asus Prime", "Asus TUF", "MSI B41", "Gigabyte S300M" };
        private List<string> PowerSupplyUintModels = new List<string>() { "beQuiet SystemPower 10", "Aerocool WX Plus", "ChiefTEC Ecol GPE", "Zalman GigaMax" };
        private List<string> ProcessorModels = new List<string>() { "AMD Ryzen 5 3600", "Intel Core i5 11300h", "Intel Core I7 13700k", "AMD Ryzen 9 7950X" };
        private List<string> RAMModels = new List<string>() { "Kingston Fury ddr4-3200", "Goodram ddr4-2666", "G-Skill ddr5-6000", "G-Skill ddr5-7200" };
        private List<string> ROMModels = new List<string>() { "Goodram SSD", "Kingston NV2", "Samsung 980", "Kingston XS2000" };
        private List<string> SystemUnitModels = new List<string>() { "Versum Advantage V3", "Artline gaming x51", "Argus E5", "Deepcool matrex 55 v3" };
        private List<string> VideCardModels = new List<string>() { "Asus Gegforse RTX 3060", "MSI Geforce RTX 4080", "Gigabyte RTX 4090", "MSI Geforce RTX 4090" };
        private List<string> CoolingSystemModels = new List<string>() { "Enermax ETS F40", "PcCooler Paladin", "Thermaltake floe dx", "Noctua NH-D15S" };

        private ClientFluentBuilder client = null!;
        private Client currentClient = null!;
        private Client clonedClient = null!;
        
        public MainWindow()
        {
            InitializeComponent();
            MotherbroadBox.ItemsSource = MotherbroadModels;
            PowerSupplyUnitBox.ItemsSource = PowerSupplyUintModels;
            ProcessorBox.ItemsSource = ProcessorModels;
            RAMBox.ItemsSource = RAMModels;
            ROMBox.ItemsSource = ROMModels;
            SystemUnitBox.ItemsSource = SystemUnitModels;
            VideoCardBox.ItemsSource = VideCardModels;
            CoolingSystemBox.ItemsSource = CoolingSystemModels;

            MotherbroadBox.SelectedIndex = PowerSupplyUnitBox.SelectedIndex =
                ProcessorBox.SelectedIndex = RAMBox.SelectedIndex =
                ROMBox.SelectedIndex = SystemUnitBox.SelectedIndex =
                VideoCardBox.SelectedIndex = CoolingSystemBox.SelectedIndex = 0;

            client = new ClientFluentBuilder(new PCBuilder(new Product()));
        }

        private void BuildButton_Click(object sender, RoutedEventArgs e)
        {
            client = new ClientFluentBuilder(new PCBuilder(new Product()));

            int index = MotherbroadBox.SelectedIndex;
            AbstractComputerComponent ComputerComponent = new MotherbroadComponent(MotherbroadModels[index], (index + 1) * standartMotherbroadPrice, 1);
            client.SetMotherBroad(ComputerComponent);

            index = PowerSupplyUnitBox.SelectedIndex;
            ComputerComponent = new PowerSupplyUnitComponent(PowerSupplyUintModels[index], (index + 1) * standartPowerSupplyUnitPrice, 1);
            client.SetPowerSupplyUnit(ComputerComponent);

            index = ProcessorBox.SelectedIndex;
            ComputerComponent = new ProcessorComponent(ProcessorModels[index], (index + 1) * standartProcessorPrice, 1);
            client.SetProcessor(ComputerComponent);

            index = RAMBox.SelectedIndex;
            ComputerComponent = new RAMComponent(RAMModels[index], (index + 1) * standartRAMPrice, 1);
            client.SetRAM(ComputerComponent);

            index = ROMBox.SelectedIndex;
            ComputerComponent = new ROMComponent(ROMModels[index], (index + 1) * standartROMPrice, 1);
            client.SetROM(ComputerComponent);

            index = SystemUnitBox.SelectedIndex;
            ComputerComponent = new SystemUnitComponent(SystemUnitModels[index], (index + 1) * statndartSystemUnitPrice, 1);
            client.SetSystemUnit(ComputerComponent);

            index = VideoCardBox.SelectedIndex;
            ComputerComponent = new VideoCardComponent(VideCardModels[index], (index + 1) * standartVideoCardPrice, 1);
            client.SetVideoCard(ComputerComponent);

            index = CoolingSystemBox.SelectedIndex;
            if (index < 2)
            {
                ComputerComponent = new CoolerComponent(CoolingSystemModels[index], (index + 1) * standartCoolerCoolingSystemPrice, 1);
            }
            else
            {
                ComputerComponent = new WaterCoolingComponent(CoolingSystemModels[index], (index + 1) * standartWaterCoolingSystemPrice, 1);
            }
            client.SetCoolingSystem(ComputerComponent);

            currentClient = client.Build();

            currentClient.NotifyUser = NotifyUserInTextBox;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (currentClient != null)
            {
                currentClient.Construct();
                currentClient.GetList();
                NotifyUserInTextBox(Environment.NewLine + "Total price: " + currentClient.GetTotalPrice().ToString());
            }
        }

        private void NotifyUserInTextBox(string message)
        {
            LogTextBox.Text += message;
            LogTextBox.Text += Environment.NewLine;
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            if (clonedClient != null)
            {
                clonedClient.GetList();
                NotifyUserInTextBox(Environment.NewLine + "Total price: " + clonedClient.GetTotalPrice().ToString());
            }
        }

        private void CloneButton_Click(object sender, RoutedEventArgs e)
        {
            clonedClient = ((Client)currentClient.DeepCopyClone());
            clonedClient.NotifyUser = NotifyUserInTextBox;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            LogTextBox.Clear();
        }
    }
}
