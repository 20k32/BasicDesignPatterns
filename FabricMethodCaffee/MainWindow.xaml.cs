using System.Threading.Tasks;
using System.Windows;
using Adapter;
using ArrayListAdapter;
using System;
using System.Linq;
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

            var range = Enumerable.Range(1, 10);

            MyList<int> arrayList = new MyList<int>();

            arrayList.SetList(range.ToArray());

            MyArray<int> adaptedArray = new MyArray<int>(25);
            adaptedArray = arrayList.Adapt(adaptedArray.ElementCount);

            foreach (var item in adaptedArray)
            {
                MessageBox.Show("a-" + item.ToString());
            }
        }

       /* List<ISaveLoad> saveClassesList = new List<ISaveLoad>();
        public async Task SaveAll()
        {
            await Task.Run(() =>
            {
                Parallel.ForEach(saveClassesList,
                (x) =>
                {
                    x.Save(BIN_FILE_PATH);
                });
            });
        }*/


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

        private void BinRadioButton_Click(object sender, RoutedEventArgs e)
        {
            saveToFileAdapted = new SaveToBinaryFileClassAdapted();
            ContentListBox.SelectedItem = sender;
        }

        private void TxtRadioButton_Click(object sender, RoutedEventArgs e)
        {
            saveToFileAdapted = new SaveToTxtFileClassAdapted();
            ContentListBox.SelectedItem = sender;
        }

        private void JsonRadioButton_Click(object sender, RoutedEventArgs e)
        {
            saveToFileAdapted = new SaveToJsonFileClassAdapted();
            ContentListBox.SelectedItem = sender;
        }

        private void XamlRadioButton_Click(object sender, RoutedEventArgs e)
        {
            saveToFileAdapted = new SaveToXmlFileClassAdapted();
            ContentListBox.SelectedItem = sender;
        }
    }   
}
