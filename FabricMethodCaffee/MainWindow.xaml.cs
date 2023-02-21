using System.Windows;
using System.Collections.Generic;
using Adapter;
//using Adapter;


namespace FabricMethodCaffee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string BIN_FILE_PATH = "myfile";

        ISaveLoad saveToFileAdapted;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            SomeTextBox.Clear();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            saveToFileAdapted.SetData(SomeTextBox.Text);
            saveToFileAdapted.Save(BIN_FILE_PATH);
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            SomeTextBox.Clear();
            SomeTextBox.Text = saveToFileAdapted.Load(BIN_FILE_PATH);
        }

        private void LoadTxtButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveTxtButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BinRadioButton_Click(object sender, RoutedEventArgs e)
        {
            saveToFileAdapted = new SaveToBinaryFileClassAdapted();
        }

        private void TxtRadioButton_Click(object sender, RoutedEventArgs e)
        {
            saveToFileAdapted = new SaveToTxtFileClassAdapted();
        }

        private void JsonRadioButton_Click(object sender, RoutedEventArgs e)
        {
            saveToFileAdapted = new SaveToJsonFileClassAdapted();
        }

        private void XamlRadioButton_Click(object sender, RoutedEventArgs e)
        {
            saveToFileAdapted = new SaveToXmlFileClassAdapted();
        }
    }   
}
