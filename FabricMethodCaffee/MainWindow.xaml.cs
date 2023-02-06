using System.Windows;
using FabricMethodLibrary;

namespace FabricMethodCaffee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AbstractCafe myCafe;

        private const string ORDER = "Your order: ";
        private const string CAFE = "Your cafe: ";

        public void Alert(string message)
        {
            MessageBox.Show(message);
        }

        public MainWindow()
        {
            InitializeComponent();
        }
        
        public void PrintUserOrder(string order, string cafe)
        {
            OrderTextBlock.Text = order;
            CaffeeTextBlock.Text = cafe;
        }

        public void EnableOrderButtons(bool value)
        {
            EspressoCafeButton.IsEnabled = LatteCafeButton.IsEnabled =
               AmericanoCafeButton.IsEnabled = CappucinoCafeButton.IsEnabled = value;
        }

        private void MakeCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            myCafe.MakeCoffee();
            DrinkCoffeeButton.IsEnabled = true;
            MakceCoffeeButton.IsEnabled = false;
        }

        private void DrinkCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            Alert("Coffe drinked");
            myCafe = null!;
            DrinkCoffeeButton.IsEnabled = false;
            EnableOrderButtons(true);
            PrintUserOrder(string.Empty, string.Empty);
        }

        private void EspressoCafeButton_Click(object sender, RoutedEventArgs e)
        {
            myCafe = new EspressoCafe(EspressoCafeTextBox.Text, Alert); 
            MakceCoffeeButton.IsEnabled = true;
            PrintUserOrder(ORDER + myCafe.GetCoffee().ToString(), CAFE + myCafe.ToString());
            EnableOrderButtons(false);
        }

        private void LatteCafeButton_Click(object sender, RoutedEventArgs e)
        {
            myCafe = new LatteCafe(LatteCafeTextBox.Text, Alert);  
            MakceCoffeeButton.IsEnabled = true;
            PrintUserOrder(ORDER + myCafe.GetCoffee().ToString(), CAFE + myCafe.ToString());
            EnableOrderButtons(false);
        }

        private void AmericanoCafeButton_Click(object sender, RoutedEventArgs e)
        {
            myCafe = new AmericanoCafe(AmericanoCafeTextBox.Text, Alert);
            MakceCoffeeButton.IsEnabled = true;
            PrintUserOrder(ORDER + myCafe.GetCoffee().ToString(), CAFE + myCafe.ToString());
            EnableOrderButtons(false);
        }

        private void CappucinoCafeButton_Click(object sender, RoutedEventArgs e)
        {
            myCafe = new CappuccinoCafe(CappucinoCafeTextBox.Text, Alert);
            MakceCoffeeButton.IsEnabled = true;
            PrintUserOrder(ORDER + myCafe.GetCoffee().ToString(), CAFE + myCafe.ToString());
            EnableOrderButtons(false);
        }
    }
}
