using System;
using System.Windows;
using System.Windows.Controls;
using ProxyCalculator;

namespace FabricMethodCaffee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        private string? FirstValue = null;
        private string? SecondValue = null;

        private Calculator calculator = null!;
        private ProxyCalculatorClass proxyCalculator = null!;

        public MainWindow()
        {
            calculator = new Calculator();
            proxyCalculator = new ProxyCalculatorClass(calculator);

            InitializeComponent();
        }

        private void EraseButton_Click(object sender, RoutedEventArgs e)
        {
            OperationTextBox.Clear();
            FirstValue = null!;
            SecondValue = null!;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OperationTextBox.Text += ((Button)sender).Content.ToString();
        }

        private void SetValues()
        {
            if (FirstValue == null)
            {
                FirstValue = OperationTextBox.Text;
            }
            else
            {
                SecondValue = OperationTextBox.Text;
            }
            OperationTextBox.Clear();
        }

        private void AdditionButton_Click(object sender, RoutedEventArgs e)
        {
            SetValues();
            proxyCalculator.Operation = proxyCalculator.Sum;
        }

        private void SubtractionButton_Click(object sender, RoutedEventArgs e)
        {
            SetValues();
            proxyCalculator.Operation = proxyCalculator.Subtraction;
        }

        private void MultiplicationButton_Click(object sender, RoutedEventArgs e)
        {
            SetValues();
            proxyCalculator.Operation = proxyCalculator.Multiplication;
        }

        private void DivisionButton_Click(object sender, RoutedEventArgs e)
        {
            SetValues();
            proxyCalculator.Operation = proxyCalculator.Division;
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            SetValues();
            OperationTextBox.Text += proxyCalculator.Calculate(FirstValue!, SecondValue!);
            FirstValue = null!;
            SecondValue = null!;
        }

        private void DeleteLastCharButton_Click(object sender, RoutedEventArgs e)
        {
            if (OperationTextBox.Text.Length > 0)
            {
                string newTextFromTextBox = OperationTextBox.Text.AsSpan(0, OperationTextBox.Text.Length - 1).ToString();
                OperationTextBox.Text = newTextFromTextBox;
            }
        }
    }
}
