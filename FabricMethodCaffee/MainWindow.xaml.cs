using System;
using System.Windows;
using ChainOfResponsibility;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Linq;
using ChainOfResponsibility_Servers;

namespace FabricMethodCaffee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private List<string> currentUsers = null!;

        public MainWindow()
        {
            currentUsers = new List<string>(new string[] { "Bob", "Rob", "Alex", "All" });
            InitializeComponent();
            UserSelectionBox.SelectedIndex = 0;
        }

        private void UserSelectionBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)((ComboBox)sender).SelectedItem;

            BobPanel.Visibility =
            RobPanel.Visibility =
            AlexPanel.Visibility = Visibility.Hidden;

            SendToBox.Items.Clear();

            foreach (string user in currentUsers.Where(x => !x.Equals(selectedItem.Content.ToString())))
            {
                SendToBox.Items.Add(user);
            }

            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    BobPanel.Visibility = Visibility.Visible;
                    break;
                case 1:
                    RobPanel.Visibility = Visibility.Visible;
                    break;
                case 2:
                    AlexPanel.Visibility = Visibility.Visible;
                    break;
            }
        }
    }
}
